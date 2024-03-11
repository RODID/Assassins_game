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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            string PasswordHash = HashPassword(password);

            bool isAuthenticated = Database.AuthenticateUser(username, passwordHash);

            if (isAuthenticated)
            {
                MessageBox.Show("Welcome Grand Master!");
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again");
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
