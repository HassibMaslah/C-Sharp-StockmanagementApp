namespace WindowsFormsApplicationBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.listClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFornisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rechercherUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créeUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créeUneFactureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.afficherUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.créeUneFactureToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem,
            this.toolStripSeparator3,
            this.listClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Icons_Land_Vista_People_Office_Client_Male_Light;
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter Client";
            this.ajouterClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterClientToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // listClientToolStripMenuItem
            // 
            this.listClientToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Icons_Land_Vista_People_Office_Client_Male_Light;
            this.listClientToolStripMenuItem.Name = "listClientToolStripMenuItem";
            this.listClientToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.listClientToolStripMenuItem.Text = "Liste des Clients";
            this.listClientToolStripMenuItem.Click += new System.EventHandler(this.listClientToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFornisseurToolStripMenuItem,
            this.toolStripSeparator2,
            this.listeDesFournisseurToolStripMenuItem});
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            // 
            // ajouterUnFornisseurToolStripMenuItem
            // 
            this.ajouterUnFornisseurToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Icons_Land_Transport_Lorry;
            this.ajouterUnFornisseurToolStripMenuItem.Name = "ajouterUnFornisseurToolStripMenuItem";
            this.ajouterUnFornisseurToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ajouterUnFornisseurToolStripMenuItem.Text = "Ajouter un Fournisseur";
            this.ajouterUnFornisseurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnFornisseurToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // listeDesFournisseurToolStripMenuItem
            // 
            this.listeDesFournisseurToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Icons_Land_Transport_Lorry;
            this.listeDesFournisseurToolStripMenuItem.Name = "listeDesFournisseurToolStripMenuItem";
            this.listeDesFournisseurToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listeDesFournisseurToolStripMenuItem.Text = "Liste des Fournisseurs";
            this.listeDesFournisseurToolStripMenuItem.Click += new System.EventHandler(this.listeDesFournisseurToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterProduitToolStripMenuItem,
            this.listeDesProduitsToolStripMenuItem,
            this.toolStripSeparator1,
            this.rechercherUnProduitToolStripMenuItem});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Untergunter_Leaf_Mimes_Package_x_generic;
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterProduitToolStripMenuItem.Text = "Ajouter Produit";
            this.ajouterProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterProduitToolStripMenuItem_Click);
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            this.listeDesProduitsToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Untergunter_Leaf_Mimes_Package_x_generic;
            this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            this.listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listeDesProduitsToolStripMenuItem.Text = "Liste des Produits";
            this.listeDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.listeDesProduitsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // rechercherUnProduitToolStripMenuItem
            // 
            this.rechercherUnProduitToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Babasse_Old_School_Recherche;
            this.rechercherUnProduitToolStripMenuItem.Name = "rechercherUnProduitToolStripMenuItem";
            this.rechercherUnProduitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rechercherUnProduitToolStripMenuItem.Text = "Rechercher un Produit";
            this.rechercherUnProduitToolStripMenuItem.Click += new System.EventHandler(this.rechercherUnProduitToolStripMenuItem_Click);
            // 
            // créeUneFactureToolStripMenuItem
            // 
            this.créeUneFactureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créeUneFactureToolStripMenuItem1,
            this.toolStripSeparator4,
            this.afficherUneFactureToolStripMenuItem,
            this.listeDesFacturesToolStripMenuItem});
            this.créeUneFactureToolStripMenuItem.Name = "créeUneFactureToolStripMenuItem";
            this.créeUneFactureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.créeUneFactureToolStripMenuItem.Text = "Facture";
            // 
            // créeUneFactureToolStripMenuItem1
            // 
            this.créeUneFactureToolStripMenuItem1.Image = global::WindowsFormsApplicationBD.Properties.Resources.Atopsy_Iwork_Pages;
            this.créeUneFactureToolStripMenuItem1.Name = "créeUneFactureToolStripMenuItem1";
            this.créeUneFactureToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.créeUneFactureToolStripMenuItem1.Text = "Crée une Facture";
            this.créeUneFactureToolStripMenuItem1.Click += new System.EventHandler(this.créeUneFactureToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // afficherUneFactureToolStripMenuItem
            // 
            this.afficherUneFactureToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Atopsy_Iwork_Pages;
            this.afficherUneFactureToolStripMenuItem.Name = "afficherUneFactureToolStripMenuItem";
            this.afficherUneFactureToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.afficherUneFactureToolStripMenuItem.Text = "Afficher une Facture";
            this.afficherUneFactureToolStripMenuItem.Click += new System.EventHandler(this.afficherUneFactureToolStripMenuItem_Click);
            // 
            // listeDesFacturesToolStripMenuItem
            // 
            this.listeDesFacturesToolStripMenuItem.Image = global::WindowsFormsApplicationBD.Properties.Resources.Atopsy_Iwork_Pages;
            this.listeDesFacturesToolStripMenuItem.Name = "listeDesFacturesToolStripMenuItem";
            this.listeDesFacturesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listeDesFacturesToolStripMenuItem.Text = "Liste des Factures";
            this.listeDesFacturesToolStripMenuItem.Click += new System.EventHandler(this.listeDesFacturesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplicationBD.Properties.Resources._28deb599aede47c857d2038c0d2519ae_smartphones_and_devices_3d_icon_set;
            this.ClientSize = new System.Drawing.Size(773, 495);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion de Stock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem listClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFornisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem listeDesFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créeUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créeUneFactureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem listeDesFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

