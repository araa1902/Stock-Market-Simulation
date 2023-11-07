using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace STOCKUI2
{
    abstract class TransactionDB:PortfolioDB // Again using abstract class to be a hub for inherting the methods for the Transactions class - Also inherits from PortfolioDB class as both classes are heavily interlinked.
    {

        public static readonly string ConnStr = $"Data Source=\"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive - Bradford Grammar School\\Home Drive\\computer science\\Year 13 - Year 1\\NEA 10JAN\\testtttt\\NEA - 19DEC\\NEA\\STOCKUI2\\bin\\Debug\\net6.0-windows\\databaseFINAL.db\";";
        
        // Connection string of database - used paramaterised file paths to make the code versatile and useable on all devices.


        protected void AddTransactionToDB(Order order, double PriceAtTransaction, double TransactionPrice) // Protected identifier - Also used within transactions class.
        {
            // Method which adds new transaction to database. Takes the order made, Price at transaction for stock and total transaction price.
            using (SQLiteConnection conn = new SQLiteConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    string SQLQuery = $"INSERT INTO Orders(Ticker, Quantity, PriceAtTransaction, TransactionTime, TransactionPrice, TransactionType, wallet_ID) VALUES('{order.GetTicker()}', {order.GetQuantity()}, {PriceAtTransaction}, '{order.GetDateOfTransaction()}', {TransactionPrice}, '{order.GetTransactionType()}', {UserCredsDB.WalletID});";
                    // Parameterised SQL 
                    using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                    {
                        comm.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"{exc}");
                }

            }
        }
        protected void ChangeBalanceForBuy(double transactionPrice)
        {
            // Changes wallet balance of user.
            using (SQLiteConnection conn = new SQLiteConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    double balance = Math.Round(GetAccountBalance() - transactionPrice, 2);
                    string SQLQuery = $"UPDATE WALLET SET Balance = {balance} WHERE userID = {UserCredsDB.UserID};";
                    using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                    {
                        comm.ExecuteNonQuery();
                        comm.Dispose();
                    }
                    conn.Close();

                }
                catch(Exception exc)
                {

                }
            }

        }
        public static void RemoveStock(Order order)
        {
            // Method used to remove a stock from a portfolio if the number of shares is zero when the make a sell.
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQL = $"DELETE FROM Portfolio WHERE Ticker = '{order.GetTicker()}' AND userID = {UserCredsDB.UserID}";
                using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                {
                    comm.ExecuteNonQuery();
                    comm.Dispose();
                }
                conn.Close();
            }
        }
        protected void ChangeBalanceForSell(double transactionprice)
        {
            // Changes user balance for sell
            using (SQLiteConnection conn = new SQLiteConnection(ConnStr))
            {
                try
                {
                    conn.Open();
                    double balance = Math.Round(GetAccountBalance() + transactionprice, 2);
                    string SQLQuery = $"UPDATE WALLET SET Balance = {balance} WHERE userID = {UserCredsDB.WalletID}";
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
        public List<string> GetInvestmentTickers()
        {
            // Retrieves users' invested stocks - used in both showcasing them in the portfolio section for analysis and sell method.
            try
            {
                List<string> Companies = new List<string>();
                using (SQLiteConnection conn = new SQLiteConnection(ConnStr))
                {
                    conn.Open();
                    string SQLQuery = $"SELECT Ticker FROM Portfolio NOLOCK WHERE UserID = {UserCredsDB.UserID}";

                    using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                    {
                        using (SQLiteDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Companies.Add(reader.GetString(0));
                            }
                            reader.Close();
                            conn.Close();
                        }
                        conn.Close();
                    }

                    return Companies;
                }
            }
            catch
            {
                return null;
            }
        }

        public static double GetAccountBalance()
        {
            // Get User account balance.
            using (SQLiteConnection conn = new SQLiteConnection(ConnStr))
            {
                conn.Open();
                string SQLQuery = $"SELECT Balance FROM WALLET NOLOCK WHERE userID = {UserCredsDB.UserID} ";


                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double balance = Convert.ToDouble(reader.GetDouble(0));
                            conn.Close();
                            return balance;

                        }
                        reader.Close();
                        conn.Close();
                        return -1;
                    }
                }
            }
        }

        protected bool CheckSufficentStockAmount(Order order)
        {
            // Checks if the number of shares 
            return order.GetQuantity() <= GetSharesForTicker(order.GetTicker());

        }

        protected bool CheckStockExists(List<string> stocks, string TickerToSearch)
        // Recursive Search which takes in two parameters, a list of the user's invested stocks and the order stock
        {
            if (stocks.Count == 0) // Checks if the list length is 0 - this means that the stock doesn't exists
            {
                return false;
            }
            else if (stocks[0] == TickerToSearch) // If the stock at index 0 is equal to the order stock, it exists
            {
                return true;
            }
            else
            {
                stocks.RemoveAt(0); // Remove the item at index 0
                return CheckStockExists(stocks, TickerToSearch); // Recursive call to run function again.
            }
        }

    }
}
