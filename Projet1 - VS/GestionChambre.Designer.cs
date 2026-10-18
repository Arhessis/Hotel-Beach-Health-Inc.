namespace Projet1___VS
{
    partial class GestionChambre
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
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblNoChambre = new System.Windows.Forms.Label();
            this.txtNoChambre = new System.Windows.Forms.TextBox();
            this.lblEmplacement = new System.Windows.Forms.Label();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.lblDecorations = new System.Windows.Forms.Label();
            this.txtDecorations = new System.Windows.Forms.TextBox();
            this.lblTypeChambre = new System.Windows.Forms.Label();
            this.cboTypeChambre = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "TypeChambre";
            this.typeChambreBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
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
            this.lblTitre.Text = "Chambre";
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
            // lblNoChambre
            // 
            this.lblNoChambre.AutoSize = true;
            this.lblNoChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChambre.Location = new System.Drawing.Point(40, 185);
            this.lblNoChambre.Name = "lblNoChambre";
            this.lblNoChambre.Size = new System.Drawing.Size(200, 37);
            this.lblNoChambre.TabIndex = 0;
            this.lblNoChambre.Text = "No chambre";
            // 
            // txtNoChambre
            // 
            this.txtNoChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoChambre.Location = new System.Drawing.Point(380, 180);
            this.txtNoChambre.Name = "txtNoChambre";
            this.txtNoChambre.ReadOnly = true;
            this.txtNoChambre.Size = new System.Drawing.Size(540, 44);
            this.txtNoChambre.TabIndex = 0;
            this.txtNoChambre.TabStop = false;
            // 
            // lblEmplacement
            // 
            this.lblEmplacement.AutoSize = true;
            this.lblEmplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplacement.Location = new System.Drawing.Point(40, 255);
            this.lblEmplacement.Name = "lblEmplacement";
            this.lblEmplacement.Size = new System.Drawing.Size(200, 37);
            this.lblEmplacement.TabIndex = 0;
            this.lblEmplacement.Text = "Emplacement";
            // 
            // txtEmplacement
            // 
            this.txtEmplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmplacement.Location = new System.Drawing.Point(380, 250);
            this.txtEmplacement.MaxLength = 30;
            this.txtEmplacement.Name = "txtEmplacement";
            this.txtEmplacement.Size = new System.Drawing.Size(540, 44);
            this.txtEmplacement.TabIndex = 1;
            // 
            // lblDecorations
            // 
            this.lblDecorations.AutoSize = true;
            this.lblDecorations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecorations.Location = new System.Drawing.Point(40, 325);
            this.lblDecorations.Name = "lblDecorations";
            this.lblDecorations.Size = new System.Drawing.Size(200, 37);
            this.lblDecorations.TabIndex = 0;
            this.lblDecorations.Text = "Décorations";
            // 
            // txtDecorations
            // 
            this.txtDecorations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecorations.Location = new System.Drawing.Point(380, 320);
            this.txtDecorations.MaxLength = 50;
            this.txtDecorations.Name = "txtDecorations";
            this.txtDecorations.Size = new System.Drawing.Size(540, 44);
            this.txtDecorations.TabIndex = 2;
            // 
            // lblTypeChambre
            // 
            this.lblTypeChambre.AutoSize = true;
            this.lblTypeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeChambre.Location = new System.Drawing.Point(40, 395);
            this.lblTypeChambre.Name = "lblTypeChambre";
            this.lblTypeChambre.Size = new System.Drawing.Size(200, 37);
            this.lblTypeChambre.TabIndex = 0;
            this.lblTypeChambre.Text = "Type de chambre";
            // 
            // cboTypeChambre
            // 
            this.cboTypeChambre.DataSource = this.typeChambreBindingSource;
            this.cboTypeChambre.DisplayMember = "Description";
            this.cboTypeChambre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeChambre.FormattingEnabled = true;
            this.cboTypeChambre.Location = new System.Drawing.Point(380, 390);
            this.cboTypeChambre.Name = "cboTypeChambre";
            this.cboTypeChambre.Size = new System.Drawing.Size(540, 45);
            this.cboTypeChambre.TabIndex = 3;
            this.cboTypeChambre.ValueMember = "NoTypeChambre";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(468, 500);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(218, 80);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(702, 500);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(218, 80);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // GestionChambre
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.lblNoChambre);
            this.Controls.Add(this.txtNoChambre);
            this.Controls.Add(this.lblEmplacement);
            this.Controls.Add(this.txtEmplacement);
            this.Controls.Add(this.lblDecorations);
            this.Controls.Add(this.txtDecorations);
            this.Controls.Add(this.lblTypeChambre);
            this.Controls.Add(this.cboTypeChambre);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "GestionChambre";
            this.Text = "Chambre";
            this.Load += new System.EventHandler(this.GestionChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblNoChambre;
        private System.Windows.Forms.TextBox txtNoChambre;
        private System.Windows.Forms.Label lblEmplacement;
        private System.Windows.Forms.TextBox txtEmplacement;
        private System.Windows.Forms.Label lblDecorations;
        private System.Windows.Forms.TextBox txtDecorations;
        private System.Windows.Forms.Label lblTypeChambre;
        private System.Windows.Forms.ComboBox cboTypeChambre;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
