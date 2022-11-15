using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adherent_TP3
{
    public partial class FrmGestionAdherents : Form
    {
        public FrmGestionAdherents()
        {
            InitializeComponent();
        }

        private void FrmGestionAdherents_Load(object sender, EventArgs e)
        {
            

           // tabCAdherentGestionnaire.TabPages.Add(tabPAdherent);
            tabCAdherentGestionnaire.TabPages.Remove(tabPGestionnaire);
            tabPAdherent.Show();
            tabPGestionnaire.Hide();

            listBAdherents.Items.Add(new Adherent("n1","p1","mail1", new DateTime(2001,6,15)));
            listBAdherents.Items.Add(new Adherent("n2", "p2", "mail2", new DateTime(2002,7, 15)));
            listBAdherents.Items.Add(new Adherent("n3", "p3", "mail3", new DateTime(2003, 6, 15)));

        }

        private void Gestionnaire_Click(object sender, EventArgs e)
        {

        }

        private void rdbAdherent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAdherent.Checked)
            {
                tabCAdherentGestionnaire.TabPages.Remove(tabPGestionnaire);
                tabCAdherentGestionnaire.TabPages.Add(tabPAdherent);
                tabPAdherent.Show();
                tabPGestionnaire.Hide();
            }
            else
            {

                tabCAdherentGestionnaire.TabPages.Remove(tabPAdherent);
                tabCAdherentGestionnaire.TabPages.Add(tabPGestionnaire);
                tabPAdherent.Hide();
                tabPGestionnaire.Show();

            }
               
        }

        private void btAjoutAdherent_Click(object sender, EventArgs e)
        {
            DateTime dtDateNaiss = DateTime.Parse(txtDateNaissG.Text);
            DateTime dtDateNaiss2 = Convert.ToDateTime(txtDateNaissG.Text);
            Adherent objAd = new Adherent( txtNom.Text, txtPrenom.Text, txtMailG.Text, dtDateNaiss);

            listBAdherents.Items.Add(objAd);
        }

        private void listBAdherents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBAdherents.SelectedIndex >-1 )
            {
                Adherent adh = (Adherent)listBAdherents.SelectedItem;
                
                lblNom.Text = adh.GetNom();
                txtNom.Text = adh.GetNom();
                lblPrenom.Text = adh.GetPrenom();
                txtPrenom.Text = adh.GetPrenom();
                txtMailA.Text = adh.GetMail();
                txtMailG.Text = adh.GetMail();
                txtDateNaissG.Text = ""+adh.GetDateNaissance().ToShortDateString();
                lblAge.Text = "" + adh.GetAge();
            }
            
           

        }

        private void btSupAdherent_Click(object sender, EventArgs e)
        {
            if (listBAdherents.SelectedIndex > -1)
            {
                listBAdherents.Items.RemoveAt(listBAdherents.SelectedIndex);
            }
        }

        private void btModifMail_Click(object sender, EventArgs e)
        {
            Adherent adh = (Adherent)listBAdherents.SelectedItem;
            listBAdherents.Items.Remove(listBAdherents.SelectedItem);

          
            adh.SetMail(txtMailA.Text);

            listBAdherents.Items.Add(adh);

           
        }

        
    }
}
