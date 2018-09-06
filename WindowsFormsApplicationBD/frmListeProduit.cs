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
    public partial class frmListeProduit : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap,adap3;
        DataSet dset, dset2, dset3;

        public frmListeProduit()
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
            DataRow dr;
            dr = dset.Tables[0].NewRow();
            dr["NomPrenom"] = "Toute La Liste";
            dset.Tables[0].Rows.Add(dr);

            cmbFourn.DataSource = dset.Tables[0];
            cmbFourn.DisplayMember = "NomPrenom";
            cmbFourn.ValueMember = "CodeFourn";

            cmd = new SqlCommand();
            cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fornisseur',PrixUnitair,QtEnStock From Produit P,Fornisseur F where P.CodeFourn=F.CodeFourn";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset2 = new DataSet();
            adap.Fill(dset2, "Produit");
            produitDataGridView.DataSource = dset2.Tables[0];
            cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
        }

        private void cmbFourn_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            if (cmbFourn.SelectedIndex == cmbFourn.Items.Count - 1)
            {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fornisseur',PrixUnitair,QtEnStock From Produit P,Fornisseur F where P.CodeFourn=F.CodeFourn";
            }
            else {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fornisseur',PrixUnitair,QtEnStock From Produit P,Fornisseur F where P.CodeFourn=F.CodeFourn and P.CodeFourn="+cmbFourn.SelectedValue;
                cmd.Connection = cnx;
                adap3 = new SqlDataAdapter(cmd);
                dset3 = new DataSet();
                adap3.Fill(dset3, "Produit");          
                produitDataGridView.DataSource = dset3.Tables[0];
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous Voulez Supprimer ce Produit ? ", "Confirmer ce Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                try
                {
                    cmd.CommandText = "delete from Produit where CodeProduit=" + produitDataGridView.CurrentRow.Cells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("supprission effectué avec succée", "Suppression");
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fornisseur',PrixUnitair,QtEnStock From Produit P,Fornisseur F where P.CodeFourn=F.CodeFourn";
                    cmd.Connection = cnx;
                    adap = new SqlDataAdapter(cmd);
                    dset2 = new DataSet();
                    adap.Fill(dset2, "Produit");
                    produitDataGridView.DataSource = dset2.Tables[0];
                    cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
