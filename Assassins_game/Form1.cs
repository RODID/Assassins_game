using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assassins_game
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text.Trim();
            string password = password_textbox.Text;

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM user_login WHERE username = @username AND password_hash = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if(count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            Assassin_Scandinavia AsSc= new Assassin_Scandinavia();
                            AsSc.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging in: " + ex.Message);

            }

        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            Assassin_Registration assassin_Registration = new Assassin_Registration();

            assassin_Registration.ShowDialog();
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
