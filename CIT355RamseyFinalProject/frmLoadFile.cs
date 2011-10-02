using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CIT355RamseyFinalProject
{
    public partial class frmLoadFile : Form
    {
        List<string> mFiles;
        string selectedFile = null;

        public frmLoadFile()
        {
            mFiles = new List<string>();
            InitializeComponent();
        }

        private void getFiles(string rootFolder)
        {
            foreach (string file in Directory.GetFiles(rootFolder))
            {
                if (file.EndsWith(".golf"))
                {
                    mFiles.Add(file);
                }
            }

            List<string> folders = new List<string>();

            foreach (string folder in Directory.GetDirectories(rootFolder))
            {
                folders.Add(folder);
            }

            foreach (string folder in folders)
            {
                getFiles(folder);
            }
        }


        private void frmLoadFile_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string strDirectory = Program.getMyDocsPath();

            getFiles(strDirectory);

            foreach (string file in mFiles)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = file;
                listFiles.Items.Add(item1);
            }

            Cursor.Current = Cursors.Default;
        }

        public string getSelectedFile()
        {
            return selectedFile;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                selectedFile = listFiles.FocusedItem.Text;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}