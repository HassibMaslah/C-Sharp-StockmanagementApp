using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplicationBD
{
    public partial class frmAjoutProduit : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet dset;
        public frmAjoutProduit()
        {
            InitializeComponent();

            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=BDstock;Integrated Security=True";
            cnx.Open();

            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fornisseur";
            cmd.Connection = cnx;

            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fornisseur");
            cmbFourn.DataSource = dset.Tables[0];
            cmbFourn.DisplayMember = "NomPrenom";
            cmbFourn.ValueMember = "CodeFourn";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voulez vraiment ajouter ce Produit ? ", "Ajout d'un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                try {
                cmd.CommandText="insert into Produit values ("+txtCode.Text+""+cmbFourn.SelectedValue.ToString()+",'"+txtNom.Text+"',"+txtPrix.Text+","+txtQt.Text+")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion effectué avec succes","Insertion");
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
