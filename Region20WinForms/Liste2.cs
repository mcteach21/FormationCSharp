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
    public partial class Liste2 : Form
    {
        public Liste2(string title = "Tests", Form caller_form = null)
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

        private void Liste2_Load(object sender, EventArgs e)
        {
            //grid.DataSource = Repository.list();
            //grid.AllowUserToAddRows = true;           

            populateGrid();
            formatGrid();
            handleGridEvents();


            toolStripMenuExit.Click += ToolStripMenuExit_Click;
        }

        private void ToolStripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void populateGrid()
        {
            var items = Repository.list();

            var source = new BindingSource();
            source.DataSource = items;
            grid.DataSource = source;

        }
        private void formatGrid()
        {
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
        }

        private void handleGridEvents()
        {
            grid.CellEndEdit += Grid_CellEndEdit;

            grid.UserDeletingRow += Grid_UserDeletingRow;
            grid.UserAddedRow += Grid_UserAddedRow;

            grid.RowsRemoved += Grid_RowsRemoved;
        }

        private void Grid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            infos.Text = $"Row added : {e.Row.Index}";
        }

        private void Grid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = MessageBox.Show("Really?", "Delete!", MessageBoxButtons.OKCancel) != DialogResult.OK;

        }
        private void Grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            infos.Text = $"Row Removed : {e.RowIndex}";
            grid.CancelEdit();
        }

        private void Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            infos.Text = $"Cell Edit : {e.RowIndex}x{e.ColumnIndex} : {grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
