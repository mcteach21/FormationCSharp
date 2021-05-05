using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Region20WinForms
{
    public partial class BaseForm : Form
    {
        private Form caller_form;

        public BaseForm()
        {
            InitializeComponent();
        }
        public BaseForm(string title = "Tests", Form caller_form = null)
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
    }
}
