using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOCKUI2
{

    internal class Transactions : TransactionDB
    // Class inherits methods from TransactionDB - makes it easier to access methods, provides separation between front-end and backend. 
    {
        private Order order;
        private API api;
        private PortfolioDB DBInstance;
        // Use of composition and dynamic generation of objects through both the order and having an API instance.

        public Transactions(Order ORDER)
        {
            this.order = new Order(ORDER.GetTicker(), ORDER.GetQuantity(), Convert.ToDateTime(ORDER.GetDateOfTransaction()), ORDER.GetTransactionType());
            // Initialising both the order object and API instance for use.
            api = new API();
            DBInstance = new PortfolioDB();
        }
        public Transactions()
        {



        }

        private bool CheckFunds(double TransactionPrice)
        {
            return GetAccountBalance() > TransactionPrice;
            // Retrieves account balance and measures if a user has sufficient funds for a transaction buy - links to Wallet table via TransactionDB class.

        }
        private bool CheckInvalidStock(double price)
        {
            return price == 0; // API check to find out if the stock they have searched is valid for selling
        }
        
        public async void MakeTransaction()
        {
            try
            {
                double PriceOfStock = await api.GetCurrentPrice(order.GetTicker()); // retrieves stock price via API.
                if (!CheckInvalidStock(PriceOfStock)) // Validation of checking for a correct stock symbol.
                {
                    double PriceOfPurchase = Math.Round(PriceOfStock * order.GetQuantity(), 2);
                    if (CheckFunds(PriceOfPurchase)) // Compares user's balance and purchase price if it is allowed.
                    {
                        if (CheckStockExists(GetInvestmentTickers(), order.GetTicker())) 
                            // Collects the user's portfolio companies and the stock they have picked and performs recursive search to check if stock exists within portfolio
                        {

                            ChangeBalanceForBuy(PriceOfPurchase); // Changes user's balance 
                            AddTransactionToDB(order, PriceOfStock, PriceOfPurchase); // Adds transaction to table 'Orders'
                            UpdatePortfolio(order, PriceOfPurchase, true); // Updates user's portfolio statisics (stock already exists) - changes the number of shares and amount of money invested.
                            MessageBox.Show($"Transaction Successful", "Confirmed", MessageBoxButtons.OKCancel); // Suitable message responses
                        }
                        else // If User doesn't already have stock in portfolio, it will add stock to portfolio table but as a fresh field.
                        {

                            ChangeBalanceForBuy(PriceOfPurchase); // Changes user's balance
                            AddTransactionToDB(order, PriceOfStock, PriceOfPurchase); // Adds transaction to table 'Orders'
                            UpdatePortfolio(order, PriceOfPurchase, false); // Updates user's portfolio statistics (stock doesn't exist)
                            MessageBox.Show($"Transaction Successful", "Confirmed", MessageBoxButtons.OKCancel); 


                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient funds for transaction", "Error", MessageBoxButtons.OKCancel); // Suitable error message for insufficientfunds
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Ticker Entered", "Error", MessageBoxButtons.OKCancel);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Transaction Failed. Technical Error", "Error", MessageBoxButtons.OKCancel);



            }


        }
        public async void SellStock()
        {
           try
            {

                double PriceOfStock = await api.GetCurrentPrice(order.GetTicker()); // retrieves price of Stock via API
                if (!CheckInvalidStock(PriceOfStock) && order.GetQuantity() > 0) // Checks if the stock is valid from the NYSE and also checks if order field is greater than 0
                {

                    if (CheckStockExists(GetInvestmentTickers(), order.GetTicker())) // Recursive search which collects both the user's invested companies and order stock symbol to check
                        // If the stock exists in the portfolio
                    {

                        if (CheckSufficentStockAmount(order)) // Compares the number of stocks of that certain stock already invested and checks if it greater than the order amount.
                        {

                            double PriceOfPurchase = Math.Round(PriceOfStock * order.GetQuantity(), 2); // Calculates Total Price.
                            ChangeBalanceForSell(PriceOfPurchase); // Changes the user's wallet balance
                            AddTransactionToDB(order, PriceOfStock, PriceOfPurchase); // Adds the transaction to the Database table 'Orders'
                            UpdatePortfolio(order, PriceOfPurchase, true); // Updates user portfolio 
                            MessageBox.Show($"Transaction Successful ", $"Confirmed", MessageBoxButtons.OKCancel);

                        }
                       else
                        {
                            MessageBox.Show($"Insufficient Number Of Stock for transaction ", $"Error", MessageBoxButtons.OKCancel);

                        }
                    }
                    else
                    {
                        //UpdatePortfolio(order, PriceOfPurchase, false);
                        MessageBox.Show($"Stock doesn't exist in portfolio", "Error", MessageBoxButtons.OKCancel);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Ticker or Invalid Stock Amount", "Error", MessageBoxButtons.OKCancel);
                }


            }
            catch (Exception e)
            {

                MessageBox.Show($"Transaction Failed: {e}", "Error", MessageBoxButtons.OKCancel);
            }

        }
    }

    internal class Order
    {
        private string ticker; // privatising properties - Using encapsulation to get these properties.
        private int Quantity;
        private DateTime DateOfTransaction;
        private string TransactionType;
        
        public Order()
        {



        }

        public Order(string ticker, int Quantity, DateTime DateOfTransaction, string TransactionType)
        {
            this.ticker = ticker;
            this.Quantity = Quantity;
            this.DateOfTransaction = DateOfTransaction;
            this.TransactionType = TransactionType;

        }

        public string GetTicker()
        {
            return ticker.ToUpper();
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public string GetDateOfTransaction()
        {
            return string.Format("{0:G}", DateOfTransaction);  // formats date in the correct form for processing within database.
        }

        public string GetTransactionType()
        {
            return TransactionType;
        }

    }
}







