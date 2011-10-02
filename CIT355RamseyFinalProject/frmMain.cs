using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIT355RamseyFinalProject
{
    public partial class frmMain : Form
    {

        string strCourseSelected = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            frmNewGame newGame = new frmNewGame(strCourseSelected);
            newGame.ShowDialog();
        }

        private void mnuItmLoad_Click(object sender, EventArgs e)
        {
            frmLoadFile load = new frmLoadFile();
            load.ShowDialog();

            textBox1.Text = load.getSelectedFile();
            strCourseSelected = load.getSelectedFile();
        }

        private void mnuItmSelectCourseFile_Click(object sender, EventArgs e)
        {
            frmSelectFile frmSelect = new frmSelectFile();
            frmSelect.ShowDialog();
        }


    }
}