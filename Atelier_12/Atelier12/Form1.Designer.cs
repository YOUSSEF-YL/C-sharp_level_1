namespace Atelier12
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stagiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesStagiairsParModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeTousLesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherToolStripMenuItem,
            this.stagiaToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficherToolStripMenuItem
            // 
            this.ficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.ficherToolStripMenuItem.Name = "ficherToolStripMenuItem";
            this.ficherToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ficherToolStripMenuItem.Text = "Ficher";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // stagiaToolStripMenuItem
            // 
            this.stagiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.consulterToolStripMenuItem});
            this.stagiaToolStripMenuItem.Name = "stagiaToolStripMenuItem";
            this.stagiaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.stagiaToolStripMenuItem.Text = "Stagiaires";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesStagiairesToolStripMenuItem,
            this.listeDesStagiairsParModuleToolStripMenuItem,
            this.listeTousLesStagiairesToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // listeDesStagiairesToolStripMenuItem
            // 
            this.listeDesStagiairesToolStripMenuItem.Name = "listeDesStagiairesToolStripMenuItem";
            this.listeDesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listeDesStagiairesToolStripMenuItem.Text = "Liste des Stagiaires";
            this.listeDesStagiairesToolStripMenuItem.Click += new System.EventHandler(this.listeDesStagiairesToolStripMenuItem_Click);
            // 
            // listeDesStagiairsParModuleToolStripMenuItem
            // 
            this.listeDesStagiairsParModuleToolStripMenuItem.Name = "listeDesStagiairsParModuleToolStripMenuItem";
            this.listeDesStagiairsParModuleToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listeDesStagiairsParModuleToolStripMenuItem.Text = "Liste des Stagiairs par Module";
            this.listeDesStagiairsParModuleToolStripMenuItem.Click += new System.EventHandler(this.listeDesStagiairsParModuleToolStripMenuItem_Click);
            // 
            // listeTousLesStagiairesToolStripMenuItem
            // 
            this.listeTousLesStagiairesToolStripMenuItem.Name = "listeTousLesStagiairesToolStripMenuItem";
            this.listeTousLesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listeTousLesStagiairesToolStripMenuItem.Text = "Liste Tous les Stagiaires";
            this.listeTousLesStagiairesToolStripMenuItem.Click += new System.EventHandler(this.listeTousLesStagiairesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 293);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stagiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesStagiairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesStagiairsParModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeTousLesStagiairesToolStripMenuItem;
    }
}

