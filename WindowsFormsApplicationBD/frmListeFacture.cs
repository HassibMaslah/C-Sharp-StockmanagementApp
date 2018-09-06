using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationBD
{
    public partial class frmListeFacture : Form
    {
        public frmListeFacture()
        {
            InitializeComponent();
        }

        private void factureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.factureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDstockDataSet);

        }

        private void frmListeFacture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDstockDataSet.Facture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.factureTableAdapter.Fill(this.bDstockDataSet.Facture);

        }
    }
}
