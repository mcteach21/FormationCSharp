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
    public partial class Grille : Form
    {
        public Grille(string title = "Tests", Form caller_form = null)
        {
            InitializeComponent();

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

        private void Grille_Load(object sender, EventArgs e)
        {
            InitDataGrid();
        }

        private void InitDataGrid()
        {
            //remplir le datagridview 'grid'
            List<User> items = Repository.list();

            var source = new BindingSource();
            source.DataSource = items;
            grid.DataSource = source;

            //paramétrer comportment grille (ajout, suppr...)
            grid.AllowUserToAddRows = false;    //interdire saisie nouvel item dans grille
            // grid.AllowUserToDeleteRows = false;

            /**
             * formatage grille (visuel)
             */

            grid.RowsDefaultCellStyle.BackColor = Color.Bisque;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[0].Width = 50;

            grid.AutoResizeColumns();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            grid.DefaultCellStyle.SelectionBackColor = Color.Black;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid.Columns[0].ReadOnly = true;


            /**
             * Gestion Evenements Grille 
             */
            grid.UserDeletingRow += Grid_UserDeletingRow;

            grid.CellBeginEdit += Grid_CellBeginEdit;
            grid.CellEndEdit += Grid_CellEndEdit;
        }

        private void Grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            infos.Text = $"Cellule (Begin Edit) : {e.RowIndex}x{e.ColumnIndex} => {value}.";
        }

        private void Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var value = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            infos.Text = $"Cellule (End Edit) : {e.RowIndex}x{e.ColumnIndex} => {value}.";
        }

        private void Grid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var response = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette ligne?",
                "Suppression!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.No)
                e.Cancel = true;
        }
    }
}
