namespace Calculette
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Racine = new System.Windows.Forms.RadioButton();
            this.soustrac = new System.Windows.Forms.RadioButton();
            this.Multip = new System.Windows.Forms.RadioButton();
            this.Divis = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(213, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(6, 31);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(44, 17);
            this.Add.TabIndex = 4;
            this.Add.TabStop = true;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Racine);
            this.groupBox1.Controls.Add(this.soustrac);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Multip);
            this.groupBox1.Controls.Add(this.Divis);
            this.groupBox1.Location = new System.Drawing.Point(357, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "option";
            // 
            // Racine
            // 
            this.Racine.AutoSize = true;
            this.Racine.Location = new System.Drawing.Point(6, 209);
            this.Racine.Name = "Racine";
            this.Racine.Size = new System.Drawing.Size(59, 17);
            this.Racine.TabIndex = 6;
            this.Racine.TabStop = true;
            this.Racine.Text = "Racine";
            this.Racine.UseVisualStyleBackColor = true;
            this.Racine.CheckedChanged += new System.EventHandler(this.Racine_CheckedChanged);
            // 
            // soustrac
            // 
            this.soustrac.AutoSize = true;
            this.soustrac.Location = new System.Drawing.Point(6, 73);
            this.soustrac.Name = "soustrac";
            this.soustrac.Size = new System.Drawing.Size(65, 17);
            this.soustrac.TabIndex = 6;
            this.soustrac.TabStop = true;
            this.soustrac.Text = "soustrac";
            this.soustrac.UseVisualStyleBackColor = true;
            this.soustrac.CheckedChanged += new System.EventHandler(this.soustrac_CheckedChanged);
            // 
            // Multip
            // 
            this.Multip.AutoSize = true;
            this.Multip.Location = new System.Drawing.Point(6, 123);
            this.Multip.Name = "Multip";
            this.Multip.Size = new System.Drawing.Size(53, 17);
            this.Multip.TabIndex = 7;
            this.Multip.TabStop = true;
            this.Multip.Text = "Multip";
            this.Multip.UseVisualStyleBackColor = true;
            this.Multip.CheckedChanged += new System.EventHandler(this.Multip_CheckedChanged);
            // 
            // Divis
            // 
            this.Divis.AutoSize = true;
            this.Divis.Location = new System.Drawing.Point(6, 166);
            this.Divis.Name = "Divis";
            this.Divis.Size = new System.Drawing.Size(48, 17);
            this.Divis.TabIndex = 8;
            this.Divis.TabStop = true;
            this.Divis.Text = "Divis";
            this.Divis.UseVisualStyleBackColor = true;
            this.Divis.CheckedChanged += new System.EventHandler(this.Divis_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "/";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(213, 149);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;

            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(213, 218);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Racine;
        private System.Windows.Forms.RadioButton soustrac;
        private System.Windows.Forms.RadioButton Multip;
        private System.Windows.Forms.RadioButton Divis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

