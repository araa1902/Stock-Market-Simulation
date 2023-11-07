using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCKUI2
{
    public partial class SignInADMIN : Form
    {
        private static int tries = 3;
        public SignInADMIN()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SignInADMIN.tries == 0)
            {
                AdminLoginButton.Enabled= false;
                label2.Text = "Locked out of admin use.";
                Thread.Sleep(5000);
                

            }
            if (AdminPasswordField.Text == UserCredsDB.GetAdmin_PWD())
            {
                Reports reports = new Reports();
                reports.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show($"Incorrect password", "Error", MessageBoxButtons.OKCancel);
                SignInADMIN.tries --;
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePage pg = new WelcomePage(); 
            pg.Show();
            this.Visible=false;
        }

        private void SignInADMIN_Load(object sender, EventArgs e)
        {

        }
    }
}
