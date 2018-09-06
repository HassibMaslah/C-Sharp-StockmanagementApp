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
    public partial class frmAfficheFacture : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet dset;
        SqlConnection cnx;
        public frmAfficheFacture()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((NuFact.Checked)&(Affiche.Text!=""))
            {
                cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=BDstock;Integrated Security=True";
                cnx.Open();

                cmd = new SqlCommand();
                cmd.CommandText = "select CodeFacture,DateFacture,Retenu From Client C,Facture F where C.CodeClient=F.CodeClient and CodeFacture like('" + Affiche.Text + "%')";
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset = new DataSet();
                adap.Fill(dset, "Client");
                factureDataGridView.DataSource = dset.Tables[0];
            }
            if (DateFact.Checked)
            {
               String dateF = dateFactureDateTimePicker.Value.ToString();
                cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=BDstock;Integrated Security=True";
                cnx.Open();

                cmd = new SqlCommand();
                cmd.CommandText = "select CodeFacture,DateFacture,Retenu From Client C,Facture F where C.CodeClient=F.CodeClient and DateFacture ='"+DateTime.Parse( dateF)+"'";
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset = new DataSet();
                adap.Fill(dset, "Client");
                factureDataGridView.DataSource = dset.Tables[0];
                MessageBox.Show("la date est : " + dateF);
            }
            
        }

        private void factureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.factureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDstockDataSet);

        }

        private void frmAfficheFacture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDstockDataSet.Facture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.factureTableAdapter.Fill(this.bDstockDataSet.Facture);

        }

        private void NuFact_CheckedChanged(object sender, EventArgs e)
        {
            if (NuFact.Checked)
            {
                dateFactureDateTimePicker.Enabled = false;
            }else
                dateFactureDateTimePicker.Enabled = true;
        }

        private void DateFact_CheckedChanged(object sender, EventArgs e)
        {
            if (DateFact.Checked)
                Affiche.Enabled = false;
            else
                Affiche.Enabled = true;
        }

     
    }
}
