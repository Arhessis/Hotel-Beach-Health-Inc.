namespace Projet1___VS
{
    partial class AjouterSoinAssistant
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
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.cbSoin = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "Soin";
            this.soinBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // cbSoin
            // 
            this.cbSoin.DataSource = this.soinBindingSource;
            this.cbSoin.DisplayMember = "Description";
            this.cbSoin.FormattingEnabled = true;
            this.cbSoin.Location = new System.Drawing.Point(94, 129);
            this.cbSoin.Name = "cbSoin";
            this.cbSoin.Size = new System.Drawing.Size(300, 33);
            this.cbSoin.TabIndex = 1;
            this.cbSoin.ValueMember = "NoSoin";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(583, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(410, 214);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(203, 104);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // AjouterSoinAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbSoin);
            this.Name = "AjouterSoinAssistant";
            this.Text = "AjouterSoinAssistant";
            this.Load += new System.EventHandler(this.AjouterSoinAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbSoin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}