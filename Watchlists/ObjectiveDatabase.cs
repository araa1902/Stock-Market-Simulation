using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace STOCKUI2
{
    abstract class ObjectiveDB // Made class abstract to prevent multiple instances of the database class being created. Used to provide methods of functionality for classes both inhertiting and in the UI.
    {

        protected void AddObjectiveToDB(Objective obj)
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {

                conn.Open();
                string SQLquery = $"INSERT INTO Objectives (Title, Description, Priority, Deadline, IsComplete, userID) VALUES ('{obj.GetTitle()}', '{obj.GetTask()}', '{obj.GetStrPriority()}', '{Convert.ToString(obj.GetDeadline())}', {false}, '{UserCredsDB.UserID}');";
                // Query to add an objective to table

                using (SQLiteCommand comm = new SQLiteCommand(SQLquery, conn))
                {
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        protected List<Objective> GetObjectivesFromDB()
        {
            List<Objective> objectives = new List<Objective>();
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();

                string SQLquery = $"SELECT * FROM Objectives NOLOCK WHERE userID = {UserCredsDB.UserID}";
                // Returns all the objectives from the table as a List of 'Objective'. This is used to gather all objectives to display on table

                using (SQLiteCommand comm = new SQLiteCommand(SQLquery, conn))
                {
                    using (SQLiteDataReader _reader = comm.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            Objective obj = new Objective();
                            obj.ObjectiveID = Convert.ToInt32(_reader.GetInt32(0));
                            obj.Title = Convert.ToString(_reader.GetString(1));
                            obj.task = Convert.ToString(_reader.GetString(2));
                            obj.Priority = Convert.ToString(_reader.GetString(3));
                            obj.Status = Convert.ToBoolean(_reader.GetBoolean(5));
                            obj.Deadline = Convert.ToDateTime(_reader.GetString(4));
                            objectives.Add(obj);
                        }
                        conn.Close();
                        return objectives;
                    }

                }

            }

        }

        public static int GetOBJID()
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQLQuery = $"SELECT ObjectiveID FROM Objectives NOLOCK WHERE Title = '{ObjectivesUI.title}' AND Description = '{ObjectivesUI.Description}';";
                // Returns the objective ID of a selected objective so when a user clicks the edit button to another form, it will return the ID to display the selected Objective

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
        public static void EditObj(Objective obj)
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {

                try
                {
                    conn.Open();
                    string status = Convert.ToString(obj.GetStatus()).ToLower();
                    string SQLQuery = $"UPDATE Objectives SET Title = '{obj.GetTitle()}', Description = '{obj.GetTask()}', Priority = '{obj.GetStrPriority()}', Deadline = '{obj.GetDeadline()}', IsComplete = {Convert.ToBoolean(status)} WHERE ObjectiveID = {ObjectiveDB.GetOBJID()}";
                    // Used to edit a given objective changing what has been typed into the edit columns
                    using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                    {
                        comm.ExecuteNonQuery();

                    }
                    conn.Close();
                }
                catch
                {

                }
            }



        }
        public static bool CheckForObjectiveData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();

                string SQL = $"SELECT Title FROM Objectives NOLOCK WHERE userID = {UserCredsDB.UserID}";
                // Query used to check if a user has any objectives. Used to prevent exception of trying to gather objectives that don't exist.

                try
                {
                    using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                    {
                        using (SQLiteDataReader reader = comm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }


                }
                catch
                {
                    return false;
                
                }
               
            }
        }


    
    }
}
