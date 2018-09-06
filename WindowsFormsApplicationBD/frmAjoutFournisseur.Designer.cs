namespace WindowsFormsApplicationBD
{
    partial class frmAjoutFournisseur
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
            System.Windows.Forms.Label codeFormLabel;
            System.Windows.Forms.Label nomPrenomLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutFournisseur));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bDstockDataSet = new WindowsFormsApplicationBD.BDstockDataSet();
            this.fornisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornisseurTableAdapter = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.FornisseurTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.TableAdapterManager();
            this.fornisseurBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fornisseurBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textNomPrenom = new System.Windows.Forms.TextBox();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.textFax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTnv = new System.Windows.Forms.Button();
            this.BTajout = new System.Windows.Forms.Button();
            this.BTsup = new System.Windows.Forms.Button();
            this.BTmod = new System.Windows.Forms.Button();
            this.BTeng = new System.Windows.Forms.Button();
            codeFormLabel = new System.Windows.Forms.Label();
            nomPrenomLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingNavigator)).BeginInit();
            this.fornisseurBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeFormLabel
            // 
            codeFormLabel.AutoSize = true;
            codeFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codeFormLabel.Location = new System.Drawing.Point(15, 173);
            codeFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codeFormLabel.Name = "codeFormLabel";
            codeFormLabel.Size = new System.Drawing.Size(88, 16);
            codeFormLabel.TabIndex = 2;
            codeFormLabel.Text = "Code Form:";
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomPrenomLabel.Location = new System.Drawing.Point(15, 205);
            nomPrenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(101, 16);
            nomPrenomLabel.TabIndex = 4;
            nomPrenomLabel.Text = "Nom Prenom:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresseLabel.Location = new System.Drawing.Point(15, 237);
            adresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(70, 16);
            adresseLabel.TabIndex = 6;
            adresseLabel.Text = "Adresse:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(15, 269);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(87, 16);
            telephoneLabel.TabIndex = 8;
            telephoneLabel.Text = "Telephone:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faxLabel.Location = new System.Drawing.Point(15, 301);
            faxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(37, 16);
            faxLabel.TabIndex = 10;
            faxLabel.Text = "Fax:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(606, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SOGAND", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(291, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fournisseur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplicationBD.Properties.Resources.Lorry_Green_icon_icons_com_54887;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bDstockDataSet
            // 
            this.bDstockDataSet.DataSetName = "BDstockDataSet";
            this.bDstockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornisseurBindingSource
            // 
            this.fornisseurBindingSource.DataMember = "Fornisseur";
            this.fornisseurBindingSource.DataSource = this.bDstockDataSet;
            // 
            // fornisseurTableAdapter
            // 
            this.fornisseurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.FornisseurTableAdapter = this.fornisseurTableAdapter;
            this.tableAdapterManager.LigneFactureTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplicationBD.BDstockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fornisseurBindingNavigator
            // 
            this.fornisseurBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fornisseurBindingNavigator.BindingSource = this.fornisseurBindingSource;
            this.fornisseurBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornisseurBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fornisseurBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fornisseurBindingNavigatorSaveItem});
            this.fornisseurBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornisseurBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornisseurBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornisseurBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornisseurBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornisseurBindingNavigator.Name = "fornisseurBindingNavigator";
            this.fornisseurBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fornisseurBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornisseurBindingNavigator.Size = new System.Drawing.Size(641, 25);
            this.fornisseurBindingNavigator.TabIndex = 1;
            this.fornisseurBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fornisseurBindingNavigatorSaveItem
            // 
            this.fornisseurBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornisseurBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornisseurBindingNavigatorSaveItem.Image")));
            this.fornisseurBindingNavigatorSaveItem.Name = "fornisseurBindingNavigatorSaveItem";
            this.fornisseurBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornisseurBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // textCode
            // 
            this.textCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornisseurBindingSource, "CodeForm", true));
            this.textCode.Location = new System.Drawing.Point(141, 170);
            this.textCode.Margin = new System.Windows.Forms.Padding(4);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(336, 22);
            this.textCode.TabIndex = 3;
            // 
            // textNomPrenom
            // 
            this.textNomPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornisseurBindingSource, "NomPrenom", true));
            this.textNomPrenom.Location = new System.Drawing.Point(141, 202);
            this.textNomPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.textNomPrenom.Name = "textNomPrenom";
            this.textNomPrenom.Size = new System.Drawing.Size(336, 22);
            this.textNomPrenom.TabIndex = 5;
            // 
            // textAdresse
            // 
            this.textAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornisseurBindingSource, "Adresse", true));
            this.textAdresse.Location = new System.Drawing.Point(141, 234);
            this.textAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(336, 22);
            this.textAdresse.TabIndex = 7;
            // 
            // textTelephone
            // 
            this.textTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornisseurBindingSource, "Telephone", true));
            this.textTelephone.Location = new System.Drawing.Point(141, 266);
            this.textTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(336, 22);
            this.textTelephone.TabIndex = 9;
            // 
            // textFax
            // 
            this.textFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornisseurBindingSource, "Fax", true));
            this.textFax.Location = new System.Drawing.Point(141, 298);
            this.textFax.Margin = new System.Windows.Forms.Padding(4);
            this.textFax.Name = "textFax";
            this.textFax.Size = new System.Drawing.Size(336, 22);
            this.textFax.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Premier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Précédent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "Suivant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(504, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Dernier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTnv
            // 
            this.BTnv.Location = new System.Drawing.Point(18, 349);
            this.BTnv.Name = "BTnv";
            this.BTnv.Size = new System.Drawing.Size(120, 30);
            this.BTnv.TabIndex = 16;
            this.BTnv.Text = "Nouveau";
            this.BTnv.UseVisualStyleBackColor = true;
            this.BTnv.Click += new System.EventHandler(this.BTnv_Click);
            // 
            // BTajout
            // 
            this.BTajout.Location = new System.Drawing.Point(139, 349);
            this.BTajout.Name = "BTajout";
            this.BTajout.Size = new System.Drawing.Size(120, 30);
            this.BTajout.TabIndex = 17;
            this.BTajout.Text = "Ajout";
            this.BTajout.UseVisualStyleBackColor = true;
            this.BTajout.Click += new System.EventHandler(this.BTajout_Click);
            // 
            // BTsup
            // 
            this.BTsup.Location = new System.Drawing.Point(260, 349);
            this.BTsup.Name = "BTsup";
            this.BTsup.Size = new System.Drawing.Size(120, 30);
            this.BTsup.TabIndex = 18;
            this.BTsup.Text = "Supprimer";
            this.BTsup.UseVisualStyleBackColor = true;
            this.BTsup.Click += new System.EventHandler(this.BTsup_Click);
            // 
            // BTmod
            // 
            this.BTmod.Location = new System.Drawing.Point(381, 349);
            this.BTmod.Name = "BTmod";
            this.BTmod.Size = new System.Drawing.Size(120, 30);
            this.BTmod.TabIndex = 19;
            this.BTmod.Text = "Modifier";
            this.BTmod.UseVisualStyleBackColor = true;
            this.BTmod.Click += new System.EventHandler(this.BTmod_Click);
            // 
            // BTeng
            // 
            this.BTeng.Location = new System.Drawing.Point(504, 349);
            this.BTeng.Name = "BTeng";
            this.BTeng.Size = new System.Drawing.Size(120, 30);
            this.BTeng.TabIndex = 20;
            this.BTeng.Text = "Enregistrer";
            this.BTeng.UseVisualStyleBackColor = true;
            this.BTeng.Click += new System.EventHandler(this.BTeng_Click);
            // 
            // frmAjoutFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 399);
            this.Controls.Add(this.BTeng);
            this.Controls.Add(this.BTmod);
            this.Controls.Add(this.BTsup);
            this.Controls.Add(this.BTajout);
            this.Controls.Add(this.BTnv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(codeFormLabel);
            this.Controls.Add(this.textCode);
            this.Controls.Add(nomPrenomLabel);
            this.Controls.Add(this.textNomPrenom);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.textAdresse);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.textTelephone);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.textFax);
            this.Controls.Add(this.fornisseurBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAjoutFournisseur";
            this.Text = "Ajouter un Fournisseur";
            //this.Load += new System.EventHandler(this.frmAjoutFournisseur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornisseurBindingNavigator)).EndInit();
            this.fornisseurBindingNavigator.ResumeLayout(false);
            this.fornisseurBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BDstockDataSet bDstockDataSet;
        private System.Windows.Forms.BindingSource fornisseurBindingSource;
        private BDstockDataSetTableAdapters.FornisseurTableAdapter fornisseurTableAdapter;
        private BDstockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fornisseurBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornisseurBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textNomPrenom;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.TextBox textFax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTnv;
        private System.Windows.Forms.Button BTajout;
        private System.Windows.Forms.Button BTsup;
        private System.Windows.Forms.Button BTmod;
        private System.Windows.Forms.Button BTeng;

        public System.EventHandler frmAjoutFournisseur_Load { get; set; }
    }
}