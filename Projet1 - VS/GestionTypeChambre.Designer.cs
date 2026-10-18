namespace Projet1___VS
{
    partial class GestionTypeChambre
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
            this.lblNoTypeChambre = new System.Windows.Forms.Label();
            this.txtNoTypeChambre = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrixHaut = new System.Windows.Forms.Label();
            this.txtPrixHaut = new System.Windows.Forms.TextBox();
            this.lblPrixBas = new System.Windows.Forms.Label();
            this.txtPrixBas = new System.Windows.Forms.TextBox();
            this.lblPrixMoyen = new System.Windows.Forms.Label();
            this.txtPrixMoyen = new System.Windows.Forms.TextBox();
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
            this.lblTitre.Text = "Type de chambre";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(200, 37);
            this.lblSousTitre.TabIndex = 0;
            this.lblSousTitre.Text = "La description du type doit être unique";
            // 
            // lblNoTypeChambre
            // 
            this.lblNoTypeChambre.AutoSize = true;
            this.lblNoTypeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTypeChambre.Location = new System.Drawing.Point(40, 185);
            this.lblNoTypeChambre.Name = "lblNoTypeChambre";
            this.lblNoTypeChambre.Size = new System.Drawing.Size(200, 37);
            this.lblNoTypeChambre.TabIndex = 0;
            this.lblNoTypeChambre.Text = "No type";
            // 
            // txtNoTypeChambre
            // 
            this.txtNoTypeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTypeChambre.Location = new System.Drawing.Point(380, 180);
            this.txtNoTypeChambre.Name = "txtNoTypeChambre";
            this.txtNoTypeChambre.ReadOnly = true;
            this.txtNoTypeChambre.Size = new System.Drawing.Size(540, 44);
            this.txtNoTypeChambre.TabIndex = 0;
            this.txtNoTypeChambre.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(40, 255);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(200, 37);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(380, 250);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(540, 44);
            this.txtDescription.TabIndex = 1;
            // 
            // lblPrixHaut
            // 
            this.lblPrixHaut.AutoSize = true;
            this.lblPrixHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixHaut.Location = new System.Drawing.Point(40, 325);
            this.lblPrixHaut.Name = "lblPrixHaut";
            this.lblPrixHaut.Size = new System.Drawing.Size(200, 37);
            this.lblPrixHaut.TabIndex = 0;
            this.lblPrixHaut.Text = "Prix saison haute";
            // 
            // txtPrixHaut
            // 
            this.txtPrixHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixHaut.Location = new System.Drawing.Point(380, 320);
            this.txtPrixHaut.Name = "txtPrixHaut";
            this.txtPrixHaut.Size = new System.Drawing.Size(540, 44);
            this.txtPrixHaut.TabIndex = 2;
            this.txtPrixHaut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixHaut.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrixHaut_Validating);
            // 
            // lblPrixBas
            // 
            this.lblPrixBas.AutoSize = true;
            this.lblPrixBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixBas.Location = new System.Drawing.Point(40, 395);
            this.lblPrixBas.Name = "lblPrixBas";
            this.lblPrixBas.Size = new System.Drawing.Size(200, 37);
            this.lblPrixBas.TabIndex = 0;
            this.lblPrixBas.Text = "Prix saison basse";
            // 
            // txtPrixBas
            // 
            this.txtPrixBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixBas.Location = new System.Drawing.Point(380, 390);
            this.txtPrixBas.Name = "txtPrixBas";
            this.txtPrixBas.Size = new System.Drawing.Size(540, 44);
            this.txtPrixBas.TabIndex = 3;
            this.txtPrixBas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixBas.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrixBas_Validating);
            // 
            // lblPrixMoyen
            // 
            this.lblPrixMoyen.AutoSize = true;
            this.lblPrixMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixMoyen.Location = new System.Drawing.Point(40, 465);
            this.lblPrixMoyen.Name = "lblPrixMoyen";
            this.lblPrixMoyen.Size = new System.Drawing.Size(200, 37);
            this.lblPrixMoyen.TabIndex = 0;
            this.lblPrixMoyen.Text = "Prix saison moyenne";
            // 
            // txtPrixMoyen
            // 
            this.txtPrixMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixMoyen.Location = new System.Drawing.Point(380, 460);
            this.txtPrixMoyen.Name = "txtPrixMoyen";
            this.txtPrixMoyen.Size = new System.Drawing.Size(540, 44);
            this.txtPrixMoyen.TabIndex = 4;
            this.txtPrixMoyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixMoyen.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrixMoyen_Validating);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(468, 570);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(218, 80);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(702, 570);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(218, 80);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // GestionTypeChambre
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(960, 690);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.lblNoTypeChambre);
            this.Controls.Add(this.txtNoTypeChambre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrixHaut);
            this.Controls.Add(this.txtPrixHaut);
            this.Controls.Add(this.lblPrixBas);
            this.Controls.Add(this.txtPrixBas);
            this.Controls.Add(this.lblPrixMoyen);
            this.Controls.Add(this.txtPrixMoyen);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "GestionTypeChambre";
            this.Text = "Type de chambre";
            this.Load += new System.EventHandler(this.GestionTypeChambre_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionTypeChambre_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblNoTypeChambre;
        private System.Windows.Forms.TextBox txtNoTypeChambre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrixHaut;
        private System.Windows.Forms.TextBox txtPrixHaut;
        private System.Windows.Forms.Label lblPrixBas;
        private System.Windows.Forms.TextBox txtPrixBas;
        private System.Windows.Forms.Label lblPrixMoyen;
        private System.Windows.Forms.TextBox txtPrixMoyen;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
