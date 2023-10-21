using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Transactions;
using OpenTK.Graphics.ES11;

namespace STOCKUI2
{
    public partial class PortfolioPage : Form
    {
       private PortfolioManager pm;
       private Transactions transaction;


        public PortfolioPage()
        {
            transaction = new Transactions();
            pm = new PortfolioManager();
            InitializeComponent();
        }

        private void PortfolioPage_Load(object sender, EventArgs e)
        {
            this.InvestedStocksList.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StartPosition = FormStartPosition.CenterScreen;
            BalanceLBL.Text = Convert.ToString($"${TransactionDB.GetAccountBalance()}");
            DisplayOrders();
            if (PortfolioDB.CheckForPortfolioData())
            {

                List<string> tickers = pm.GetInvestmentTickers();

                foreach (string ticker in tickers)
                {
                    InvestedStocksList.Items.Add(ticker);

                }


            }
            else
            {
                SearchButton.Enabled= false;
                PortfolioViewButton.Enabled = false;
            
            }
           
        }

        private void DisplayOrders()
        {
            using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
            {
                conn.Open();
                SQLiteDataAdapter adp = new SQLiteDataAdapter($"SELECT Ticker, Quantity, PriceAtTransaction, TransactionTime, TransactionPrice, TransactionType FROM Orders NOLOCK WHERE wallet_ID = {UserCredsDB.WalletID}", conn);
                DataSet ds = new System.Data.DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
        
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void pieChart1_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Would you like to make this payment?", "WARNING", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Order Order = new Order(TickerBox.Text, Convert.ToInt32(QuantityBox.Value), DateTime.Now, "SELL");
                Transactions TRANSACTION = new Transactions(Order);
                TRANSACTION.SellStock();
                PortfolioPage pg = new PortfolioPage();
                pg.Show();
                this.Visible = false;
            }
            else
            {
                
            
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ticker = InvestedStocksList.Text;
            if(InvestedStocksList.SelectedItem != null)
            {
                ProportionLBL.Text = $"{Math.Round(pm.GetProportion(ticker), 2)}%";
                MoneyInvestedLabel.Text = $"${Math.Round(pm.GetMoneyInvestedForTicker(ticker), 2)}";
                ShareLabel.Text = Convert.ToString(pm.GetSharesForTicker(ticker));


            }
            else
            {
                MessageBox.Show("No ticker selected", "Error", MessageBoxButtons.OKCancel);


            }
            
           


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (PortfolioDB.CheckForPortfolioData())
            {
                List<string> MaxShares = pm.GetMaxSharesForStock();
                List<string> MaxInvestment = pm.GetMostExpensiveInvestment();
                LargestShares.Text = $"Stock: {MaxShares[0]}, Number: {MaxShares[1]}";
                MostExpensiveInvestment.Text = $"Stock: {MaxInvestment[0]}, Price: ${MaxInvestment[1]}";
                string ProfitText = Convert.ToString(Math.Round(pm.GetProfitOrLoss(), 2));
                if (ProfitText[0] == '-')
                {
                    ProfitTicker.ForeColor = Color.Red;

                }
                else
                {
                    ProfitTicker.ForeColor = Color.LawnGreen;

                }
                ProfitTicker.Text = $"${ProfitText}";

            }
            else
            {
                List<string> MaxInvestment = pm.GetMostExpensiveInvestment();
                MostExpensiveInvestment.Text = $"Stock: {MaxInvestment[0]}, Price: ${MaxInvestment[1]}";
                LargestShares.Text = $"No Stocks Invested In";
                ProfitTicker.Text = "No Stocks Currently Invested In. No Profit/Loss";


            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ObjectivesUI ui = new ObjectivesUI();
            ui.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeometricBrownianMotion gm = new GeometricBrownianMotion();
            gm.Show();
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
