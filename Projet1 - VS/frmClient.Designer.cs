namespace Projet1___VS
{
    partial class frmClient
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
            this.lblNoClient = new System.Windows.Forms.Label();
            this.txtNoClient = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblDateInscription = new System.Windows.Forms.Label();
            this.dtpDateInscription = new System.Windows.Forms.DateTimePicker();
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
            this.lblTitre.Text = "Client";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(200, 37);
            this.lblSousTitre.TabIndex = 0;
            this.lblSousTitre.Text = "Tous les champs sont obligatoires";
            // 
            // lblNoClient
            // 
            this.lblNoClient.AutoSize = true;
            this.lblNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoClient.Location = new System.Drawing.Point(40, 185);
            this.lblNoClient.Name = "lblNoClient";
            this.lblNoClient.Size = new System.Drawing.Size(200, 37);
            this.lblNoClient.TabIndex = 0;
            this.lblNoClient.Text = "No client";
            // 
            // txtNoClient
            // 
            this.txtNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoClient.Location = new System.Drawing.Point(380, 180);
            this.txtNoClient.Name = "txtNoClient";
            this.txtNoClient.ReadOnly = true;
            this.txtNoClient.Size = new System.Drawing.Size(540, 44);
            this.txtNoClient.TabIndex = 0;
            this.txtNoClient.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(40, 255);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(200, 37);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(380, 250);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(540, 44);
            this.txtNom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(40, 325);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(200, 37);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(380, 320);
            this.txtPrenom.MaxLength = 30;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(540, 44);
            this.txtPrenom.TabIndex = 2;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(40, 395);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(200, 37);
            this.lblVille.TabIndex = 0;
            this.lblVille.Text = "Ville";
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(380, 390);
            this.txtVille.MaxLength = 30;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(540, 44);
            this.txtVille.TabIndex = 3;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPays.Location = new System.Drawing.Point(40, 465);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(200, 37);
            this.lblPays.TabIndex = 0;
            this.lblPays.Text = "Pays";
            // 
            // txtPays
            // 
            this.txtPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPays.Location = new System.Drawing.Point(380, 460);
            this.txtPays.MaxLength = 30;
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(540, 44);
            this.txtPays.TabIndex = 4;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(40, 535);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(200, 37);
            this.lblAdresse.TabIndex = 0;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(380, 530);
            this.txtAdresse.MaxLength = 60;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(540, 44);
            this.txtAdresse.TabIndex = 5;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(40, 605);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(200, 37);
            this.lblCodePostal.TabIndex = 0;
            this.lblCodePostal.Text = "Code postal";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePostal.Location = new System.Drawing.Point(380, 600);
            this.txtCodePostal.MaxLength = 10;
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(540, 44);
            this.txtCodePostal.TabIndex = 6;
            // 
            // lblDateInscription
            // 
            this.lblDateInscription.AutoSize = true;
            this.lblDateInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInscription.Location = new System.Drawing.Point(40, 675);
            this.lblDateInscription.Name = "lblDateInscription";
            this.lblDateInscription.Size = new System.Drawing.Size(200, 37);
            this.lblDateInscription.TabIndex = 0;
            this.lblDateInscription.Text = "Date d\'inscription";
            // 
            // dtpDateInscription
            // 
            this.dtpDateInscription.Enabled = false;
            this.dtpDateInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateInscription.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateInscription.Location = new System.Drawing.Point(380, 670);
            this.dtpDateInscription.Name = "dtpDateInscription";
            this.dtpDateInscription.Size = new System.Drawing.Size(540, 44);
            this.dtpDateInscription.TabIndex = 7;
            this.dtpDateInscription.TabStop = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(468, 780);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(218, 80);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(702, 780);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(218, 80);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmClient
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(960, 900);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.lblNoClient);
            this.Controls.Add(this.txtNoClient);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.lblDateInscription);
            this.Controls.Add(this.dtpDateInscription);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblNoClient;
        private System.Windows.Forms.TextBox txtNoClient;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblDateInscription;
        private System.Windows.Forms.DateTimePicker dtpDateInscription;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
