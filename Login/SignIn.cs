using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace STOCKUI2
{
    public partial class SignIn : Form
    {
        
        private UserCredentials creds;
        public SignIn()
        {
            creds = new UserCredentials();
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text != string.Empty || Password.Text != string.Empty)
            {
                if (creds.CheckForUserCreds(Username.Text, Password.Text))
                {
                    UserCredsDB.UserID = UserCredentials.GetUserId(Username.Text);
                    UserCredsDB.WalletID = UserCredentials.GetUserWalletID();
                    MessageBox.Show($"Welcome {Username.Text}", "WELCOME", MessageBoxButtons.OK);
                    
                    Dashboard form = new Dashboard();
                    this.Visible = false;
                    form.Show();

                }
                else
                {
                    MessageBox.Show("No account available with these credientials");

                }
            
            
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePage pg = new WelcomePage();
            pg.Show();
            this.Visible = false;
        }
    }
}
