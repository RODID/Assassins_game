using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assassins_game
{
    public partial class Assassin_Registration : Form
    {
        public Assassin_Registration()
        {
            InitializeComponent();
        }

        private void register_clear__Click(object sender, EventArgs e)
        {
            register_username_txtbox.Text = "";
            register_email_txtbox.Text = "";
            register_password_txtbox1.Text = "";
            register_password_txtbox2.Text = "";
        }
    }
}
