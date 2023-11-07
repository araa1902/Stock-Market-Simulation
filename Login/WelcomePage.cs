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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Visible = false;

            signUp.Show();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignIn form = new SignIn();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          SignInADMIN form = new SignInADMIN();
            form.Show();
            this.Visible= false;
        }
    }
}
