namespace RussianRoulette
{
    partial class frmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblWinName = new System.Windows.Forms.Label();
            this.lblloseName = new System.Windows.Forms.Label();
            this.lblWinScore = new System.Windows.Forms.Label();
            this.lblLossScore = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RussianRoulette.Properties.Resources.gun;
            this.pictureBox1.Location = new System.Drawing.Point(60, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(60, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(153, 12);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(60, 193);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(303, 23);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblWinName
            // 
            this.lblWinName.AutoSize = true;
            this.lblWinName.Location = new System.Drawing.Point(60, 235);
            this.lblWinName.Name = "lblWinName";
            this.lblWinName.Size = new System.Drawing.Size(29, 13);
            this.lblWinName.TabIndex = 4;
            this.lblWinName.Text = "WIN";
            // 
            // lblloseName
            // 
            this.lblloseName.AutoSize = true;
            this.lblloseName.Location = new System.Drawing.Point(319, 236);
            this.lblloseName.Name = "lblloseName";
            this.lblloseName.Size = new System.Drawing.Size(30, 13);
            this.lblloseName.TabIndex = 5;
            this.lblloseName.Text = "Lose";
            // 
            // lblWinScore
            // 
            this.lblWinScore.AutoSize = true;
            this.lblWinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinScore.Location = new System.Drawing.Point(95, 234);
            this.lblWinScore.Name = "lblWinScore";
            this.lblWinScore.Size = new System.Drawing.Size(17, 17);
            this.lblWinScore.TabIndex = 6;
            this.lblWinScore.Text = "0";
            // 
            // lblLossScore
            // 
            this.lblLossScore.AutoSize = true;
            this.lblLossScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossScore.Location = new System.Drawing.Point(355, 235);
            this.lblLossScore.Name = "lblLossScore";
            this.lblLossScore.Size = new System.Drawing.Size(17, 17);
            this.lblLossScore.TabIndex = 7;
            this.lblLossScore.Text = "0";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(284, 12);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "PlayAgain";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.Location = new System.Drawing.Point(132, 232);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 17);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = ".";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(395, 260);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblLossScore);
            this.Controls.Add(this.lblWinScore);
            this.Controls.Add(this.lblloseName);
            this.Controls.Add(this.lblWinName);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Russian Roulette with a Gun";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblWinName;
        private System.Windows.Forms.Label lblloseName;
        private System.Windows.Forms.Label lblWinScore;
        private System.Windows.Forms.Label lblLossScore;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblMessage;
    }
}

