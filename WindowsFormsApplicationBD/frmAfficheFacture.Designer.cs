namespace WindowsFormsApplicationBD
{
    partial class frmAfficheFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAfficheFacture));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Affiche = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bDstockDataSet = new WindowsFormsApplicationBD.BDstockDataSet();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factureTableAdapter = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.FactureTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.TableAdapterManager();
            this.factureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuFact = new System.Windows.Forms.RadioButton();
            this.DateFact = new System.Windows.Forms.RadioButton();
            this.dateFactureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SOGAND", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(181, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Afficher une Facture";
            // 
            // Affiche
            // 
            this.Affiche.Location = new System.Drawing.Point(245, 160);
            this.Affiche.Name = "Affiche";
            this.Affiche.Size = new System.Drawing.Size(234, 20);
            this.Affiche.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(496, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDstockDataSet
            // 
            this.bDstockDataSet.DataSetName = "BDstockDataSet";
            this.bDstockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factureBindingSource
            // 
            this.factureBindingSource.DataMember = "Facture";
            this.factureBindingSource.DataSource = this.bDstockDataSet;
            // 
            // factureTableAdapter
            // 
            this.factureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FactureTableAdapter = this.factureTableAdapter;
            this.tableAdapterManager.FornisseurTableAdapter = null;
            this.tableAdapterManager.LigneFactureTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplicationBD.BDstockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // factureDataGridView
            // 
            this.factureDataGridView.AllowUserToAddRows = false;
            this.factureDataGridView.AllowUserToDeleteRows = false;
            this.factureDataGridView.AutoGenerateColumns = false;
            this.factureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.factureDataGridView.DataSource = this.factureBindingSource;
            this.factureDataGridView.Location = new System.Drawing.Point(156, 244);
            this.factureDataGridView.Name = "factureDataGridView";
            this.factureDataGridView.ReadOnly = true;
            this.factureDataGridView.Size = new System.Drawing.Size(344, 220);
            this.factureDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeFacture";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodeFacture";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateFacture";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateFacture";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Retenu";
            this.dataGridViewTextBoxColumn4.HeaderText = "Retenu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // NuFact
            // 
            this.NuFact.AutoSize = true;
            this.NuFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuFact.Location = new System.Drawing.Point(102, 161);
            this.NuFact.Name = "NuFact";
            this.NuFact.Size = new System.Drawing.Size(123, 17);
            this.NuFact.TabIndex = 9;
            this.NuFact.TabStop = true;
            this.NuFact.Text = "Code de Facture:";
            this.NuFact.UseVisualStyleBackColor = true;
            this.NuFact.CheckedChanged += new System.EventHandler(this.NuFact_CheckedChanged);
            // 
            // DateFact
            // 
            this.DateFact.AutoSize = true;
            this.DateFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFact.Location = new System.Drawing.Point(102, 208);
            this.DateFact.Name = "DateFact";
            this.DateFact.Size = new System.Drawing.Size(121, 17);
            this.DateFact.TabIndex = 10;
            this.DateFact.TabStop = true;
            this.DateFact.Text = "Date de Facture:";
            this.DateFact.UseVisualStyleBackColor = true;
            this.DateFact.CheckedChanged += new System.EventHandler(this.DateFact_CheckedChanged);
            // 
            // dateFactureDateTimePicker
            // 
            this.dateFactureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factureBindingSource, "DateFacture", true));
            this.dateFactureDateTimePicker.Location = new System.Drawing.Point(245, 208);
            this.dateFactureDateTimePicker.Name = "dateFactureDateTimePicker";
            this.dateFactureDateTimePicker.Size = new System.Drawing.Size(234, 20);
            this.dateFactureDateTimePicker.TabIndex = 11;
            // 
            // frmAfficheFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 476);
            this.Controls.Add(this.dateFactureDateTimePicker);
            this.Controls.Add(this.DateFact);
            this.Controls.Add(this.NuFact);
            this.Controls.Add(this.factureDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Affiche);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAfficheFacture";
            this.Text = "Afficher une Facture";
            this.Load += new System.EventHandler(this.frmAfficheFacture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Affiche;
        private System.Windows.Forms.Button button1;
        private BDstockDataSet bDstockDataSet;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private BDstockDataSetTableAdapters.FactureTableAdapter factureTableAdapter;
        private BDstockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView factureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.RadioButton NuFact;
        private System.Windows.Forms.RadioButton DateFact;
        private System.Windows.Forms.DateTimePicker dateFactureDateTimePicker;
    }
}