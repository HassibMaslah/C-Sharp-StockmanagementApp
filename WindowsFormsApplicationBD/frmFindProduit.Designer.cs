namespace WindowsFormsApplicationBD
{
    partial class frmFindProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindProduit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recherche = new System.Windows.Forms.TextBox();
            this.CodeProduit = new System.Windows.Forms.RadioButton();
            this.NomProduit = new System.Windows.Forms.RadioButton();
            this.bDstockDataSet = new WindowsFormsApplicationBD.BDstockDataSet();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.ProduitTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.TableAdapterManager();
            this.buttonRech = new System.Windows.Forms.Button();
            this.produitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SOGAND", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(183, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche des Produits";
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(234, 159);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(198, 20);
            this.recherche.TabIndex = 1;
            // 
            // CodeProduit
            // 
            this.CodeProduit.AutoSize = true;
            this.CodeProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeProduit.Location = new System.Drawing.Point(207, 197);
            this.CodeProduit.Name = "CodeProduit";
            this.CodeProduit.Size = new System.Drawing.Size(98, 17);
            this.CodeProduit.TabIndex = 2;
            this.CodeProduit.TabStop = true;
            this.CodeProduit.Text = "Code Produit";
            this.CodeProduit.UseVisualStyleBackColor = true;
            // 
            // NomProduit
            // 
            this.NomProduit.AutoSize = true;
            this.NomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomProduit.Location = new System.Drawing.Point(366, 197);
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.Size = new System.Drawing.Size(94, 17);
            this.NomProduit.TabIndex = 3;
            this.NomProduit.TabStop = true;
            this.NomProduit.Text = "Nom Produit";
            this.NomProduit.UseVisualStyleBackColor = true;
            // 
            // bDstockDataSet
            // 
            this.bDstockDataSet.DataSetName = "BDstockDataSet";
            this.bDstockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.bDstockDataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.FornisseurTableAdapter = null;
            this.tableAdapterManager.LigneFactureTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplicationBD.BDstockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonRech
            // 
            this.buttonRech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRech.BackgroundImage")));
            this.buttonRech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRech.Location = new System.Drawing.Point(468, 151);
            this.buttonRech.Name = "buttonRech";
            this.buttonRech.Size = new System.Drawing.Size(52, 34);
            this.buttonRech.TabIndex = 6;
            this.buttonRech.UseVisualStyleBackColor = true;
            this.buttonRech.Click += new System.EventHandler(this.buttonRech_Click);
            // 
            // produitDataGridView
            // 
            this.produitDataGridView.AllowUserToAddRows = false;
            this.produitDataGridView.AllowUserToDeleteRows = false;
            this.produitDataGridView.AutoGenerateColumns = false;
            this.produitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.produitDataGridView.DataSource = this.produitBindingSource;
            this.produitDataGridView.Location = new System.Drawing.Point(59, 239);
            this.produitDataGridView.Name = "produitDataGridView";
            this.produitDataGridView.ReadOnly = true;
            this.produitDataGridView.Size = new System.Drawing.Size(541, 220);
            this.produitDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeProduit";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodeProduit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodeFourn";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodeFourn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomProduit";
            this.dataGridViewTextBoxColumn3.HeaderText = "NomProduit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrixUnitair";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrixUnitair";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QtEnStock";
            this.dataGridViewTextBoxColumn5.HeaderText = "QtEnStock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFindProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.produitDataGridView);
            this.Controls.Add(this.buttonRech);
            this.Controls.Add(this.NomProduit);
            this.Controls.Add(this.CodeProduit);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindProduit";
            this.Text = "Recherche des Produits";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.RadioButton CodeProduit;
        private System.Windows.Forms.RadioButton NomProduit;
        private BDstockDataSet bDstockDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private BDstockDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private BDstockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonRech;
        private System.Windows.Forms.DataGridView produitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}