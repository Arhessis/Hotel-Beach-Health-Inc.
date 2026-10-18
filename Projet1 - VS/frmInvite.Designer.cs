namespace Projet1___VS
{
    partial class frmInvite
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
            this.components = new System.ComponentModel.Container();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblNoInvite = new System.Windows.Forms.Label();
            this.txtNoInvite = new System.Windows.Forms.TextBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblNoClient = new System.Windows.Forms.Label();
            this.txtNoClient = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(32, 14);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(200, 37);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Invité";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(200, 37);
            this.lblSousTitre.TabIndex = 0;
            this.lblSousTitre.Text = "Seul le nom est modifiable";
            // 
            // lblNoInvite
            // 
            this.lblNoInvite.AutoSize = true;
            this.lblNoInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoInvite.Location = new System.Drawing.Point(40, 185);
            this.lblNoInvite.Name = "lblNoInvite";
            this.lblNoInvite.Size = new System.Drawing.Size(200, 37);
            this.lblNoInvite.TabIndex = 0;
            this.lblNoInvite.Text = "No invité";
            // 
            // txtNoInvite
            // 
            this.txtNoInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoInvite.Location = new System.Drawing.Point(380, 180);
            this.txtNoInvite.Name = "txtNoInvite";
            this.txtNoInvite.ReadOnly = true;
            this.txtNoInvite.Size = new System.Drawing.Size(540, 44);
            this.txtNoInvite.TabIndex = 0;
            this.txtNoInvite.TabStop = false;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(40, 255);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(200, 37);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom et prénom";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPrenom.Location = new System.Drawing.Point(380, 250);
            this.txtNomPrenom.MaxLength = 50;
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(540, 44);
            this.txtNomPrenom.TabIndex = 1;
            // 
            // lblNoClient
            // 
            this.lblNoClient.AutoSize = true;
            this.lblNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoClient.Location = new System.Drawing.Point(40, 325);
            this.lblNoClient.Name = "lblNoClient";
            this.lblNoClient.Size = new System.Drawing.Size(200, 37);
            this.lblNoClient.TabIndex = 0;
            this.lblNoClient.Text = "No client";
            // 
            // txtNoClient
            // 
            this.txtNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoClient.Location = new System.Drawing.Point(380, 320);
            this.txtNoClient.Name = "txtNoClient";
            this.txtNoClient.ReadOnly = true;
            this.txtNoClient.Size = new System.Drawing.Size(540, 44);
            this.txtNoClient.TabIndex = 2;
            this.txtNoClient.TabStop = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(468, 430);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(218, 80);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(702, 430);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(218, 80);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmInvite
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.lblNoInvite);
            this.Controls.Add(this.txtNoInvite);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.lblNoClient);
            this.Controls.Add(this.txtNoClient);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "frmInvite";
            this.Text = "Invité";
            this.Load += new System.EventHandler(this.frmInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblNoInvite;
        private System.Windows.Forms.TextBox txtNoInvite;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblNoClient;
        private System.Windows.Forms.TextBox txtNoClient;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
