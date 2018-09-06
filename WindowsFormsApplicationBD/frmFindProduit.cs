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
    public partial class frmFindProduit : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet dset3;
        SqlConnection cnx;
        public frmFindProduit()
        {
            InitializeComponent();


        }

        private void buttonRech_Click(object sender, EventArgs e)
        {       
            try
            {
                if (NomProduit.Checked)
                {
                    cnx = new SqlConnection();
                    cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=BDstock;Integrated Security=True";
                    cnx.Open();

                    cmd = new SqlCommand();
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fornisseur',PrixUnitair,QtEnStock From Produit P,Fornisseur F where P.CodeFourn=F.CodeFourn and NomProduit like('" + recherche.Text + "%')";
                    cmd.Connection = cnx;
                    adap = new SqlDataAdapter(cmd);
                    dset3 = new DataSet();
                    adap.Fill(dset3, "Fornisseur");
                    produitDataGridView.DataSource = dset3.Tables[0];
                }
                if (CodeProduit.Checked)
                {
                    cnx = new SqlConnection();
                    cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=BDstock;Integrated Security=True";
                    cnx.Open();

                    cmd = new SqlCommand();
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fornisseur',PrixUnitair,QtEnStock From Produit P,Fornisseur F where P.CodeFourn=F.CodeFourn and CodeProduit like('" + recherche.Text + "%')";
                    cmd.Connection = cnx;
                    adap = new SqlDataAdapter(cmd);
                    dset3 = new DataSet();
                    adap.Fill(dset3, "Fornisseur");
                    produitDataGridView.DataSource = dset3.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
