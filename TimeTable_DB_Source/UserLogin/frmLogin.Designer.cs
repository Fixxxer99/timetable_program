﻿namespace UserLogin
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbuserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEntrance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBox
            // 
            this.pbBox.Image = ((System.Drawing.Image)(resources.GetObject("pbBox.Image")));
            this.pbBox.Location = new System.Drawing.Point(30, 45);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(132, 137);
            this.pbBox.TabIndex = 0;
            this.pbBox.TabStop = false;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLogin.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbLogin.Location = new System.Drawing.Point(303, 31);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(122, 20);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Bejelentkezés";
            // 
            // lbuserName
            // 
            this.lbuserName.AutoSize = true;
            this.lbuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbuserName.Location = new System.Drawing.Point(206, 77);
            this.lbuserName.Name = "lbuserName";
            this.lbuserName.Size = new System.Drawing.Size(129, 16);
            this.lbuserName.TabIndex = 2;
            this.lbuserName.Text = "Felhasználónév : ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPassword.Location = new System.Drawing.Point(206, 140);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 16);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Jelszó :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnEntrance
            // 
            this.btnEntrance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEntrance.ForeColor = System.Drawing.Color.Honeydew;
            this.btnEntrance.Location = new System.Drawing.Point(391, 177);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(92, 41);
            this.btnEntrance.TabIndex = 6;
            this.btnEntrance.Text = "Belépés";
            this.btnEntrance.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(560, 289);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbuserName);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.pbBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbuserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnEntrance;
    }
}
