using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using LiveChartsCore.Themes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace STOCKUI2
{
     abstract class UserCredsDB
     {
        public static int UserID;   
        public static int WalletID;
        private static readonly string ADMINPWD = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive - Bradford Grammar School\\Home Drive\\computer science\\Year 13 - Year 1\\NEA 10JAN\\testtttt\\NEA - 19DEC\\NEA\\AdminPassword.txt";
        public static string GetAdmin_PWD()
        {   
            try
            {
                using (StreamReader reader = new StreamReader(ADMINPWD, true))
                {

                    string Password = reader.ReadLine();
                    return Password;

                }

            }
            catch (Exception exception)
            {
                throw exception;

            }

        }

        public void InitialiseAccount(string Username, string Password)
        {
            Random rnd = new Random();
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();

                string SQLQuery = $"INSERT INTO USERS (Username, Password) VALUES ('{Username}', '{Hash.HashPassword(Password)}');";
                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    comm.ExecuteNonQuery();

                }
                conn.Close();


            }
        }

        public void CreateWallet(string username)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQLQuery = $"INSERT INTO WALLET (Balance, userID) VALUES (10000, '{GetUserIDFromUsername(username)}');";
                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    comm.ExecuteNonQuery();

                }
                conn.Close();
            }


        }
        protected static int GetUserIDFromUsername(string username)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
                {
                    conn.Open();
                    string SQLQuery = $"SELECT AccountID FROM USERS NOLOCK WHERE Username = '{username}'";

                    using (SQLiteCommand cmd = new SQLiteCommand(SQLQuery, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader.GetInt32(0));
                                reader.Close();
                                conn.Close();
                                return id;

                            }

                            return -1;

                        }

                    }
                }

            }
            finally
            {


            }

        }
        protected static int GetWalletIDFromUsername()
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQLQuery = $"SELECT WalletID FROM WALLET NOLOCK WHERE userID = '{UserCredsDB.UserID}'";

                using (SQLiteCommand cmd = new SQLiteCommand(SQLQuery, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader.GetInt32(0));

                            conn.Close();

                            return id;

                        }
                        return -1;
                    }


                }
            }
        }

        public bool CheckUserAlreadyExists(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                
                string SQLQuery = $"SELECT * FROM USERS NOLOCK WHERE Username = '{username}'";

                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    SQLiteDataReader _reader = comm.ExecuteReader();

                    if (_reader.Read())
                    {
                        conn.Close();
                        return true;


                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }
            }

        }
        public void DeleteUser(string username)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQLQuery = $"DELETE FROM USERS WHERE AccountID = {GetUserIDFromUsername(username)}";
                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    comm.ExecuteNonQuery();

                }
                conn.Close();
            }

        }
        public static List<string> GetUsernames()
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                List<string> Usernames = new List<string>();
                string SQL = "SELECT Username FROM USERS";
                using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                {
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usernames.Add(reader.GetString(0));

                        }
                    }
                    conn.Close();
                
                
                }

                return Usernames;
            }
        
        
        }

        public static int GetUserCount() {

            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                int count = 0;
                string SQL = "SELECT COUNT(Username) FROM USERS";
                using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                {
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           count = reader.GetInt32(0);
                        }
                    }
                    conn.Close();


                }

                return count;
            }



        }
        public bool CheckForUserCreds(string username, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
               
                string SQLQuery = $"SELECT * FROM USERS NOLOCK WHERE Username = '{username}' AND Password = '{Hash.HashPassword(password)}'";

                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    SQLiteDataReader _reader = comm.ExecuteReader();

                    if (_reader.Read())
                    {
                        conn.Close();
                        return true;


                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }


            }

        }
    }
}
