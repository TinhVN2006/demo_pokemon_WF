namespace PokemonProject
{
    partial class Sanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanh));
            this.Play = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SelectPoke = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(410, 282);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(159, 63);
            this.Play.TabIndex = 0;
            this.Play.Text = "Chơi Ngay";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(410, 511);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(159, 63);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SelectPoke
            // 
            this.SelectPoke.Location = new System.Drawing.Point(410, 389);
            this.SelectPoke.Name = "SelectPoke";
            this.SelectPoke.Size = new System.Drawing.Size(159, 63);
            this.SelectPoke.TabIndex = 2;
            this.SelectPoke.Text = "Chọn Pokemon";
            this.SelectPoke.UseVisualStyleBackColor = true;
            this.SelectPoke.Click += new System.EventHandler(this.SelectPoke_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-1, -3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(228, 34);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // Sanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonProject.Properties.Resources.R1;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.SelectPoke);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Play);
            this.Name = "Sanh";
            this.Text = "Sanh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SelectPoke;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;

    }
}

