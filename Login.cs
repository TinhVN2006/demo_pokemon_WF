using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonProject
{
    public partial class Login : Form
    {
        Panel panelDangKy = new Panel();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sanh sanh = new Sanh();
            sanh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dangky signin = new Dangky();
            signin.Show();
            this.Hide();

        }
    }
}