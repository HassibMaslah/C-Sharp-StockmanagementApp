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
    public partial class frmListeClient : Form
    {
        public frmListeClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDstockDataSet);

        }

        private void frmListeClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDstockDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.bDstockDataSet.Client);

        }
    }
}
