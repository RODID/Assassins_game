using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

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
            string adminUsername = "Master";
            string adminPassword = "Assassin";

            if (username_textbox.Text == adminUsername && password_textbox.Text != adminPassword)
            {
                MessageBox.Show("Wrong password, try another time!");
            }

            else if (username_textbox.Text == adminUsername && password_textbox.Text == adminPassword)
            {
                MessageBox.Show("Welcome Back, Master Assassin.");

                Assassin_Scandinavia assassin_Scandinavia = new Assassin_Scandinavia();
                assassin_Scandinavia.ShowDialog();

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
