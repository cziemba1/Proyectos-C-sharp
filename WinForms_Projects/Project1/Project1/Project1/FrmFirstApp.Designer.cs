namespace Project1
{
    partial class FrmFirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btbWelcome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.boxGroupMood = new System.Windows.Forms.GroupBox();
            this.btnRadioSad = new System.Windows.Forms.RadioButton();
            this.btnRadioHappy = new System.Windows.Forms.RadioButton();
            this.imgHappy = new System.Windows.Forms.PictureBox();
            this.imgSad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.boxGroupMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(146, 81);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to my program";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(64, 133);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(327, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "default";
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(455, 8);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(333, 430);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 2;
            this.picTitle.TabStop = false;
            // 
            // btbWelcome
            // 
            this.btbWelcome.Location = new System.Drawing.Point(78, 184);
            this.btbWelcome.Name = "btbWelcome";
            this.btbWelcome.Size = new System.Drawing.Size(140, 33);
            this.btbWelcome.TabIndex = 3;
            this.btbWelcome.Text = "Welcome";
            this.btbWelcome.UseVisualStyleBackColor = true;
            this.btbWelcome.Click += new System.EventHandler(this.btbWelcome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(245, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // boxGroupMood
            // 
            this.boxGroupMood.Controls.Add(this.btnRadioHappy);
            this.boxGroupMood.Controls.Add(this.btnRadioSad);
            this.boxGroupMood.Location = new System.Drawing.Point(18, 239);
            this.boxGroupMood.Name = "boxGroupMood";
            this.boxGroupMood.Size = new System.Drawing.Size(200, 100);
            this.boxGroupMood.TabIndex = 5;
            this.boxGroupMood.TabStop = false;
            this.boxGroupMood.Text = "Moods";
            // 
            // btnRadioSad
            // 
            this.btnRadioSad.AutoSize = true;
            this.btnRadioSad.Location = new System.Drawing.Point(13, 21);
            this.btnRadioSad.Name = "btnRadioSad";
            this.btnRadioSad.Size = new System.Drawing.Size(54, 21);
            this.btnRadioSad.TabIndex = 6;
            this.btnRadioSad.TabStop = true;
            this.btnRadioSad.Text = "Sad";
            this.btnRadioSad.UseVisualStyleBackColor = true;
            this.btnRadioSad.CheckedChanged += new System.EventHandler(this.btnRadioSad_CheckedChanged);
            // 
            // btnRadioHappy
            // 
            this.btnRadioHappy.AutoSize = true;
            this.btnRadioHappy.Location = new System.Drawing.Point(13, 49);
            this.btnRadioHappy.Name = "btnRadioHappy";
            this.btnRadioHappy.Size = new System.Drawing.Size(70, 21);
            this.btnRadioHappy.TabIndex = 7;
            this.btnRadioHappy.TabStop = true;
            this.btnRadioHappy.Text = "Happy";
            this.btnRadioHappy.UseVisualStyleBackColor = true;
            this.btnRadioHappy.CheckedChanged += new System.EventHandler(this.btnRadioHappy_CheckedChanged);
            // 
            // imgHappy
            // 
            this.imgHappy.Image = ((System.Drawing.Image)(resources.GetObject("imgHappy.Image")));
            this.imgHappy.Location = new System.Drawing.Point(228, 239);
            this.imgHappy.Name = "imgHappy";
            this.imgHappy.Size = new System.Drawing.Size(100, 166);
            this.imgHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHappy.TabIndex = 8;
            this.imgHappy.TabStop = false;
            // 
            // imgSad
            // 
            this.imgSad.Image = ((System.Drawing.Image)(resources.GetObject("imgSad.Image")));
            this.imgSad.Location = new System.Drawing.Point(349, 239);
            this.imgSad.Name = "imgSad";
            this.imgSad.Size = new System.Drawing.Size(100, 166);
            this.imgSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSad.TabIndex = 9;
            this.imgSad.TabStop = false;
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgSad);
            this.Controls.Add(this.imgHappy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.boxGroupMood);
            this.Controls.Add(this.btbWelcome);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmFirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstProject";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.boxGroupMood.ResumeLayout(false);
            this.boxGroupMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button btbWelcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox boxGroupMood;
        private System.Windows.Forms.RadioButton btnRadioHappy;
        private System.Windows.Forms.RadioButton btnRadioSad;
        private System.Windows.Forms.PictureBox imgHappy;
        private System.Windows.Forms.PictureBox imgSad;
    }
}

