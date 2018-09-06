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
    public partial class frmListeFournisseur : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        public frmListeFournisseur()
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
            fornisseurDataGridView.DataSource = dset.Tables[0];
        }

        private void fornisseurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornisseurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDstockDataSet);

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vous Voulez Supprimer ce Fornisseur ? ", "Confirmer ce Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int i = fornisseurDataGridView.CurrentRow.Index;
                    dset.Tables[0].Rows[i].Delete();
                    cb = new SqlCommandBuilder(adap);
                    adap.Update(dset, "Fornisseur");

                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
            }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vous Voulez Enregistrer le Modification ? ", "Confirmer la Modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cb = new SqlCommandBuilder(adap);
                    adap.Update(dset, "Fornisseur");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          

       
      
    }
}
