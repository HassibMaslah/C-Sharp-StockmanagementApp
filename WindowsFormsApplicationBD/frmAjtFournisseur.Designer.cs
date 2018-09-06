namespace WindowsFormsApplicationBD
{
    partial class frmAjtFournisseur
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
            System.Windows.Forms.Label codeFormLabel;
            System.Windows.Forms.Label nomPrenomLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjtFournisseur));
            this.BTeng = new System.Windows.Forms.Button();
            this.BTmod = new System.Windows.Forms.Button();
            this.BTsup = new System.Windows.Forms.Button();
            this.BTajout = new System.Windows.Forms.Button();
            this.BTnv = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textNomPrenom = new System.Windows.Forms.TextBox();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.textFax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            codeFormLabel = new System.Windows.Forms.Label();
            nomPrenomLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTeng
            // 
            this.BTeng.Location = new System.Drawing.Point(521, 337);
            this.BTeng.Name = "BTeng";
            this.BTeng.Size = new System.Drawing.Size(120, 30);
            this.BTeng.TabIndex = 40;
            this.BTeng.Text = "Enregistrer";
            this.BTeng.UseVisualStyleBackColor = true;
            this.BTeng.Click += new System.EventHandler(this.BTeng_Click_1);
            // 
            // BTmod
            // 
            this.BTmod.Location = new System.Drawing.Point(398, 337);
            this.BTmod.Name = "BTmod";
            this.BTmod.Size = new System.Drawing.Size(120, 30);
            this.BTmod.TabIndex = 39;
            this.BTmod.Text = "Modifier";
            this.BTmod.UseVisualStyleBackColor = true;
            this.BTmod.Click += new System.EventHandler(this.BTmod_Click_1);
            // 
            // BTsup
            // 
            this.BTsup.Location = new System.Drawing.Point(277, 337);
            this.BTsup.Name = "BTsup";
            this.BTsup.Size = new System.Drawing.Size(120, 30);
            this.BTsup.TabIndex = 38;
            this.BTsup.Text = "Supprimer";
            this.BTsup.UseVisualStyleBackColor = true;
            this.BTsup.Click += new System.EventHandler(this.BTsup_Click_1);
            // 
            // BTajout
            // 
            this.BTajout.Location = new System.Drawing.Point(156, 337);
            this.BTajout.Name = "BTajout";
            this.BTajout.Size = new System.Drawing.Size(120, 30);
            this.BTajout.TabIndex = 37;
            this.BTajout.Text = "Ajout";
            this.BTajout.UseVisualStyleBackColor = true;
            this.BTajout.Click += new System.EventHandler(this.BTajout_Click_1);
            // 
            // BTnv
            // 
            this.BTnv.Location = new System.Drawing.Point(35, 337);
            this.BTnv.Name = "BTnv";
            this.BTnv.Size = new System.Drawing.Size(120, 30);
            this.BTnv.TabIndex = 36;
            this.BTnv.Text = "Nouveau";
            this.BTnv.UseVisualStyleBackColor = true;
            this.BTnv.Click += new System.EventHandler(this.BTnv_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(521, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 30);
            this.button4.TabIndex = 35;
            this.button4.Text = "Dernier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 34;
            this.button3.Text = "Suivant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 33;
            this.button2.Text = "Précédent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "Premier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // codeFormLabel
            // 
            codeFormLabel.AutoSize = true;
            codeFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codeFormLabel.Location = new System.Drawing.Point(32, 161);
            codeFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codeFormLabel.Name = "codeFormLabel";
            codeFormLabel.Size = new System.Drawing.Size(93, 16);
            codeFormLabel.TabIndex = 22;
            codeFormLabel.Text = "Code Form:";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(158, 158);
            this.textCode.Margin = new System.Windows.Forms.Padding(4);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(336, 20);
            this.textCode.TabIndex = 23;
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomPrenomLabel.Location = new System.Drawing.Point(32, 193);
            nomPrenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(105, 16);
            nomPrenomLabel.TabIndex = 24;
            nomPrenomLabel.Text = "Nom Prenom:";
            // 
            // textNomPrenom
            // 
            this.textNomPrenom.Location = new System.Drawing.Point(158, 190);
            this.textNomPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.textNomPrenom.Name = "textNomPrenom";
            this.textNomPrenom.Size = new System.Drawing.Size(336, 20);
            this.textNomPrenom.TabIndex = 25;
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresseLabel.Location = new System.Drawing.Point(32, 225);
            adresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(72, 16);
            adresseLabel.TabIndex = 26;
            adresseLabel.Text = "Adresse:";
            // 
            // textAdresse
            // 
            this.textAdresse.Location = new System.Drawing.Point(158, 222);
            this.textAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(336, 20);
            this.textAdresse.TabIndex = 27;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(32, 257);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(88, 16);
            telephoneLabel.TabIndex = 28;
            telephoneLabel.Text = "Telephone:";
            // 
            // textTelephone
            // 
            this.textTelephone.Location = new System.Drawing.Point(158, 254);
            this.textTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(336, 20);
            this.textTelephone.TabIndex = 29;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faxLabel.Location = new System.Drawing.Point(32, 289);
            faxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(39, 16);
            faxLabel.TabIndex = 30;
            faxLabel.Text = "Fax:";
            // 
            // textFax
            // 
            this.textFax.Location = new System.Drawing.Point(158, 286);
            this.textFax.Margin = new System.Windows.Forms.Padding(4);
            this.textFax.Name = "textFax";
            this.textFax.Size = new System.Drawing.Size(336, 20);
            this.textFax.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(35, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(606, 121);
            this.groupBox1.TabIndex = 21;
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
            // frmAjtFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 370);
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
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjtFournisseur";
            this.Text = "Ajouter un Fournisseur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTeng;
        private System.Windows.Forms.Button BTmod;
        private System.Windows.Forms.Button BTsup;
        private System.Windows.Forms.Button BTajout;
        private System.Windows.Forms.Button BTnv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textNomPrenom;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.TextBox textFax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}