namespace Atelier5
{
    partial class Menu
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
            this.Somme = new System.Windows.Forms.Button();
            this.Difference = new System.Windows.Forms.Button();
            this.Produit = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Somme
            // 
            this.Somme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somme.Location = new System.Drawing.Point(116, 49);
            this.Somme.Name = "Somme";
            this.Somme.Size = new System.Drawing.Size(165, 30);
            this.Somme.TabIndex = 0;
            this.Somme.Text = "Somme";
            this.Somme.UseVisualStyleBackColor = true;
            this.Somme.Click += new System.EventHandler(this.Somme_Click);
            // 
            // Difference
            // 
            this.Difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difference.Location = new System.Drawing.Point(116, 120);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(165, 30);
            this.Difference.TabIndex = 1;
            this.Difference.Text = "Difference";
            this.Difference.UseVisualStyleBackColor = true;
            this.Difference.Click += new System.EventHandler(this.Difference_Click_1);
            // 
            // Produit
            // 
            this.Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produit.Location = new System.Drawing.Point(116, 194);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(165, 35);
            this.Produit.TabIndex = 2;
            this.Produit.Text = "Produit";
            this.Produit.UseVisualStyleBackColor = true;
            this.Produit.Click += new System.EventHandler(this.Produit_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(116, 270);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(165, 30);
            this.Division.TabIndex = 3;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Quitter
            // 
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(116, 340);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(165, 30);
            this.Quitter.TabIndex = 4;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click_1);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(375, 422);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Produit);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Somme);
            this.Name = "Menu";
            this.Text = "Menu Choix";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button Somme;
      //  private System.Windows.Forms.Button Difference;
        
        private System.Windows.Forms.Button Somme;
        private System.Windows.Forms.Button Difference;
        private System.Windows.Forms.Button Produit;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Quitter;
    }
}

