using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Assassins_game
{
    public partial class Assassin_Registration : Form
    {
        DB Database = new DB();
        public Assassin_Registration()
        {
            InitializeComponent();
        }


        private void register_clear_Click(object sender, EventArgs e)
        {
            register_username_txtbox.Text = "";
            register_email_txtbox.Text = "";
            register_password_txtbox1.Text = "";
            register_password_txtbox2.Text = "";
        }

        private void register_goback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void register_password_txtbox1_TextChanged(object sender, EventArgs e)
        {
            register_password_txtbox1.PasswordChar = '*';
        }

        private void register_password_txtbox2_TextChanged(object sender, EventArgs e)
        {
            register_password_txtbox2.PasswordChar = '*';
        }

        private void register_register_Click(object sender, EventArgs e)
        {



        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = register_username_txtbox.Text;
            string email = register_email_txtbox.Text;
            string password = register_password_txtbox1.Text;

            string passwordHash = HashPassword(password);

            bool registrationSeccessful = Database.RegisterAssassin(username, passwordHash);

            if(registrationSeccessful)
            {
                MessageBox.Show("User Registered. Boueno Fortuna.");
                Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try agian");
            }
        }
    }
}
