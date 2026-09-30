namespace Projet1___VS
{
    partial class GestionClientEtInvite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientEtInvite));
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.inviteTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionClient = new System.Windows.Forms.Button();
            this.btnClientPrecedent = new System.Windows.Forms.Button();
            this.btnClientSuivant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.inviteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInviteSuivant = new System.Windows.Forms.Button();
            this.btnInvitePrecedent = new System.Windows.Forms.Button();
            this.btnGestionInvite = new System.Windows.Forms.Button();
            this.noInviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPrenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.InviteTableAdapter = this.inviteTableAdapter;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientBindingNavigatorSaveItem});
            this.clientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(1484, 42);
            this.clientBindingNavigator.TabIndex = 0;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            this.clientBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
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
            // clientBindingNavigatorSaveItem
            // 
            this.clientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientBindingNavigatorSaveItem.Image")));
            this.clientBindingNavigatorSaveItem.Name = "clientBindingNavigatorSaveItem";
            this.clientBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.clientBindingNavigatorSaveItem.Text = "Save Data";
            this.clientBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientBindingNavigatorSaveItem_Click);
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(27, 233);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.RowHeadersWidth = 40;
            this.clientDataGridView.RowTemplate.Height = 33;
            this.clientDataGridView.Size = new System.Drawing.Size(1386, 622);
            this.clientDataGridView.TabIndex = 1;
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "Invite";
            this.inviteBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 79);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clients et Invités";
            // 
            // btnGestionClient
            // 
            this.btnGestionClient.Location = new System.Drawing.Point(369, 865);
            this.btnGestionClient.Name = "btnGestionClient";
            this.btnGestionClient.Size = new System.Drawing.Size(702, 69);
            this.btnGestionClient.TabIndex = 6;
            this.btnGestionClient.Text = "Gestion du Client";
            this.btnGestionClient.UseVisualStyleBackColor = true;
            this.btnGestionClient.Click += new System.EventHandler(this.btnGestionClient_Click);
            // 
            // btnClientPrecedent
            // 
            this.btnClientPrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientPrecedent.Location = new System.Drawing.Point(27, 865);
            this.btnClientPrecedent.Name = "btnClientPrecedent";
            this.btnClientPrecedent.Size = new System.Drawing.Size(336, 69);
            this.btnClientPrecedent.TabIndex = 10;
            this.btnClientPrecedent.Text = "<--";
            this.btnClientPrecedent.UseVisualStyleBackColor = true;
            this.btnClientPrecedent.Click += new System.EventHandler(this.btnClientPrecedent_Click);
            // 
            // btnClientSuivant
            // 
            this.btnClientSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSuivant.Location = new System.Drawing.Point(1077, 865);
            this.btnClientSuivant.Name = "btnClientSuivant";
            this.btnClientSuivant.Size = new System.Drawing.Size(336, 69);
            this.btnClientSuivant.TabIndex = 11;
            this.btnClientSuivant.Text = "-->";
            this.btnClientSuivant.UseVisualStyleBackColor = true;
            this.btnClientSuivant.Click += new System.EventHandler(this.btnClientSuivant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 61);
            this.label2.TabIndex = 14;
            this.label2.Text = "Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1450, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 61);
            this.label3.TabIndex = 15;
            this.label3.Text = "Invités";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 965);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // inviteDataGridView
            // 
            this.inviteDataGridView.AutoGenerateColumns = false;
            this.inviteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inviteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inviteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noInviteDataGridViewTextBoxColumn,
            this.nomPrenomDataGridViewTextBoxColumn,
            this.noClientDataGridViewTextBoxColumn});
            this.inviteDataGridView.DataSource = this.inviteBindingSource;
            this.inviteDataGridView.Location = new System.Drawing.Point(1461, 233);
            this.inviteDataGridView.Name = "inviteDataGridView";
            this.inviteDataGridView.RowHeadersWidth = 30;
            this.inviteDataGridView.RowTemplate.Height = 33;
            this.inviteDataGridView.Size = new System.Drawing.Size(686, 622);
            this.inviteDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoClient";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ville";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pays";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pays";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CodePostal";
            this.dataGridViewTextBoxColumn7.HeaderText = "CodePostal";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateInscription";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateInscription";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnInviteSuivant
            // 
            this.btnInviteSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInviteSuivant.Location = new System.Drawing.Point(1931, 865);
            this.btnInviteSuivant.Name = "btnInviteSuivant";
            this.btnInviteSuivant.Size = new System.Drawing.Size(216, 69);
            this.btnInviteSuivant.TabIndex = 19;
            this.btnInviteSuivant.Text = "-->";
            this.btnInviteSuivant.UseVisualStyleBackColor = true;
            this.btnInviteSuivant.Click += new System.EventHandler(this.btnInviteSuivant_Click);
            // 
            // btnInvitePrecedent
            // 
            this.btnInvitePrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvitePrecedent.Location = new System.Drawing.Point(1461, 865);
            this.btnInvitePrecedent.Name = "btnInvitePrecedent";
            this.btnInvitePrecedent.Size = new System.Drawing.Size(216, 69);
            this.btnInvitePrecedent.TabIndex = 18;
            this.btnInvitePrecedent.Text = "<--";
            this.btnInvitePrecedent.UseVisualStyleBackColor = true;
            this.btnInvitePrecedent.Click += new System.EventHandler(this.btnInvitePrecedent_Click);
            // 
            // btnGestionInvite
            // 
            this.btnGestionInvite.Location = new System.Drawing.Point(1681, 865);
            this.btnGestionInvite.Name = "btnGestionInvite";
            this.btnGestionInvite.Size = new System.Drawing.Size(246, 69);
            this.btnGestionInvite.TabIndex = 17;
            this.btnGestionInvite.Text = "Gestion de l\'Invité";
            this.btnGestionInvite.UseVisualStyleBackColor = true;
            this.btnGestionInvite.Click += new System.EventHandler(this.btnGestionInvite_Click);
            // 
            // noInviteDataGridViewTextBoxColumn
            // 
            this.noInviteDataGridViewTextBoxColumn.DataPropertyName = "NoInvite";
            this.noInviteDataGridViewTextBoxColumn.HeaderText = "NoInvite";
            this.noInviteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.noInviteDataGridViewTextBoxColumn.Name = "noInviteDataGridViewTextBoxColumn";
            // 
            // nomPrenomDataGridViewTextBoxColumn
            // 
            this.nomPrenomDataGridViewTextBoxColumn.DataPropertyName = "NomPrenom";
            this.nomPrenomDataGridViewTextBoxColumn.HeaderText = "NomPrenom";
            this.nomPrenomDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nomPrenomDataGridViewTextBoxColumn.Name = "nomPrenomDataGridViewTextBoxColumn";
            // 
            // noClientDataGridViewTextBoxColumn
            // 
            this.noClientDataGridViewTextBoxColumn.DataPropertyName = "NoClient";
            this.noClientDataGridViewTextBoxColumn.HeaderText = "NoClient";
            this.noClientDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.noClientDataGridViewTextBoxColumn.Name = "noClientDataGridViewTextBoxColumn";
            // 
            // GestionClientEtInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2160, 965);
            this.Controls.Add(this.btnInviteSuivant);
            this.Controls.Add(this.btnInvitePrecedent);
            this.Controls.Add(this.btnGestionInvite);
            this.Controls.Add(this.inviteDataGridView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClientSuivant);
            this.Controls.Add(this.btnClientPrecedent);
            this.Controls.Add(this.btnGestionClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.clientBindingNavigator);
            this.Name = "GestionClientEtInvite";
            this.Text = "Gestion des client";
            this.Load += new System.EventHandler(this.GestionClientEtInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientBindingNavigatorSaveItem;
        private BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionClient;
        private System.Windows.Forms.Button btnClientPrecedent;
        private System.Windows.Forms.Button btnClientSuivant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView inviteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnInviteSuivant;
        private System.Windows.Forms.Button btnInvitePrecedent;
        private System.Windows.Forms.Button btnGestionInvite;
        private System.Windows.Forms.DataGridViewTextBoxColumn noInviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPrenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noClientDataGridViewTextBoxColumn;
    }
}