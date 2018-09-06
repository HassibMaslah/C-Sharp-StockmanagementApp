namespace WindowsFormsApplicationBD
{
    partial class frmAjoutFacture
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
            System.Windows.Forms.Label codeFactureLabel;
            System.Windows.Forms.Label codeClientLabel;
            System.Windows.Forms.Label dateFactureLabel;
            System.Windows.Forms.Label retenuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutFacture));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bDstockDataSet = new WindowsFormsApplicationBD.BDstockDataSet();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factureTableAdapter = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.FactureTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplicationBD.BDstockDataSetTableAdapters.TableAdapterManager();
            this.codeFacture = new System.Windows.Forms.TextBox();
            this.codeClient = new System.Windows.Forms.TextBox();
            this.dateFactureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.retenu = new System.Windows.Forms.TextBox();
            this.BTeng = new System.Windows.Forms.Button();
            this.BTmod = new System.Windows.Forms.Button();
            this.BTsup = new System.Windows.Forms.Button();
            this.BTajout = new System.Windows.Forms.Button();
            this.BTnv = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            codeFactureLabel = new System.Windows.Forms.Label();
            codeClientLabel = new System.Windows.Forms.Label();
            dateFactureLabel = new System.Windows.Forms.Label();
            retenuLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeFactureLabel
            // 
            codeFactureLabel.AutoSize = true;
            codeFactureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codeFactureLabel.Location = new System.Drawing.Point(146, 165);
            codeFactureLabel.Name = "codeFactureLabel";
            codeFactureLabel.Size = new System.Drawing.Size(87, 13);
            codeFactureLabel.TabIndex = 2;
            codeFactureLabel.Text = "Code Facture:";
            // 
            // codeClientLabel
            // 
            codeClientLabel.AutoSize = true;
            codeClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codeClientLabel.Location = new System.Drawing.Point(146, 191);
            codeClientLabel.Name = "codeClientLabel";
            codeClientLabel.Size = new System.Drawing.Size(76, 13);
            codeClientLabel.TabIndex = 4;
            codeClientLabel.Text = "Code Client:";
            // 
            // dateFactureLabel
            // 
            dateFactureLabel.AutoSize = true;
            dateFactureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateFactureLabel.Location = new System.Drawing.Point(146, 218);
            dateFactureLabel.Name = "dateFactureLabel";
            dateFactureLabel.Size = new System.Drawing.Size(85, 13);
            dateFactureLabel.TabIndex = 6;
            dateFactureLabel.Text = "Date Facture:";
            // 
            // retenuLabel
            // 
            retenuLabel.AutoSize = true;
            retenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            retenuLabel.Location = new System.Drawing.Point(146, 243);
            retenuLabel.Name = "retenuLabel";
            retenuLabel.Size = new System.Drawing.Size(52, 13);
            retenuLabel.TabIndex = 8;
            retenuLabel.Text = "Retenu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SOGAND", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter une Facture";
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
            // codeFacture
            // 
            this.codeFacture.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factureBindingSource, "CodeFacture", true));
            this.codeFacture.Location = new System.Drawing.Point(239, 162);
            this.codeFacture.Name = "codeFacture";
            this.codeFacture.Size = new System.Drawing.Size(200, 20);
            this.codeFacture.TabIndex = 3;
            // 
            // codeClient
            // 
            this.codeClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factureBindingSource, "CodeClient", true));
            this.codeClient.Location = new System.Drawing.Point(239, 188);
            this.codeClient.Name = "codeClient";
            this.codeClient.Size = new System.Drawing.Size(200, 20);
            this.codeClient.TabIndex = 5;
            // 
            // dateFactureDateTimePicker
            // 
            this.dateFactureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factureBindingSource, "DateFacture", true));
            this.dateFactureDateTimePicker.Location = new System.Drawing.Point(239, 214);
            this.dateFactureDateTimePicker.Name = "dateFactureDateTimePicker";
            this.dateFactureDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateFactureDateTimePicker.TabIndex = 7;
            // 
            // retenu
            // 
            this.retenu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factureBindingSource, "Retenu", true));
            this.retenu.Location = new System.Drawing.Point(239, 240);
            this.retenu.Name = "retenu";
            this.retenu.Size = new System.Drawing.Size(200, 20);
            this.retenu.TabIndex = 9;
            // 
            // BTeng
            // 
            this.BTeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTeng.Location = new System.Drawing.Point(495, 307);
            this.BTeng.Name = "BTeng";
            this.BTeng.Size = new System.Drawing.Size(120, 30);
            this.BTeng.TabIndex = 29;
            this.BTeng.Text = "Enregistrer";
            this.BTeng.UseVisualStyleBackColor = true;
            this.BTeng.Click += new System.EventHandler(this.BTeng_Click);
            // 
            // BTmod
            // 
            this.BTmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTmod.Location = new System.Drawing.Point(372, 307);
            this.BTmod.Name = "BTmod";
            this.BTmod.Size = new System.Drawing.Size(120, 30);
            this.BTmod.TabIndex = 28;
            this.BTmod.Text = "Modifier";
            this.BTmod.UseVisualStyleBackColor = true;
            this.BTmod.Click += new System.EventHandler(this.BTmod_Click);
            // 
            // BTsup
            // 
            this.BTsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTsup.Location = new System.Drawing.Point(251, 307);
            this.BTsup.Name = "BTsup";
            this.BTsup.Size = new System.Drawing.Size(120, 30);
            this.BTsup.TabIndex = 27;
            this.BTsup.Text = "Supprimer";
            this.BTsup.UseVisualStyleBackColor = true;
            this.BTsup.Click += new System.EventHandler(this.BTsup_Click);
            // 
            // BTajout
            // 
            this.BTajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTajout.Location = new System.Drawing.Point(130, 307);
            this.BTajout.Name = "BTajout";
            this.BTajout.Size = new System.Drawing.Size(120, 30);
            this.BTajout.TabIndex = 26;
            this.BTajout.Text = "Ajout";
            this.BTajout.UseVisualStyleBackColor = true;
            this.BTajout.Click += new System.EventHandler(this.BTajout_Click);
            // 
            // BTnv
            // 
            this.BTnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnv.Location = new System.Drawing.Point(9, 307);
            this.BTnv.Name = "BTnv";
            this.BTnv.Size = new System.Drawing.Size(120, 30);
            this.BTnv.TabIndex = 25;
            this.BTnv.Text = "Nouveau";
            this.BTnv.UseVisualStyleBackColor = true;
            this.BTnv.Click += new System.EventHandler(this.BTnv_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(495, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 30);
            this.button4.TabIndex = 24;
            this.button4.Text = "Dernier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(495, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 23;
            this.button3.Text = "Suivant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(495, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Précédent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Premier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAjoutFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 389);
            this.Controls.Add(this.BTeng);
            this.Controls.Add(this.BTmod);
            this.Controls.Add(this.BTsup);
            this.Controls.Add(this.BTajout);
            this.Controls.Add(this.BTnv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(codeFactureLabel);
            this.Controls.Add(this.codeFacture);
            this.Controls.Add(codeClientLabel);
            this.Controls.Add(this.codeClient);
            this.Controls.Add(dateFactureLabel);
            this.Controls.Add(this.dateFactureDateTimePicker);
            this.Controls.Add(retenuLabel);
            this.Controls.Add(this.retenu);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjoutFacture";
            this.Text = "Crée une Facture";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BDstockDataSet bDstockDataSet;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private BDstockDataSetTableAdapters.FactureTableAdapter factureTableAdapter;
        private BDstockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codeFacture;
        private System.Windows.Forms.TextBox codeClient;
        private System.Windows.Forms.DateTimePicker dateFactureDateTimePicker;
        private System.Windows.Forms.TextBox retenu;
        private System.Windows.Forms.Button BTeng;
        private System.Windows.Forms.Button BTmod;
        private System.Windows.Forms.Button BTsup;
        private System.Windows.Forms.Button BTajout;
        private System.Windows.Forms.Button BTnv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}