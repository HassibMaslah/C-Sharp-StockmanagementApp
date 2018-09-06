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
    public partial class frmAjoutFacture : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        DataTable tab;
        DataRow dtr;
        int indice;
        public frmAjoutFacture()
        {
            InitializeComponent();
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=BDstock;Integrated Security=True";
            cnx.Open();

            cmd = new SqlCommand();
            cmd.CommandText = "select * from Facture";
            cmd.Connection = cnx;

            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Facture");
            tab = dset.Tables[0];

            indice = 0;
            codeFacture.Text = (tab.Rows[0][0]).ToString();
            codeClient.Text = (tab.Rows[0][1]).ToString();
            dateFactureDateTimePicker.Text = (tab.Rows[0][2]).ToString();
            retenu.Text = (tab.Rows[0][3]).ToString();
            BTajout.Enabled = false;
        }

        private void BTnv_Click(object sender, EventArgs e)
        {
            codeFacture.Text = "";
            codeClient.Text = "";
            dateFactureDateTimePicker.Text = "";
            retenu.Text = "";
            BTajout.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indice = 0;
            codeFacture.Text = (tab.Rows[0][0]).ToString();
            codeClient.Text = (tab.Rows[0][1]).ToString();
            dateFactureDateTimePicker.Text = (tab.Rows[0][2]).ToString();
            retenu.Text = (tab.Rows[0][3]).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                codeFacture.Text = (tab.Rows[indice][0]).ToString();
                codeClient.Text = (tab.Rows[indice][1]).ToString();
                dateFactureDateTimePicker.Text = (tab.Rows[indice][2]).ToString();
                retenu.Text = (tab.Rows[indice][3]).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (indice < tab.Rows.Count - 1)
            {
               indice++;
                codeFacture.Text = (tab.Rows[indice][0]).ToString();
                codeClient.Text = (tab.Rows[indice][1]).ToString();
                dateFactureDateTimePicker.Text = (tab.Rows[indice][2]).ToString();
                retenu.Text = (tab.Rows[indice][3]).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indice = tab.Rows.Count - 1;
            codeFacture.Text = (tab.Rows[indice][0]).ToString();
            codeClient.Text = (tab.Rows[indice][1]).ToString();
            dateFactureDateTimePicker.Text = (tab.Rows[indice][2]).ToString();
            retenu.Text = (tab.Rows[indice][3]).ToString();
        }

        private void BTajout_Click(object sender, EventArgs e)
        {
            dtr = tab.NewRow();
            dtr[0] = codeFacture.Text;
            dtr[1] = codeClient.Text;
            dtr[2] = dateFactureDateTimePicker.Text;
            dtr[3] = retenu.Text;
            dset.Tables[0].Rows.Add(dtr);
            tab = dset.Tables[0];
            indice = tab.Rows.Count - 1;
            MessageBox.Show("Facture Ajouté !");
            BTajout.Enabled = false;
        }

        private void BTsup_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vous Voulez Supprimer ce Facture ? ", "Confirmer ce Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dset.Tables[0].Rows[indice].Delete();
                    dset.AcceptChanges();
                    indice--;
                    tab = dset.Tables[0];
                    if (indice < 0)
                        indice = 0;
                    if (tab.Rows.Count != 0)
                    {
                        codeFacture.Text = (tab.Rows[indice][0]).ToString();
                        codeClient.Text = (tab.Rows[indice][1]).ToString();
                        dateFactureDateTimePicker.Text = (tab.Rows[indice][2]).ToString();
                        retenu.Text = (tab.Rows[indice][3]).ToString();
                    }
                    else
                    {
                        codeFacture.Text = "";
                        codeClient.Text = "";
                        dateFactureDateTimePicker.Text = "";
                        retenu.Text = "";                
                    }
                    MessageBox.Show("Facture Supprimé avec Succée !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTmod_Click(object sender, EventArgs e)
        {
            try
            {
                dset.Tables[0].Rows[indice][0] = codeFacture.Text;
                dset.Tables[0].Rows[indice][1] = codeClient.Text;
                dset.Tables[0].Rows[indice][2] = dateFactureDateTimePicker.Text;
                dset.Tables[0].Rows[indice][3] = retenu.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTeng_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new SqlCommandBuilder(adap);
                adap.Update(dset, "Facture");
                dset.Clear();
                adap.Fill(dset, "Facture");
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
