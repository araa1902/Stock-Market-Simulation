using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace STOCKUI2
{
    internal class PortfolioDB
    {
 
        private double GiveAggregateData(string FunctionType, string table, string column)
        {
            // Create method to make it more accessible to find the aggregate data passing in a table, column and type of SQL function
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQLQuery = $"SELECT {FunctionType}({column}) FROM {table} NOLOCK WHERE userID = {UserCredsDB.UserID}";

                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    SQLiteDataReader _reader = comm.ExecuteReader();

                    while (_reader.Read())
                    {

                        double result = _reader.GetDouble(0); // not empty
                        conn.Close();
                        return result;


                    }
                    return -1;

                }

            }

        }

        protected void UpdatePortfolio(Order order, double transactionPrice, bool StockExists)
        { // Method used to update portfolio depending on if they have bought or sold stock if they have or have not  previously owned the stock.
            try
            {
                if (order.GetTransactionType() == "BUY") // Checks if the transaction type is a buy
                {
                    if (StockExists) // Condition depending on if the stock exists in portfolio
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
                        {
                            conn.Open();
                            string SQLQuery = $"UPDATE Portfolio SET NumberOfShares = '{GetSharesForTicker(order.GetTicker()) + order.GetQuantity()}' WHERE Ticker = '{order.GetTicker()}' AND userID = {UserCredsDB.UserID}";
                            // Updates the number of shares to be the sum of the current number of shares in portfolio and the order quantity.
                            using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                            {
                                comm.ExecuteNonQuery();
                            }
                            conn.Close();
                            conn.Open();
                            string Query = $"UPDATE Portfolio SET MoneyInvested = '{GetMoneyInvestedForTicker(order.GetTicker()) + transactionPrice}' WHERE Ticker = '{order.GetTicker()}' AND userID = {UserCredsDB.UserID}";
                            // Sets the money invested in the stock to the original amount of money invested and transaction price.
                            using (SQLiteCommand comm = new SQLiteCommand(Query, conn))
                            {
                                comm.ExecuteNonQuery();
                            }
                            conn.Close();
                        }

                    }
                    else
                    { // If the stock doesn't exist in user portfolio, we should create a new field containing that.
                        using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
                        {
                            conn.Open();
                            string SQLQuery = $"INSERT INTO Portfolio (Ticker, NumberOfShares, MoneyInvested, userID) VALUES ('{order.GetTicker()}', {order.GetQuantity()}, {transactionPrice}, {UserCredsDB.UserID})";
                            using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                            {
                                comm.ExecuteNonQuery();
                            }
                            conn.Close();
                        }

                    }


                }
                else if (order.GetTransactionType() == "SELL")
                {
                    // Same principle as above but for selling.
                    if (StockExists == true)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
                        {
                            conn.Open();
                            int ShareAmount = GetSharesForTicker(order.GetTicker()) - order.GetQuantity();
                            if (ShareAmount == 0)
                            {
                                TransactionDB.RemoveStock(order);
                            }
                            else
                            {
                                string SQLQuery = $"UPDATE Portfolio SET NumberOfShares = {ShareAmount} WHERE Ticker = '{order.GetTicker()}' AND userID = {UserCredsDB.UserID}";
                                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                                {
                                    comm.ExecuteNonQuery();
                                }
                                conn.Close();
                                conn.Open();

                                string Query = $"UPDATE Portfolio SET MoneyInvested = {GetMoneyInvestedForTicker(order.GetTicker()) - transactionPrice} WHERE Ticker = '{order.GetTicker()}' AND userID = {UserCredsDB.UserID}";
                                using (SQLiteCommand comm = new SQLiteCommand(Query, conn))
                                {
                                    comm.ExecuteNonQuery();
                                }
                                conn.Close();
                            }
                        }

                    }


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Failed", "Error", MessageBoxButtons.OKCancel);


            }



        }


        public static bool CheckForPortfolioData()
        { 
            //Check used so when user opens portfolio section, if they don't have data, they won't be able to search and access information.,
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();

                string SQL = $"SELECT Ticker FROM Portfolio NOLOCK WHERE userID = {UserCredsDB.UserID}";

                using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                {
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reader.Close();
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            reader.Close();
                            conn.Close();
                            return false;

                        }

                    }
                }



            }

        }


        public int GetSharesForTicker(string ticker)
        {

            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQLQuery = $"SELECT NumberOfShares FROM Portfolio NOLOCK WHERE Ticker = '{ticker}' AND userID = {UserCredsDB.UserID} ";
                // use of cross-table parameterised SQL queries
                int shares = 0;
                using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                {
                    using (SQLiteDataReader _reader = comm.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            shares = _reader.GetInt32(0);
                        }
                        _reader.Close();


                    }
                }
                conn.Close();
                return shares;

            }
        }

        public List<string> GetMaxSharesForStock()
        {
            List<string> data = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();

                string SQL = $"SELECT portfolio.Ticker, portfolio.NumberOfShares FROM Portfolio portfolio JOIN USERS user ON portfolio.userID = user.AccountID WHERE portfolio.NumberOfShares = {GiveAggregateData("MAX", "Portfolio", "NumberOfShares")}";
                // Again a representation of parameterised JOIN SQL queries collecting the maximimum shares on a user's portfolio
                using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                {
                    using (SQLiteDataReader _reader = comm.ExecuteReader())
                    {
                        if (_reader.Read())
                        {
                            data.Add(_reader.GetString(0));
                            data.Add(Convert.ToString(_reader.GetInt32(1)));

                        }
                        _reader.Close();
                    }

                }
                conn.Close();
                return data;

            }
        }
        public List<string> GetMostExpensiveInvestment()
        {
            List<string> data = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();

                string SQL = $"SELECT Ticker, MAX(TransactionPrice) FROM Orders NOLOCK WHERE wallet_ID = {UserCredsDB.WalletID} AND TransactionType = 'BUY'";

                using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                {
                    using (SQLiteDataReader _reader = comm.ExecuteReader())
                    {
                        if (_reader.Read())
                        {
                            data.Add(_reader.GetString(0));
                            data.Add(Convert.ToString(_reader.GetDouble(1)));

                        }
                        _reader.Close();
                    }


                }
                conn.Close();
                return data;


            }




        }
        public double GetMoneyInvestedForTicker(string ticker)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
                {
                    conn.Open();
                    //"Data Source=<path to database file>;Version=3;New=True;Compress=True;"
                    string SQLQuery = $"SELECT MoneyInvested FROM Portfolio NOLOCK WHERE Ticker = '{ticker}' AND userID = {UserCredsDB.UserID}";

                    using (SQLiteCommand comm = new SQLiteCommand(SQLQuery, conn))
                    {
                        SQLiteDataReader _reader = comm.ExecuteReader();

                        while (_reader.Read())
                        {

                            double MoneyInvested = _reader.GetDouble(0);
                            _reader.Close();
                            conn.Close();
                            return MoneyInvested;



                        }


                        return -1;

                    }


                }

            }
            catch
            {
                return -1;

            }



        }

        public double GetTotalMoneyInvested()
        {
            return GiveAggregateData("SUM", "Portfolio", "MoneyInvested");

        }



        public double GetProfitOrLoss()
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                string SQL = $"SELECT SUM(TransactionPrice - MoneyInvested) FROM Portfolio portfolio JOIN Orders orders ON portfolio.Ticker = orders.Ticker WHERE portfolio.userID = {UserCredsDB.UserID} AND orders.TransactionType = 'BUY'";
                // Conjuction of both aggregate and join table parameterised SQL calculating the profit of a user portfolio.

                using (SQLiteCommand comm = new SQLiteCommand(SQL, conn))
                {
                    using (SQLiteDataReader _reader = comm.ExecuteReader())
                    {

                        _reader.Read();
                        double Profit = _reader.GetDouble(0);
                        conn.Close();
                        return Profit;

                    }
                }
            }
        }
    }
}
