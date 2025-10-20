using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonProject.Forms
{
    public partial class Manchoi : Form
    {
        public Manchoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChonPoke poke = new ChonPoke();
            poke.Show();
            this.Enabled = false;
            poke.FormClosed += (s, args) =>
            {
                this.Enabled = true; // Mở lại nút
            };
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChonPoke poke = new ChonPoke();
            poke.Show();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChonPoke poke = new ChonPoke();
            poke.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChonPoke poke = new ChonPoke();
            poke.Show();
        }
    }
}
