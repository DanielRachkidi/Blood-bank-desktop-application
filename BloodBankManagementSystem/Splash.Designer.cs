namespace BloodBankManagementSystem
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CircularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.Spl_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BLOOD BANK APPLICATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CircularProgressBar1
            // 
            this.CircularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("CircularProgressBar1.AnimationFunction")));
            this.CircularProgressBar1.AnimationSpeed = 500;
            this.CircularProgressBar1.BackColor = System.Drawing.Color.White;
            this.CircularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CircularProgressBar1.InnerColor = System.Drawing.Color.White;
            this.CircularProgressBar1.InnerMargin = 2;
            this.CircularProgressBar1.InnerWidth = -1;
            this.CircularProgressBar1.Location = new System.Drawing.Point(147, 66);
            this.CircularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.CircularProgressBar1.Name = "CircularProgressBar1";
            this.CircularProgressBar1.OuterColor = System.Drawing.Color.Silver;
            this.CircularProgressBar1.OuterMargin = -25;
            this.CircularProgressBar1.OuterWidth = 26;
            this.CircularProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.CircularProgressBar1.ProgressWidth = 15;
            this.CircularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CircularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CircularProgressBar1.Size = new System.Drawing.Size(163, 160);
            this.CircularProgressBar1.StartAngle = 0;
            this.CircularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CircularProgressBar1.SubscriptText = ".23";
            this.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CircularProgressBar1.SuperscriptText = "°C";
            this.CircularProgressBar1.TabIndex = 3;
            this.CircularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CircularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // Spl_Timer
            // 
            this.Spl_Timer.Enabled = true;
            this.Spl_Timer.Interval = 500;
            this.Spl_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CircularProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar CircularProgressBar1;
        private System.Windows.Forms.Timer Spl_Timer;
    }
}

