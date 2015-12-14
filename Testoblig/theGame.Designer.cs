namespace battleShipWars
{
    partial class TheGame
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
            this.torpedoTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.highScore = new System.Windows.Forms.TextBox();
            this.exitGame = new System.Windows.Forms.Button();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // torpedoTimer
            // 
            this.torpedoTimer.Tick += new System.EventHandler(this.tmrMoving_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPlayerName.Location = new System.Drawing.Point(708, 97);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerName.TabIndex = 3;
            this.labelPlayerName.Text = "Spiller";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // highScore
            // 
            this.highScore.Location = new System.Drawing.Point(608, 309);
            this.highScore.Multiline = true;
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(169, 134);
            this.highScore.TabIndex = 4;
            this.highScore.Visible = false;
            // 
            // exitGame
            // 
            this.exitGame.Location = new System.Drawing.Point(638, 228);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(105, 23);
            this.exitGame.TabIndex = 5;
            this.exitGame.Text = "Avslutt spillet";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Visible = false;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.Location = new System.Drawing.Point(605, 280);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(55, 13);
            this.HighScoreLabel.TabIndex = 6;
            this.HighScoreLabel.Text = "Highscore";
            this.HighScoreLabel.Visible = false;
            this.HighScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 470);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.labelPlayerName);
            this.DoubleBuffered = true;
            this.Name = "TheGame";
            this.Text = "TheGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer torpedoTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer gameTimer;
        public System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox highScore;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Label HighScoreLabel;
    }
}

