
namespace FlapiBird
{
    partial class FlappyBird
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
            this.ScoreText = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bottonPipe = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottonPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreText.Location = new System.Drawing.Point(243, 594);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(122, 31);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score : 0";
            this.ScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // bird
            // 
            this.bird.Image = global::FlapiBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(199, 234);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(79, 58);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.Image = global::FlapiBird.Properties.Resources.pipedown;
            this.topPipe.Location = new System.Drawing.Point(525, -3);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(89, 200);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 2;
            this.topPipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlapiBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 571);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(663, 63);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // bottonPipe
            // 
            this.bottonPipe.Image = global::FlapiBird.Properties.Resources.pipe;
            this.bottonPipe.Location = new System.Drawing.Point(463, 375);
            this.bottonPipe.Name = "bottonPipe";
            this.bottonPipe.Size = new System.Drawing.Size(89, 200);
            this.bottonPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottonPipe.TabIndex = 0;
            this.bottonPipe.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(659, 625);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottonPipe);
            this.Name = "FlappyBird";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottonPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bottonPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

