using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Region20WinForms
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();

            BackgroundImage = Image.FromFile(@"Resources\csharp.png");

            //définir gestionnaire d'evenements (gestion d'un event) par code
            this.Click += GestionClickFenetre;

            //gestion menu : events
            exitToolStripMenuItem.Click += MenuExit_Click;
            tsMenuExit.Click += MenuExit_Click;

            menuNewUser.Click += OpenFormFromMenu;
            menuOpenCombo.Click += OpenFormFromMenu;
            menuOpenGrid.Click += OpenFormFromMenu;
        }

        private void OpenFormFromMenu(object sender, EventArgs e)
        {

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Name.Equals("menuNewUser"))
            {
                this.Visible = false;
                new Fiche("Add", this).Show();
            }   
            else if (item.Name.Equals("menuOpenCombo"))
            {
                this.Visible = false;
                new Liste("Liste", this).Show();
            }
            else if (item.Name.Equals("menuOpenGrid"))
            {
                this.Visible = false;
                new Grille("Grille", this).Show();
            }


            //tests.ShowDialog(); //afficher comme b. dialogue (modale!)
            //this.Visible = true;
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Gestionnaires Evenements!
         */
        private void GestionClickFenetre(object sender, EventArgs e) => this.BackColor = Color.BurlyWood;
        private void FenetrePrincipale_Load(object sender, EventArgs e) => this.BackColor = Color.WhiteSmoke;
        private void FenetrePrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Gestionnaire Evenmt : fermeture de la fenêtre courante!
            //confirmation fermeture!
            DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir quitter?", "Exit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
