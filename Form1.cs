using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Övning_4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnÖppnaFil_Click(object sender, EventArgs e)
        {
            DialogResult resultat = dlgÖppnaFil.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                this.lbxKontakt.Items.Clear();
                FileStream inData = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                StreamReader lasa = new StreamReader(inData);
                string fornamn = lasa.ReadLine();
                while (fornamn != null)
                {                    
                    Kontakt k = new Kontakt(fornamn, lasa.ReadLine(), lasa.ReadLine(), lasa.ReadLine());
                    this.lbxKontakt.Items.Add(k);
                    fornamn = lasa.ReadLine();
                }                
                lasa.Dispose();
            }
        }

        private void btnSparaFil_Click(object sender, EventArgs e)
        {
            DialogResult resultat = dlgSparaFil.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                FileStream utData = new FileStream(this.dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter skrivare = new StreamWriter(utData);
                foreach (Kontakt k in this.lbxKontakt.Items)
                {
                    skrivare.WriteLine(k.Fornamn);
                    skrivare.WriteLine(k.Efternamn);
                    skrivare.WriteLine(k.Epost);
                    skrivare.WriteLine(k.Telefonnummer);
                }
                skrivare.Dispose();
            }
        }


        private void btnLäggTill_Click(object sender, EventArgs e)
        {

            Kontakt kontakt = new Kontakt(this.tbxFörnamn.Text, this.tbxEfternamn.Text, this.tbxepost.Text, this.tbxTelefonnummer.Text);
            this.lbxKontakt.Items.Add(kontakt);
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            lbxKontakt.Items.Remove(lbxKontakt.SelectedItem);
        }

        private void lbxKontakt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbxKontakt.SelectedItem == null)
            {
                this.tbxFörnamn.Text = "";
                this.tbxEfternamn.Text = "";
                this.tbxepost.Text = "";
                this.tbxTelefonnummer.Text = "";
            }
            else
            {
                Kontakt selectedItem = this.lbxKontakt.SelectedItem as Kontakt;
                this.tbxFörnamn.Text = selectedItem.Fornamn;
                this.tbxEfternamn.Text = selectedItem.Efternamn;
                this.tbxepost.Text = selectedItem.Epost;
                this.tbxTelefonnummer.Text = selectedItem.Telefonnummer;
            }
        }



        internal class Kontakt
        {
            private string efternamn;

            private string epost;

            private string telefonnr;


            public string Fornamn
            {get;set;}
            public string Efternamn
            {get;set;}

            public string Epost
            {get;set;}

            public string Telefonnummer
            {get;set;}

            public Kontakt(string fornamn, string efternamn, string epost, string telenr)
            {
                this.Fornamn = fornamn;
                this.Efternamn = efternamn;
                this.Epost = epost;
                this.Telefonnummer = telenr;
            }


            public override string ToString()
            {
                return Fornamn + " " + Efternamn;
            }
        }
    }
}
