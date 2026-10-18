namespace Projet1___VS
{
    partial class AjouterAssist
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarques = new System.Windows.Forms.TextBox();
            this.txtSpecialites = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNoAssistant = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoAssistant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remarques :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specialites :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prenom :";
            // 
            // txtRemarques
            // 
            this.txtRemarques.Location = new System.Drawing.Point(226, 370);
            this.txtRemarques.Name = "txtRemarques";
            this.txtRemarques.Size = new System.Drawing.Size(100, 31);
            this.txtRemarques.TabIndex = 5;
            // 
            // txtSpecialites
            // 
            this.txtSpecialites.Location = new System.Drawing.Point(226, 297);
            this.txtSpecialites.Name = "txtSpecialites";
            this.txtSpecialites.Size = new System.Drawing.Size(100, 31);
            this.txtSpecialites.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(226, 207);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 31);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(226, 129);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 31);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtNoAssistant
            // 
            this.txtNoAssistant.Location = new System.Drawing.Point(226, 44);
            this.txtNoAssistant.Name = "txtNoAssistant";
            this.txtNoAssistant.Size = new System.Drawing.Size(100, 31);
            this.txtNoAssistant.TabIndex = 9;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(397, 257);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(332, 181);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(397, 44);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(332, 181);
            this.btnConfirmer.TabIndex = 11;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // AjouterAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.txtNoAssistant);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtSpecialites);
            this.Controls.Add(this.txtRemarques);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjouterAssist";
            this.Text = "AjouterAssist";
            this.Load += new System.EventHandler(this.AjouterAssist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarques;
        private System.Windows.Forms.TextBox txtSpecialites;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNoAssistant;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnConfirmer;
    }
}