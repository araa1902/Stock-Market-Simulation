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
    public partial class SignUp : Form
    {
        private UserCredentials creds;
        public SignUp()
        {
            creds = new UserCredentials();
            InitializeComponent();
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            
            if (CheckEmptyFields(UsernameField, PasswordField, ConfirmPassword) == false)   
            {
                if (!creds.CheckUserAlreadyExists(UsernameField.Text))
                {
                    if (CheckSignCorrect(PasswordField.Text, ConfirmPassword.Text) == true)
                    {
                        creds.InitialiseAccount(UsernameField.Text, PasswordField.Text);
                        creds.CreateWallet(UsernameField.Text);
                        MessageBox.Show("Account Created!");
                        this.Visible = false;

                        WelcomePage form = new WelcomePage();
                        form.Show();


                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match each other. Please re-enter password", "Fault", MessageBoxButtons.OK);

                    }


                }
                else
                {
                    MessageBox.Show("Username already exists. Please try again", "Fault", MessageBoxButtons.OK);

                }
               

            }
            else
            {
                
                MessageBox.Show("One or more fields are empty", "Error", MessageBoxButtons.OK);

            }
            






        }

        private bool CheckSignCorrect(string Password, string CorrectPassword)
        {
            return Password == CorrectPassword;


        }
        private bool CheckEmptyFields(TextBox b1, TextBox b2, TextBox b3)
        {
            if (b1.Text == string.Empty || b2.Text == string.Empty || b3.Text == string.Empty)
            {
                return true;

            }
            else
            {
                return false;
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage pg = new WelcomePage();
            pg.Show();
            this.Visible = false;
        }
    }
}
