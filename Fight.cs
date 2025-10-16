using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokemonProject
{
    public partial class Fight : Form
    {
        private object progressBarHP1;

        public Fight()
        {
            InitializeComponent();
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Fight.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            progressBar1.Value = 10; // Bắt đầu với 100% máu
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10;
            progressBar2.Value = 10;
            chieu1.MouseEnter += MouseEnter;
            chieu1.MouseLeave += MouseLeave;
            chieu2.MouseEnter += MouseEnter;
            chieu2.MouseLeave += MouseLeave;
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = SystemColors.ControlText;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;

            // Vẽ lại viền
            using (Pen p = new Pen(Color.Red, 2)) // Chọn màu & độ dày viền
            {
                SizeF strSize = e.Graphics.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                e.Graphics.DrawRectangle(p, rect);

                // Vẽ lại chữ tiêu đề
                using (Brush b = new SolidBrush(box.ForeColor))
                {
                    e.Graphics.DrawString(box.Text, box.Font, b, 6, 0);
                }
            }
        }

        void DecreaseHP(System.Windows.Forms.ProgressBar pb, int amount)
        {
            pb.Value = Math.Max(pb.Minimum, pb.Value - amount);
        }

        void IncreaseHP(System.Windows.Forms.ProgressBar pb, int amount)
        {
            pb.Value = Math.Min(pb.Maximum, pb.Value + amount);
        }

        private void chieu1_Click(object sender, EventArgs e)
        {
            DecreaseHP(progressBar2, 3);
            if (progressBar2.Value == progressBar2.Minimum)
            {
                MessageBox.Show("Bạn đã chiến thắng!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chieu2_Click(object sender, EventArgs e)
        {
            DecreaseHP(progressBar2, 1);
            if (progressBar2.Value == progressBar2.Minimum)
            {
                MessageBox.Show("Bạn đã chiến thắng!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
