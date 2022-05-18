namespace Pendu
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
            this.label1 = new System.Windows.Forms.Label();
            this.motChercher = new System.Windows.Forms.TextBox();
            this.validMotChercher = new System.Windows.Forms.Button();
            this.buttonLettreTester = new System.Windows.Forms.Button();
            this.lettreTester = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAffiche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cherche";
            // 
            // motChercher
            // 
            this.motChercher.Location = new System.Drawing.Point(74, 23);
            this.motChercher.Margin = new System.Windows.Forms.Padding(2);
            this.motChercher.Name = "motChercher";
            this.motChercher.Size = new System.Drawing.Size(76, 20);
            this.motChercher.TabIndex = 1;
            // 
            // validMotChercher
            // 
            this.validMotChercher.Location = new System.Drawing.Point(182, 23);
            this.validMotChercher.Margin = new System.Windows.Forms.Padding(2);
            this.validMotChercher.Name = "validMotChercher";
            this.validMotChercher.Size = new System.Drawing.Size(56, 19);
            this.validMotChercher.TabIndex = 2;
            this.validMotChercher.Text = "Valider";
            this.validMotChercher.UseVisualStyleBackColor = true;
            this.validMotChercher.Click += new System.EventHandler(this.validMotChercher_Click);
            // 
            // buttonLettreTester
            // 
            this.buttonLettreTester.Location = new System.Drawing.Point(182, 91);
            this.buttonLettreTester.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLettreTester.Name = "buttonLettreTester";
            this.buttonLettreTester.Size = new System.Drawing.Size(56, 19);
            this.buttonLettreTester.TabIndex = 5;
            this.buttonLettreTester.Text = "Tester";
            this.buttonLettreTester.UseVisualStyleBackColor = true;
            this.buttonLettreTester.Visible = false;
            this.buttonLettreTester.Click += new System.EventHandler(this.buttonLettreTester_Click);
            // 
            // lettreTester
            // 
            this.lettreTester.Location = new System.Drawing.Point(74, 91);
            this.lettreTester.Margin = new System.Windows.Forms.Padding(2);
            this.lettreTester.MaxLength = 1;
            this.lettreTester.Name = "lettreTester";
            this.lettreTester.Size = new System.Drawing.Size(76, 20);
            this.lettreTester.TabIndex = 4;
            this.lettreTester.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teste";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(286, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 298);
            this.panel1.TabIndex = 6;
            // 
            // textBoxAffiche
            // 
            this.textBoxAffiche.Enabled = false;
            this.textBoxAffiche.Location = new System.Drawing.Point(99, 139);
            this.textBoxAffiche.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAffiche.MaxLength = 1;
            this.textBoxAffiche.Name = "textBoxAffiche";
            this.textBoxAffiche.Size = new System.Drawing.Size(118, 20);
            this.textBoxAffiche.TabIndex = 8;
            this.textBoxAffiche.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mots à trouver:";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxAffiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLettreTester);
            this.Controls.Add(this.lettreTester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.validMotChercher);
            this.Controls.Add(this.motChercher);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox motChercher;
        private System.Windows.Forms.Button validMotChercher;
        private System.Windows.Forms.Button buttonLettreTester;
        private System.Windows.Forms.TextBox lettreTester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxAffiche;
        private System.Windows.Forms.Label label3;
    }
}

