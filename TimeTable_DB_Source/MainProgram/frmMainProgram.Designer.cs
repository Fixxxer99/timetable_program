namespace MainProgram
{
    partial class frmMainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainProgram));
            this.TssmFajl = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importálásXmplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenuAdatfelvitel = new System.Windows.Forms.ToolStripMenuItem();
            this.adatokFelviteleMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLekerdezes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenuLekerdez = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmKapcsolat = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenuNevjegy = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFomenu = new System.Windows.Forms.MenuStrip();
            this.StripMenuFomenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TssmFajl
            // 
            this.TssmFajl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importálásXmplToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.TssmFajl.Name = "TssmFajl";
            this.TssmFajl.Size = new System.Drawing.Size(37, 20);
            this.TssmFajl.Text = "Fájl";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportToolStripMenuItem.Text = "Exportálás (Xml)";
            // 
            // importálásXmplToolStripMenuItem
            // 
            this.importálásXmplToolStripMenuItem.Name = "importálásXmplToolStripMenuItem";
            this.importálásXmplToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importálásXmplToolStripMenuItem.Text = "Importálás (Xml)";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // TsmMenuAdatfelvitel
            // 
            this.TsmMenuAdatfelvitel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatokFelviteleMódosításaToolStripMenuItem});
            this.TsmMenuAdatfelvitel.Name = "TsmMenuAdatfelvitel";
            this.TsmMenuAdatfelvitel.Size = new System.Drawing.Size(139, 20);
            this.TsmMenuAdatfelvitel.Text = "Adatfelvitel/Módosítás";
            // 
            // adatokFelviteleMódosításaToolStripMenuItem
            // 
            this.adatokFelviteleMódosításaToolStripMenuItem.Name = "adatokFelviteleMódosításaToolStripMenuItem";
            this.adatokFelviteleMódosításaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adatokFelviteleMódosításaToolStripMenuItem.Text = "Adatok felvitele";
            this.adatokFelviteleMódosításaToolStripMenuItem.Click += new System.EventHandler(this.adatokFelviteleMódosításaToolStripMenuItem_Click);
            // 
            // TsmLekerdezes
            // 
            this.TsmLekerdezes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenuLekerdez});
            this.TsmLekerdezes.Name = "TsmLekerdezes";
            this.TsmLekerdezes.Size = new System.Drawing.Size(76, 20);
            this.TsmLekerdezes.Text = "Lekérdezés";
            this.TsmLekerdezes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // TsmMenuLekerdez
            // 
            this.TsmMenuLekerdez.Name = "TsmMenuLekerdez";
            this.TsmMenuLekerdez.Size = new System.Drawing.Size(175, 22);
            this.TsmMenuLekerdez.Text = "Adatok lekérdezése";
            // 
            // TsmKapcsolat
            // 
            this.TsmKapcsolat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsmKapcsolat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenuNevjegy});
            this.TsmKapcsolat.Name = "TsmKapcsolat";
            this.TsmKapcsolat.Size = new System.Drawing.Size(70, 20);
            this.TsmKapcsolat.Text = "Kapcsolat";
            // 
            // TsmMenuNevjegy
            // 
            this.TsmMenuNevjegy.Image = ((System.Drawing.Image)(resources.GetObject("TsmMenuNevjegy.Image")));
            this.TsmMenuNevjegy.Name = "TsmMenuNevjegy";
            this.TsmMenuNevjegy.Size = new System.Drawing.Size(117, 22);
            this.TsmMenuNevjegy.Text = "Névjegy";
            this.TsmMenuNevjegy.Click += new System.EventHandler(this.TsmMenuNevjegy_Click);
            // 
            // StripMenuFomenu
            // 
            this.StripMenuFomenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssmFajl,
            this.TsmMenuAdatfelvitel,
            this.TsmLekerdezes,
            this.TsmKapcsolat});
            this.StripMenuFomenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenuFomenu.Name = "StripMenuFomenu";
            this.StripMenuFomenu.Size = new System.Drawing.Size(564, 24);
            this.StripMenuFomenu.TabIndex = 0;
            // 
            // frmMainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(564, 293);
            this.Controls.Add(this.StripMenuFomenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Órarend";
            this.StripMenuFomenu.ResumeLayout(false);
            this.StripMenuFomenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem TssmFajl;
        private System.Windows.Forms.ToolStripMenuItem TsmMenuAdatfelvitel;
        private System.Windows.Forms.ToolStripMenuItem adatokFelviteleMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmLekerdezes;
        private System.Windows.Forms.ToolStripMenuItem TsmMenuLekerdez;
        private System.Windows.Forms.ToolStripMenuItem TsmKapcsolat;
        private System.Windows.Forms.ToolStripMenuItem TsmMenuNevjegy;
        private System.Windows.Forms.MenuStrip StripMenuFomenu;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importálásXmplToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}

