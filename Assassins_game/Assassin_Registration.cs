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
using MySql.Data.MySqlClient;

namespace Assassins_game
{
    public partial class Assassin_Registration : Form
    {
        DB db = new DB();
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

        

        private void InsertUser(string username, string hashPassword)
        {
            try
            {
                using(MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = " INSERT INTO user_login (username, password_hash) VALUES (@username,@password)";

                    using (MySqlCommand command = new MySqlCommand(query, connection)) 
                    {
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("@password", hashPassword);

                        int rowsAffected = command.ExecuteNonQuery();

                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("User inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error inserting user.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user: " + ex.Message);
            }
        }

        

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = register_username_txtbox.Text.Trim();
            string email = register_email_txtbox.Text.Trim();
            string password1 = register_password_txtbox1.Text;
            string password2 = register_password_txtbox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            if (password1 != password2)
            {
                MessageBox.Show("Password do not match");
                return;
            }

            InsertUser(username, password1);


        }

        
    }
}
