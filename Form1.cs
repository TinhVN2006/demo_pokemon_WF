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
    public partial class Sanh : Form
    {
        public Sanh()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Music.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            Play.MouseEnter += MouseEnter;
            Play.MouseLeave += MouseLeave;
            SelectPoke.MouseEnter += MouseEnter;
            SelectPoke.MouseLeave += MouseLeave;
            Exit.MouseEnter += MouseEnter1;
            Exit.MouseLeave += MouseLeave;
        }
        private void MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;        
            btn.ForeColor = Color.White;       
        }
        private void MouseEnter1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red;         
            btn.ForeColor = Color.White;       
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = SystemColors.ControlText;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Fight form2 = new Fight();
            form2.FormClosed += (s, args) => this.Show(); // Khi form2 đóng sẽ hiển thị lại form1
            form2.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
        }

        private void SelectPoke_Click(object sender, EventArgs e)
        {
            ChonPoke poke = new ChonPoke();
            poke.Show();
        }
    }
}
