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
    public partial class frmAjoutFournisseur : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        DataTable tab;
        DataRow dtr;
        int indice;
        public frmAjoutFournisseur()
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
            tab = dset.Tables[0];

            indice = 0;
            textCode.Text=(tab.Rows[0][0]).ToString();
            textNomPrenom.Text = (tab.Rows[0][1]).ToString();
            textAdresse.Text = (tab.Rows[0][2]).ToString();
            textTelephone.Text = (tab.Rows[0][3]).ToString();
            textFax.Text = (tab.Rows[0][4]).ToString();
            BTajout.Enabled = false;

        }

        private void BTnv_Click(object sender, EventArgs e)
        {
            textCode.Text = "";
            textNomPrenom.Text = "";
            textAdresse.Text = "";
            textTelephone.Text = "";
            textFax.Text = "";
            BTajout.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indice = 0;
            textCode.Text =      (tab.Rows[0][0]).ToString();
            textNomPrenom.Text = (tab.Rows[0][1]).ToString();
            textAdresse.Text =   (tab.Rows[0][2]).ToString();
            textTelephone.Text = (tab.Rows[0][3]).ToString();
            textFax.Text =       (tab.Rows[0][4]).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indice>0)
            {
                indice--;
                textCode.Text = (tab.Rows[indice][0]).ToString();
                textNomPrenom.Text = (tab.Rows[indice][1]).ToString();
                textAdresse.Text = (tab.Rows[indice][2]).ToString();
                textTelephone.Text = (tab.Rows[indice][3]).ToString();
                textFax.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (indice < tab.Rows.Count - 1)
            {
                indice++;
                textCode.Text = (tab.Rows[indice][0]).ToString();
                textNomPrenom.Text = (tab.Rows[indice][1]).ToString();
                textAdresse.Text = (tab.Rows[indice][2]).ToString();
                textTelephone.Text = (tab.Rows[indice][3]).ToString();
                textFax.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indice = tab.Rows.Count - 1;
            textCode.Text = (tab.Rows[indice][0]).ToString();
            textNomPrenom.Text = (tab.Rows[indice][1]).ToString();
            textAdresse.Text = (tab.Rows[indice][2]).ToString();
            textTelephone.Text = (tab.Rows[indice][3]).ToString();
            textFax.Text = (tab.Rows[indice][4]).ToString();
        }

        private void BTajout_Click(object sender, EventArgs e)
        {
            dtr = tab.NewRow();
            dtr[0] = textCode.Text;
            dtr[1] = textNomPrenom.Text;
            dtr[2] = textAdresse.Text;
            dtr[3] = textTelephone.Text;
            dtr[4] = textFax.Text;
            dset.Tables[0].Rows.Add(dtr);
            tab = dset.Tables[0];
            indice = tab.Rows.Count - 1;
            MessageBox.Show("Fournisseur Ajouté !");
            BTajout.Enabled = false;

        }

        private void BTsup_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vous Voulez Supprimer ce Fornisseur ? ", "Confirmer ce Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dset.Tables[0].Rows[indice].Delete();
                    dset.AcceptChanges();
                    indice--;
                    tab = dset.Tables[0];
                    if (indice < 0)
                        indice = 0;
                    if (tab.Rows.Count != 0)
                    {
                        textCode.Text = (tab.Rows[indice][0]).ToString();
                        textNomPrenom.Text = (tab.Rows[indice][1]).ToString();
                        textAdresse.Text = (tab.Rows[indice][2]).ToString();
                        textTelephone.Text = (tab.Rows[indice][3]).ToString();
                        textFax.Text = (tab.Rows[indice][4]).ToString();
                    }
                    else
                    {
                        textCode.Text = "";
                        textNomPrenom.Text = "";
                        textAdresse.Text = "";
                        textTelephone.Text = "";
                        textFax.Text = "";
                    }
                    MessageBox.Show("Fournisseur Supprimé avec Succée !");
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTmod_Click(object sender, EventArgs e)
        {
            try {
                 dset.Tables[0].Rows[indice][0] =textCode.Text;
                 dset.Tables[0].Rows[indice][1] =textNomPrenom.Text;
                 dset.Tables[0].Rows[indice][2] =textAdresse.Text;
                 dset.Tables[0].Rows[indice][3] =textTelephone.Text;
                 dset.Tables[0].Rows[indice][4] =textFax.Text;           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTeng_Click(object sender, EventArgs e)
        {
            try {
                cb =new SqlCommandBuilder(adap);
                adap.Update(dset, "Fornisseur");
                dset.Clear();
                adap.Fill(dset, "Fornisseur");
                tab = dset.Tables[0];
                MessageBox.Show("Données enregitré dans la base avec Succée !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        

      
    }
}
