namespace MainProgram
{
    partial class frmRogzites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRogzites));
            this.lbTantargy = new System.Windows.Forms.Label();
            this.lbOktató = new System.Windows.Forms.Label();
            this.lbTanterem = new System.Windows.Forms.Label();
            this.lbTanoraHossza = new System.Windows.Forms.Label();
            this.lbTanoraKezdete = new System.Windows.Forms.Label();
            this.tbTantargy = new System.Windows.Forms.TextBox();
            this.tbTanteremNeve = new System.Windows.Forms.TextBox();
            this.tbOktatoNeve = new System.Windows.Forms.TextBox();
            this.dtpTanoraKezdete = new System.Windows.Forms.DateTimePicker();
            this.cnTanoraKezdete = new System.Windows.Forms.ComboBox();
            this.gbHazi = new System.Windows.Forms.GroupBox();
            this.lbHataridoNapja = new System.Windows.Forms.Label();
            this.lbLeiras = new System.Windows.Forms.Label();
            this.lbTipus = new System.Windows.Forms.Label();
            this.dtpHataridoHazi = new System.Windows.Forms.DateTimePicker();
            this.tbTipus = new System.Windows.Forms.TextBox();
            this.rtbLeiras = new System.Windows.Forms.RichTextBox();
            this.vsbLeiras = new System.Windows.Forms.VScrollBar();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            this.gbHazi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTantargy
            // 
            this.lbTantargy.AutoSize = true;
            this.lbTantargy.Location = new System.Drawing.Point(41, 47);
            this.lbTantargy.Name = "lbTantargy";
            this.lbTantargy.Size = new System.Drawing.Size(79, 13);
            this.lbTantargy.TabIndex = 0;
            this.lbTantargy.Text = "Tantárgy neve:";
            // 
            // lbOktató
            // 
            this.lbOktató.AutoSize = true;
            this.lbOktató.Location = new System.Drawing.Point(45, 83);
            this.lbOktató.Name = "lbOktató";
            this.lbOktató.Size = new System.Drawing.Size(75, 13);
            this.lbOktató.TabIndex = 1;
            this.lbOktató.Text = "Oktató neve : ";
            // 
            // lbTanterem
            // 
            this.lbTanterem.AutoSize = true;
            this.lbTanterem.Location = new System.Drawing.Point(39, 123);
            this.lbTanterem.Name = "lbTanterem";
            this.lbTanterem.Size = new System.Drawing.Size(85, 13);
            this.lbTanterem.TabIndex = 2;
            this.lbTanterem.Text = "Tanterem neve :";
            // 
            // lbTanoraHossza
            // 
            this.lbTanoraHossza.AutoSize = true;
            this.lbTanoraHossza.Location = new System.Drawing.Point(313, 83);
            this.lbTanoraHossza.Name = "lbTanoraHossza";
            this.lbTanoraHossza.Size = new System.Drawing.Size(88, 13);
            this.lbTanoraHossza.TabIndex = 3;
            this.lbTanoraHossza.Text = "Tanóra Hossza : ";
            // 
            // lbTanoraKezdete
            // 
            this.lbTanoraKezdete.AutoSize = true;
            this.lbTanoraKezdete.Location = new System.Drawing.Point(313, 47);
            this.lbTanoraKezdete.Name = "lbTanoraKezdete";
            this.lbTanoraKezdete.Size = new System.Drawing.Size(89, 13);
            this.lbTanoraKezdete.TabIndex = 4;
            this.lbTanoraKezdete.Text = "Tanóra Kezdete: ";
            // 
            // tbTantargy
            // 
            this.tbTantargy.Location = new System.Drawing.Point(131, 44);
            this.tbTantargy.Name = "tbTantargy";
            this.tbTantargy.Size = new System.Drawing.Size(142, 20);
            this.tbTantargy.TabIndex = 5;
            // 
            // tbTanteremNeve
            // 
            this.tbTanteremNeve.Location = new System.Drawing.Point(131, 123);
            this.tbTanteremNeve.Name = "tbTanteremNeve";
            this.tbTanteremNeve.Size = new System.Drawing.Size(142, 20);
            this.tbTanteremNeve.TabIndex = 6;
            // 
            // tbOktatoNeve
            // 
            this.tbOktatoNeve.Location = new System.Drawing.Point(131, 80);
            this.tbOktatoNeve.Name = "tbOktatoNeve";
            this.tbOktatoNeve.Size = new System.Drawing.Size(142, 20);
            this.tbOktatoNeve.TabIndex = 7;
            // 
            // dtpTanoraKezdete
            // 
            this.dtpTanoraKezdete.Location = new System.Drawing.Point(408, 44);
            this.dtpTanoraKezdete.Name = "dtpTanoraKezdete";
            this.dtpTanoraKezdete.Size = new System.Drawing.Size(200, 20);
            this.dtpTanoraKezdete.TabIndex = 8;
            // 
            // cnTanoraKezdete
            // 
            this.cnTanoraKezdete.FormattingEnabled = true;
            this.cnTanoraKezdete.Location = new System.Drawing.Point(408, 83);
            this.cnTanoraKezdete.Name = "cnTanoraKezdete";
            this.cnTanoraKezdete.Size = new System.Drawing.Size(127, 21);
            this.cnTanoraKezdete.TabIndex = 9;
            // 
            // gbHazi
            // 
            this.gbHazi.Controls.Add(this.vsbLeiras);
            this.gbHazi.Controls.Add(this.rtbLeiras);
            this.gbHazi.Controls.Add(this.tbTipus);
            this.gbHazi.Controls.Add(this.dtpHataridoHazi);
            this.gbHazi.Controls.Add(this.lbTipus);
            this.gbHazi.Controls.Add(this.lbLeiras);
            this.gbHazi.Controls.Add(this.lbHataridoNapja);
            this.gbHazi.Location = new System.Drawing.Point(12, 182);
            this.gbHazi.Name = "gbHazi";
            this.gbHazi.Size = new System.Drawing.Size(551, 211);
            this.gbHazi.TabIndex = 10;
            this.gbHazi.TabStop = false;
            this.gbHazi.Text = "Beadandó/Házi";
            // 
            // lbHataridoNapja
            // 
            this.lbHataridoNapja.AutoSize = true;
            this.lbHataridoNapja.Location = new System.Drawing.Point(33, 43);
            this.lbHataridoNapja.Name = "lbHataridoNapja";
            this.lbHataridoNapja.Size = new System.Drawing.Size(50, 13);
            this.lbHataridoNapja.TabIndex = 0;
            this.lbHataridoNapja.Text = "Határidő:";
            // 
            // lbLeiras
            // 
            this.lbLeiras.AutoSize = true;
            this.lbLeiras.Location = new System.Drawing.Point(311, 43);
            this.lbLeiras.Name = "lbLeiras";
            this.lbLeiras.Size = new System.Drawing.Size(40, 13);
            this.lbLeiras.TabIndex = 1;
            this.lbLeiras.Text = "Leírás:";
            // 
            // lbTipus
            // 
            this.lbTipus.AutoSize = true;
            this.lbTipus.Location = new System.Drawing.Point(33, 99);
            this.lbTipus.Name = "lbTipus";
            this.lbTipus.Size = new System.Drawing.Size(42, 13);
            this.lbTipus.TabIndex = 2;
            this.lbTipus.Text = "Tipusa:";
            // 
            // dtpHataridoHazi
            // 
            this.dtpHataridoHazi.Location = new System.Drawing.Point(89, 43);
            this.dtpHataridoHazi.Name = "dtpHataridoHazi";
            this.dtpHataridoHazi.Size = new System.Drawing.Size(200, 20);
            this.dtpHataridoHazi.TabIndex = 3;
            // 
            // tbTipus
            // 
            this.tbTipus.Location = new System.Drawing.Point(82, 99);
            this.tbTipus.Name = "tbTipus";
            this.tbTipus.Size = new System.Drawing.Size(145, 20);
            this.tbTipus.TabIndex = 4;
            // 
            // rtbLeiras
            // 
            this.rtbLeiras.Location = new System.Drawing.Point(358, 43);
            this.rtbLeiras.Name = "rtbLeiras";
            this.rtbLeiras.Size = new System.Drawing.Size(182, 93);
            this.rtbLeiras.TabIndex = 5;
            this.rtbLeiras.Text = "";
            // 
            // vsbLeiras
            // 
            this.vsbLeiras.Location = new System.Drawing.Point(518, 43);
            this.vsbLeiras.Name = "vsbLeiras";
            this.vsbLeiras.Size = new System.Drawing.Size(22, 93);
            this.vsbLeiras.TabIndex = 6;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(582, 206);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(98, 51);
            this.btnFelvitel.TabIndex = 11;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(582, 324);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(98, 42);
            this.btnVissza.TabIndex = 12;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // frmRogzites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(703, 415);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.gbHazi);
            this.Controls.Add(this.cnTanoraKezdete);
            this.Controls.Add(this.dtpTanoraKezdete);
            this.Controls.Add(this.tbOktatoNeve);
            this.Controls.Add(this.tbTanteremNeve);
            this.Controls.Add(this.tbTantargy);
            this.Controls.Add(this.lbTanoraKezdete);
            this.Controls.Add(this.lbTanoraHossza);
            this.Controls.Add(this.lbTanterem);
            this.Controls.Add(this.lbOktató);
            this.Controls.Add(this.lbTantargy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRogzites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adatok Felvitele";
            this.gbHazi.ResumeLayout(false);
            this.gbHazi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTantargy;
        private System.Windows.Forms.Label lbOktató;
        private System.Windows.Forms.Label lbTanterem;
        private System.Windows.Forms.Label lbTanoraHossza;
        private System.Windows.Forms.Label lbTanoraKezdete;
        private System.Windows.Forms.TextBox tbTantargy;
        private System.Windows.Forms.TextBox tbTanteremNeve;
        private System.Windows.Forms.TextBox tbOktatoNeve;
        private System.Windows.Forms.DateTimePicker dtpTanoraKezdete;
        private System.Windows.Forms.ComboBox cnTanoraKezdete;
        private System.Windows.Forms.GroupBox gbHazi;
        private System.Windows.Forms.VScrollBar vsbLeiras;
        private System.Windows.Forms.RichTextBox rtbLeiras;
        private System.Windows.Forms.TextBox tbTipus;
        private System.Windows.Forms.DateTimePicker dtpHataridoHazi;
        private System.Windows.Forms.Label lbTipus;
        private System.Windows.Forms.Label lbLeiras;
        private System.Windows.Forms.Label lbHataridoNapja;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.Button btnVissza;
    }
}