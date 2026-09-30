namespace Projet1___VS
{
    partial class Connexion
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
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ConnexionMarche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(249, 122);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(100, 31);
            this.txtUtilisateur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(286, 210);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(100, 31);
            this.txtMotDePasse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnexionMarche
            // 
            this.ConnexionMarche.AutoSize = true;
            this.ConnexionMarche.Location = new System.Drawing.Point(154, 290);
            this.ConnexionMarche.Name = "ConnexionMarche";
            this.ConnexionMarche.Size = new System.Drawing.Size(0, 25);
            this.ConnexionMarche.TabIndex = 5;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnexionMarche);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUtilisateur);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ConnexionMarche;
    }
}