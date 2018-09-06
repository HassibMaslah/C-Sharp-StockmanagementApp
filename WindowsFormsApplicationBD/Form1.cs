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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutClient frmajout = new frmAjoutClient();
            frmajout.Show();
        }

        private void listClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeClient list = new frmListeClient();
            list.Show();
        }

        private void ajouterUnFornisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjtFournisseur frn = new frmAjtFournisseur();
            frn.Show();
        }

        private void listeDesFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeFournisseur f = new frmListeFournisseur();
            f.Show();
        }

        private void ajouterProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutProduit p = new frmAjoutProduit();
            p.Show();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeProduit lp = new frmListeProduit();
            lp.Show();
        }

        private void rechercherUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindProduit fp = new frmFindProduit();
            fp.Show();
        }

        private void créeUneFactureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAjoutFacture fa = new frmAjoutFacture();
            fa.Show();
        }

        private void afficherUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAfficheFacture af = new frmAfficheFacture();
            af.Show();
        }

        private void listeDesFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeFacture lf = new frmListeFacture();
            lf.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Vous Besoin d'Aide !\nContacter nous sur l'E-mail : masociete@gmail.com ");
        }

        
    }
}
