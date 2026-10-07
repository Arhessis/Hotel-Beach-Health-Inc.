namespace Projet1___VS
{
    partial class GestionChambreEtType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionChambreEtType));
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.typeChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter();
            this.chambreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chambreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChambreSuivant = new System.Windows.Forms.Button();
            this.btnChambrePrecedent = new System.Windows.Forms.Button();
            this.btnGestionChambres = new System.Windows.Forms.Button();
            this.btnTypeSuivant = new System.Windows.Forms.Button();
            this.btnTypePrecedent = new System.Windows.Forms.Button();
            this.btnTypesChambres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).BeginInit();
            this.chambreBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "Chambre";
            this.chambreBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // chambreBindingNavigator
            // 
            this.chambreBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.chambreBindingNavigator.BindingSource = this.chambreBindingSource;
            this.chambreBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.chambreBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.chambreBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.chambreBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.chambreBindingNavigatorSaveItem});
            this.chambreBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chambreBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.chambreBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.chambreBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.chambreBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.chambreBindingNavigator.Name = "chambreBindingNavigator";
            this.chambreBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.chambreBindingNavigator.Size = new System.Drawing.Size(1111, 50);
            this.chambreBindingNavigator.TabIndex = 0;
            this.chambreBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // chambreBindingNavigatorSaveItem
            // 
            this.chambreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chambreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chambreBindingNavigatorSaveItem.Image")));
            this.chambreBindingNavigatorSaveItem.Name = "chambreBindingNavigatorSaveItem";
            this.chambreBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.chambreBindingNavigatorSaveItem.Text = "Save Data";
            this.chambreBindingNavigatorSaveItem.Click += new System.EventHandler(this.chambreBindingNavigatorSaveItem_Click);
            // 
            // chambreDataGridView
            // 
            this.chambreDataGridView.AutoGenerateColumns = false;
            this.chambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.chambreDataGridView.DataSource = this.chambreBindingSource;
            this.chambreDataGridView.Location = new System.Drawing.Point(12, 193);
            this.chambreDataGridView.Name = "chambreDataGridView";
            this.chambreDataGridView.RowHeadersWidth = 82;
            this.chambreDataGridView.RowTemplate.Height = 33;
            this.chambreDataGridView.Size = new System.Drawing.Size(1084, 220);
            this.chambreDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoChambre";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoChambre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Emplacement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Decorations";
            this.dataGridViewTextBoxColumn3.HeaderText = "Decorations";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoTypeChambre";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoTypeChambre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "TypeChambre";
            this.typeChambreBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // typeChambreDataGridView
            // 
            this.typeChambreDataGridView.AutoGenerateColumns = false;
            this.typeChambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.typeChambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeChambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.typeChambreDataGridView.DataSource = this.typeChambreBindingSource;
            this.typeChambreDataGridView.Location = new System.Drawing.Point(12, 594);
            this.typeChambreDataGridView.Name = "typeChambreDataGridView";
            this.typeChambreDataGridView.RowHeadersWidth = 82;
            this.typeChambreDataGridView.RowTemplate.Height = 33;
            this.typeChambreDataGridView.Size = new System.Drawing.Size(1084, 220);
            this.typeChambreDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NoTypeChambre";
            this.dataGridViewTextBoxColumn5.HeaderText = "NoTypeChambre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PrixHaut";
            this.dataGridViewTextBoxColumn7.HeaderText = "PrixHaut";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PrixBas";
            this.dataGridViewTextBoxColumn8.HeaderText = "PrixBas";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PrixMoyen";
            this.dataGridViewTextBoxColumn9.HeaderText = "PrixMoyen";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // btnChambreSuivant
            // 
            this.btnChambreSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChambreSuivant.Location = new System.Drawing.Point(878, 419);
            this.btnChambreSuivant.Name = "btnChambreSuivant";
            this.btnChambreSuivant.Size = new System.Drawing.Size(218, 69);
            this.btnChambreSuivant.TabIndex = 59;
            this.btnChambreSuivant.Text = "-->";
            this.btnChambreSuivant.UseVisualStyleBackColor = true;
            this.btnChambreSuivant.Click += new System.EventHandler(this.btnChambreSuivant_Click);
            // 
            // btnChambrePrecedent
            // 
            this.btnChambrePrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChambrePrecedent.Location = new System.Drawing.Point(12, 419);
            this.btnChambrePrecedent.Name = "btnChambrePrecedent";
            this.btnChambrePrecedent.Size = new System.Drawing.Size(218, 69);
            this.btnChambrePrecedent.TabIndex = 58;
            this.btnChambrePrecedent.Text = "<--";
            this.btnChambrePrecedent.UseVisualStyleBackColor = true;
            this.btnChambrePrecedent.Click += new System.EventHandler(this.btnChambrePrecedent_Click);
            // 
            // btnGestionChambres
            // 
            this.btnGestionChambres.Location = new System.Drawing.Point(236, 419);
            this.btnGestionChambres.Name = "btnGestionChambres";
            this.btnGestionChambres.Size = new System.Drawing.Size(636, 69);
            this.btnGestionChambres.TabIndex = 57;
            this.btnGestionChambres.Text = "Gestion des chambres";
            this.btnGestionChambres.UseVisualStyleBackColor = true;
            this.btnGestionChambres.Click += new System.EventHandler(this.btnGestionChambres_Click);
            // 
            // btnTypeSuivant
            // 
            this.btnTypeSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeSuivant.Location = new System.Drawing.Point(878, 820);
            this.btnTypeSuivant.Name = "btnTypeSuivant";
            this.btnTypeSuivant.Size = new System.Drawing.Size(218, 69);
            this.btnTypeSuivant.TabIndex = 62;
            this.btnTypeSuivant.Text = "-->";
            this.btnTypeSuivant.UseVisualStyleBackColor = true;
            this.btnTypeSuivant.Click += new System.EventHandler(this.btnTypeSuivant_Click);
            // 
            // btnTypePrecedent
            // 
            this.btnTypePrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypePrecedent.Location = new System.Drawing.Point(12, 820);
            this.btnTypePrecedent.Name = "btnTypePrecedent";
            this.btnTypePrecedent.Size = new System.Drawing.Size(218, 69);
            this.btnTypePrecedent.TabIndex = 61;
            this.btnTypePrecedent.Text = "<--";
            this.btnTypePrecedent.UseVisualStyleBackColor = true;
            this.btnTypePrecedent.Click += new System.EventHandler(this.btnTypePrecedent_Click);
            // 
            // btnTypesChambres
            // 
            this.btnTypesChambres.Location = new System.Drawing.Point(236, 820);
            this.btnTypesChambres.Name = "btnTypesChambres";
            this.btnTypesChambres.Size = new System.Drawing.Size(636, 69);
            this.btnTypesChambres.TabIndex = 60;
            this.btnTypesChambres.Text = "Gestion de types des chambres";
            this.btnTypesChambres.UseVisualStyleBackColor = true;
            this.btnTypesChambres.Click += new System.EventHandler(this.btnTypesChambres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 67);
            this.label1.TabIndex = 63;
            this.label1.Text = "Gestion chambre et type de chambre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 61);
            this.label2.TabIndex = 64;
            this.label2.Text = "Chambres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 61);
            this.label3.TabIndex = 65;
            this.label3.Text = "Type de chambres";
            // 
            // GestionChambreEtType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 899);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTypeSuivant);
            this.Controls.Add(this.btnTypePrecedent);
            this.Controls.Add(this.btnTypesChambres);
            this.Controls.Add(this.btnChambreSuivant);
            this.Controls.Add(this.btnChambrePrecedent);
            this.Controls.Add(this.btnGestionChambres);
            this.Controls.Add(this.typeChambreDataGridView);
            this.Controls.Add(this.chambreDataGridView);
            this.Controls.Add(this.chambreBindingNavigator);
            this.Name = "GestionChambreEtType";
            this.Text = "GestionChambreEtTyp";
            this.Load += new System.EventHandler(this.GestionChambreEtType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).EndInit();
            this.chambreBindingNavigator.ResumeLayout(false);
            this.chambreBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator chambreBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton chambreBindingNavigatorSaveItem;
        private BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private System.Windows.Forms.DataGridView chambreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private System.Windows.Forms.DataGridView typeChambreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnChambreSuivant;
        private System.Windows.Forms.Button btnChambrePrecedent;
        private System.Windows.Forms.Button btnGestionChambres;
        private System.Windows.Forms.Button btnTypeSuivant;
        private System.Windows.Forms.Button btnTypePrecedent;
        private System.Windows.Forms.Button btnTypesChambres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}