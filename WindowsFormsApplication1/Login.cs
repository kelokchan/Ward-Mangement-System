using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = usernameBox.Text.ToLower();
            string password = passwordBox.Text;

            if (username.Equals("tp1234") && password.Equals("1234"))
            {
                MessageBox.Show("Welcome!");
                Main main = new Main();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username/password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Login lg = new Login();
                lg.ShowDialog();
            }
        }
    }
}
