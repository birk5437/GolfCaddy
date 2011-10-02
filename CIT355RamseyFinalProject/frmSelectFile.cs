using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace CIT355RamseyFinalProject
{
    public partial class frmSelectFile : Form
    {
        public string strServer = @"http://web.ics.purdue.edu/~bhramsey/ramseyGolf/";
        public frmSelectFile()
        {
            InitializeComponent();
        }

        private string getResponse(string strServer)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;

            StreamReader sr = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(@strServer);
                response = (HttpWebResponse)request.GetResponse();

                sr = new StreamReader(response.GetResponseStream());

                String responseString = sr.ReadToEnd();

                response.Close();
                sr.Close();

                return responseString;
            }
            catch (Exception ex)
            {
                if (response != null)
                {
                    response.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                }

                MessageBox.Show(ex.Message);
                return "error";
            }
        }

        private void getStates()
        {
            Cursor.Current = Cursors.WaitCursor;

            string responseStr = "";
            responseStr = getResponse(strServer + "states.html");

            string[] states = responseStr.Split('^');

            for (int i = 0; i < states.Length; i++)
            {
                //ListViewItem itm1 = new ListViewItem();
                //itm1.Text = states[i];
                cmbStates.Items.Add(states[i]);
                //lvwMain.Items.Add(itm1);
            }

            Cursor.Current = Cursors.Default;
        }

        private void getFiles(string state)
        {
            Cursor.Current = Cursors.WaitCursor;

            string responseStr = "";
            responseStr = getResponse(strServer + state + "/" + state + ".html");

            string[] files;

            files = responseStr.Split('^');

            lvwMain.Items.Clear();

            for (int i = 0; i < files.Length; i++)
            {
                ListViewItem itm1 = new ListViewItem();
                itm1.Text = files[i];
                lvwMain.Items.Add(itm1);
            }

            Cursor.Current = Cursors.Default;
        }

        private void saveFile(string file)
        {

        }

        private void frmSelectFile_Load(object sender, EventArgs e)
        {
            getStates();
            cmbStates.Focus();
        }

        private void mnuItmSelect_Click(object sender, EventArgs e)
        {
            string strSelectedState = "";

            if (mnuItmSelect.Text == "Get Files")
            {

                strSelectedState = (string)cmbStates.SelectedItem;

                getFiles(strSelectedState);
            }
            else if (mnuItmSelect.Text == "Download")
            {
                string selectedState = (string)cmbStates.SelectedItem;
                string selectedFile = lvwMain.FocusedItem.Text;
                string path = Program.getMyDocsPath() + @"\Golf Courses\" + selectedFile;

                if (Directory.Exists(Program.getMyDocsPath() + @"\Golf Courses\") == false)
                {
                    Directory.CreateDirectory(Program.getMyDocsPath() + @"\Golf Courses\");
                }

                StreamWriter sw = new StreamWriter(path);

                sw.Write(getResponse(strServer + selectedState + @"/" + selectedFile));

                sw.Close();
            }
        }

        private void frmSelectFile_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (cmbStates.Focused == false)
                    {
                        cmbStates.Focus();
                    }
                    break;

                case Keys.Right:
                    if (cmbStates.Focused == false)
                    {
                        cmbStates.Focus();
                    }
                    break;
            }
        }

        private void lvwMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuItmSelect.Text = "Download";
        }

        private void cmbStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuItmSelect.Text = "Get Files";
        }
    }
}