namespace obligatoriskOppgaveDel1
{
    partial class Spillerregistering
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxPlayerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.sucsessMessageLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spiller";
            // 
            // textboxPlayerName
            // 
            this.textboxPlayerName.Location = new System.Drawing.Point(127, 66);
            this.textboxPlayerName.Name = "textboxPlayerName";
            this.textboxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.textboxPlayerName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrer Spiller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.registrerBrukerKnapp);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(150, 27);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(77, 18);
            this.errorMessageLabel.TabIndex = 4;
            this.errorMessageLabel.Text = "errorMsg";
            // 
            // sucsessMessageLabel
            // 
            this.sucsessMessageLabel.AutoSize = true;
            this.sucsessMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucsessMessageLabel.ForeColor = System.Drawing.Color.Green;
            this.sucsessMessageLabel.Location = new System.Drawing.Point(150, 9);
            this.sucsessMessageLabel.Name = "sucsessMessageLabel";
            this.sucsessMessageLabel.Size = new System.Drawing.Size(94, 18);
            this.sucsessMessageLabel.TabIndex = 5;
            this.sucsessMessageLabel.Text = "sucessMsg";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start Spillet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.startGameBtn);
            // 
            // Spillerregistering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sucsessMessageLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxPlayerName);
            this.Controls.Add(this.label1);
            this.Name = "Spillerregistering";
            this.Text = "Spillerregistering";
            this.Load += new System.EventHandler(this.playerInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxPlayerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label sucsessMessageLabel;
        private System.Windows.Forms.Button button2;
    }
}