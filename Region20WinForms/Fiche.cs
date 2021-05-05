using Region20WinForms.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Region20WinForms
{
    public partial class Fiche : Form
    {
        private Form caller_form;
        public Fiche(string title="Tests", Form caller_form=null)
        {
            InitializeComponent();

            //code suite..
            this.caller_form = caller_form; // recup. fen. appelante eventuelle!

            this.Text = title;
            this.FormClosed += Tests_FormClosed;
        }

        private void Tests_FormClosed(object sender, FormClosedEventArgs e)
        {
            //rendre visible fenêtre appelante!
            if (this.caller_form != null)
                this.caller_form.Visible = true; //..rendre fen. appelante visible!
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //récup. infos form..
            string prenom = tbPrenom.Text;
            string nom = tbNom.Text;
            string adresse = tbAdresse.Text;

            string sexe = rbh.Checked ? "Masculin" : "Feminin";

            List<string> competences = new List<string>();
            //StringBuilder competences = new StringBuilder();
            if (cb1.Checked)
                competences.Append("Java");
            if (cb2.Checked)
                competences.Append("Android");
            if (cb3.Checked)
                competences.Append("CSharp");
            if (cb4.Checked)
                competences.Append("Web");


            //..traitement : afficher récap. infos saisies dans label 'recap'

            recap.Text = $"{prenom} {nom}, résidant : {adresse}, de sexe {sexe}.";
            recap.Text += $"a pour compétences : {competences}";

            //..stocker user (ds repository)
            Repository.Add(new User(prenom, nom, adresse, rbh.Checked, competences));

            tbPrenom.Text = "";
            tbNom.Text = "";
            tbAdresse.Text = "";

            rbh.Checked = false;
            rbf.Checked = true;

            foreach (var ctrl in grpComps.Controls)
                if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;

            tbPrenom.Focus();

        }
    }
}
