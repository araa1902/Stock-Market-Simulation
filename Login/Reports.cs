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

namespace STOCKUI2
{
    public partial class Reports : Form
    {
        private UserCredentials creds;
        public Reports()
        {
            InitializeComponent();
           creds= new UserCredentials();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.UsernameLBL.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ChoiceLBL.DropDownStyle = ComboBoxStyle.DropDownList;
            ChoiceLBL.Items.Add("Orders");
            ChoiceLBL.Items.Add("Portfolio");
            ChoiceLBL.Items.Add("Delete User");
            NumberUserLBL.Text = Convert.ToString(UserCredsDB.GetUserCount());
            List<string> Usernames = UserCredsDB.GetUsernames();

            foreach (string username in Usernames)
            {
                UsernameLBL.Items.Add(username);
            
            
            }
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChoiceLBL.Text == "Orders")
            {
                using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
                {
                    conn.Open();

                    SQLiteDataAdapter adp = new SQLiteDataAdapter($"SELECT Ticker, Quantity, PriceAtTransaction, TransactionTime, TransactionPrice, TransactionType FROM Orders WHERE wallet_ID = {UserCredentials.GetUserId(UsernameLBL.Text)}", conn);

                    DataSet ds = new System.Data.DataSet();
                    adp.Fill(ds);
                    ReportGrid.DataSource = ds.Tables[0];
                    conn.Close();

                }


            }
            else if (ChoiceLBL.Text == "Portfolio")
            {
                using (SQLiteConnection conn = new SQLiteConnection(TransactionDB.ConnStr))
                {
                    conn.Open();

                    SQLiteDataAdapter adp = new SQLiteDataAdapter($"SELECT Ticker, NumberOfShares, MoneyInvested FROM Portfolio WHERE userID = {UserCredentials.GetUserId(UsernameLBL.Text)}", conn);

                    DataSet ds = new System.Data.DataSet();
                    adp.Fill(ds);
                    ReportGrid.DataSource = ds.Tables[0];
                    conn.Close();

                }


            }
            else
            {
                DialogResult d = MessageBox.Show($"Are you sure you would like to Delete the account {UsernameLBL.Text}?", "WARNING", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {

                    creds.DeleteUser(UsernameLBL.Text);
                    MessageBox.Show("Account deleted successfully", "Complete", MessageBoxButtons.OK);
                    Reports Reportform = new Reports();
                    this.Close();
                    Reportform.Refresh();
                    Reportform.Show();
                }


            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomePage pg = new WelcomePage();
            pg.Show();
            this.Visible = false;
        }

        private void UsernameLBL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
