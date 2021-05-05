using Region20WinForms.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Region20WinForms
{
    public partial class Liste : Form
    {
        public Liste(string title = "Tests", Form caller_form = null)
        {
            InitializeComponent();

            //initialiser liste users (combo)
            List<User> items = Repository.list();
            cbUsers.Items.Clear();
            cbUsers.Items.AddRange(items.ToArray()); //remplir combo avec liste de 'users'
                                                     //code suite..
            this.caller_form = caller_form; // recup. fen. appelante eventuelle!

            this.Text = title;
            this.FormClosed += Tests_FormClosed;
        }
        private Form caller_form;

        private void Tests_FormClosed(object sender, FormClosedEventArgs e)
        {
            //rendre visible fenêtre appelante!
            if (this.caller_form != null)
                this.caller_form.Visible = true; //..rendre fen. appelante visible!
        }

        private void Liste_Load(object sender, EventArgs e)
        {
            picture.Load(@"Resources\none.png");
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsers.SelectedItem != null)
            {
                User user = (User)cbUsers.SelectedItem;

                //afficher image dans PictureBox
                picture.Load(user.Homme ? @"Resources\homme.png" : @"Resources\femme.png");

                string retour_ligne = "\r\n";

                infos.Text = user.Adresse + retour_ligne;
                infos.Text += retour_ligne+"Compétences : ";
                foreach (var item in user.Competences)
                    infos.Text += retour_ligne + item;

                infos.Parent.BackColor = Color.Black;
                infos.BackColor = Color.Black;
            }

        }
    }
}
