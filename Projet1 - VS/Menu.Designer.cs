namespace Projet1___VS
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projet1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAssistantEtSoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionChambreEtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientEtInvitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificationDesSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projet1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projet1ToolStripMenuItem
            // 
            this.projet1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionAssistantEtSoinToolStripMenuItem,
            this.gestionChambreEtTypeToolStripMenuItem,
            this.gestionClientEtInvitéToolStripMenuItem,
            this.gestionSoinToolStripMenuItem,
            this.gestionUtilisateursToolStripMenuItem,
            this.planificationDesSoinsToolStripMenuItem});
            this.projet1ToolStripMenuItem.Name = "projet1ToolStripMenuItem";
            this.projet1ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.projet1ToolStripMenuItem.Text = "Projet 1";
            // 
            // gestionAssistantEtSoinToolStripMenuItem
            // 
            this.gestionAssistantEtSoinToolStripMenuItem.Name = "gestionAssistantEtSoinToolStripMenuItem";
            this.gestionAssistantEtSoinToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.gestionAssistantEtSoinToolStripMenuItem.Text = "Gestion: Assistant et soin";
            this.gestionAssistantEtSoinToolStripMenuItem.Click += new System.EventHandler(this.gestionAssistantEtSoinToolStripMenuItem_Click);
            // 
            // gestionChambreEtTypeToolStripMenuItem
            // 
            this.gestionChambreEtTypeToolStripMenuItem.Name = "gestionChambreEtTypeToolStripMenuItem";
            this.gestionChambreEtTypeToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.gestionChambreEtTypeToolStripMenuItem.Text = "Gestion: Chambre et type";
            this.gestionChambreEtTypeToolStripMenuItem.Click += new System.EventHandler(this.gestionChambreEtTypeToolStripMenuItem_Click);
            // 
            // gestionClientEtInvitéToolStripMenuItem
            // 
            this.gestionClientEtInvitéToolStripMenuItem.Name = "gestionClientEtInvitéToolStripMenuItem";
            this.gestionClientEtInvitéToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.gestionClientEtInvitéToolStripMenuItem.Text = "Gestion: Client et invité";
            this.gestionClientEtInvitéToolStripMenuItem.Click += new System.EventHandler(this.gestionClientEtInvitéToolStripMenuItem_Click);
            // 
            // gestionSoinToolStripMenuItem
            // 
            this.gestionSoinToolStripMenuItem.Name = "gestionSoinToolStripMenuItem";
            this.gestionSoinToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.gestionSoinToolStripMenuItem.Text = "Gestion: Soin";
            this.gestionSoinToolStripMenuItem.Click += new System.EventHandler(this.gestionSoinToolStripMenuItem_Click);
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion: Utilisateurs";
            this.gestionUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionUtilisateursToolStripMenuItem_Click);
            // 
            // planificationDesSoinsToolStripMenuItem
            // 
            this.planificationDesSoinsToolStripMenuItem.Name = "planificationDesSoinsToolStripMenuItem";
            this.planificationDesSoinsToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.planificationDesSoinsToolStripMenuItem.Text = "Planification des soins";
            this.planificationDesSoinsToolStripMenuItem.Click += new System.EventHandler(this.planificationDesSoinsToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projet1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAssistantEtSoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionChambreEtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientEtInvitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificationDesSoinsToolStripMenuItem;
    }
}

