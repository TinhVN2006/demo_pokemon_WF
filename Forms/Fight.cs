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
    public partial class Fight : Form
    {
        Random random = new Random(); // 🔹 Sinh số ngẫu nhiên cho phản công

        public Fight()
        {
            InitializeComponent();
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            // Nhạc nền
            axWindowsMediaPlayer1.URL = "Fight.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();

            // Cài đặt máu
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            progressBar1.Value = 10;

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10;
            progressBar2.Value = 10;

            // Gán sự kiện hover
            chieu1.MouseEnter += MouseEnter;
            chieu1.MouseLeave += MouseLeave;
            chieu2.MouseEnter += MouseEnter;
            chieu2.MouseLeave += MouseLeave;
        }


        private void MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = SystemColors.ControlText;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            using (Pen p = new Pen(Color.Red, 2))
            {
                SizeF strSize = e.Graphics.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(
                    box.ClientRectangle.X,
                    box.ClientRectangle.Y + (int)(strSize.Height / 2),
                    box.ClientRectangle.Width - 1,
                    box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                e.Graphics.DrawRectangle(p, rect);
                using (Brush b = new SolidBrush(box.ForeColor))
                {
                    e.Graphics.DrawString(box.Text, box.Font, b, 6, 0);
                }
            }
        }

        //  Hiệu ứng giảm máu dần dần
        private async Task AnimateHPDecrease(ProgressBar pb, int amount)
        {
            int target = Math.Max(pb.Minimum, pb.Value - amount);
            while (pb.Value > target)
            {
                pb.Value--;
                await Task.Delay(100); // giảm mỗi 0.1 giây
            }
        }

        // Hiệu ứng tăng máu
        private async Task AnimateHPIncrease(ProgressBar pb, int amount)
        {
            int target = Math.Min(pb.Maximum, pb.Value + amount);
            while (pb.Value < target)
            {
                pb.Value++;
                await Task.Delay(100);
            }
        }

        // Khi bạn dùng chiêu
        private async void chieu1_Click(object sender, EventArgs e)
        {
            await PlayerAttack(3); // gây 3 damage
        }

        private async void chieu2_Click(object sender, EventArgs e)
        {
            await PlayerAttack(1); // gây 1 damage
        }

        // Tấn công và phản công
        private async Task PlayerAttack(int damage)
        {
            chieu1.Enabled = false;
            chieu2.Enabled = false;

            //Bạn tấn công trước
            await AnimateHPDecrease(progressBar2, damage);
            if (progressBar2.Value == progressBar2.Minimum)
            {
                MessageBox.Show("🎉 Bạn đã chiến thắng!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                End e = new End();
                e.Show();
                this.Close();
            }

            // Đối thủ phản công ngẫu nhiên
            await Task.Delay(500);
            int enemyDamage = random.Next(1, 4); // từ 1–3
            await AnimateHPDecrease(progressBar1, enemyDamage);

            if (progressBar1.Value == progressBar1.Minimum)
            {
                MessageBox.Show("💀 Bạn đã thua!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                this.Close();
            }

            chieu1.Enabled = true;
            chieu2.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
    }
}
