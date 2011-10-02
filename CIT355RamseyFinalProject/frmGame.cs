using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace CIT355RamseyFinalProject
{
    public partial class frmGame : Form
    {
        int[] pars;

        List<clsPlayer> lstPlayers;
        List<Label> lstPlayerLabels;
        List<TextBox> lstPlayerTexts;

        String[] strCourseFileContents;

        string courseFileName;

        int holeNumber;

        public frmGame(List<clsPlayer> players, string courseFile)
        {
            InitializeComponent();

            lstPlayerLabels = new List<Label>();
            lstPlayerTexts = new List<TextBox>();

            lstPlayerLabels.Add(lblPlayer1);
            lstPlayerLabels.Add(lblPlayer2);
            lstPlayerLabels.Add(lblPlayer3);
            lstPlayerLabels.Add(lblPlayer4);

            lstPlayerTexts.Add(txtPlayer1);
            lstPlayerTexts.Add(txtPlayer2);
            lstPlayerTexts.Add(txtPlayer3);
            lstPlayerTexts.Add(txtPlayer4);

            lstPlayers = players;

            for (int i = 0; i < lstPlayers.Count; i++)
            {
                lstPlayerLabels[i].Text = lstPlayers[i].name;
            }

            courseFileName = courseFile;

            readCourseFile(courseFileName);

            holeNumber = 1;

            lblHoleNumber.Text = "Hole #" + holeNumber.ToString() + " (Par " + pars[holeNumber - 1] + ")";
            //player1Score = new int[18];
        }

        private void readCourseFile(string fileName)
        {
            pars = new int[18];
            //lstCourseFile = new List<string>();
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();
            strCourseFileContents = line.Split(',');
            //textBox5.Text = strCourseFile[0];

            for (int i = 1; i <= 18; i++)
            {
                pars[i - 1] = int.Parse(strCourseFileContents[i]);
            }

        }

        private int calculateScore(int[] playerScores)
        {
            int score = 0;
            for (int i = 0; i < playerScores.Length; i++)
            {
                score += playerScores[i];
            }

            return score;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lstPlayers.Count; i++)
                {
                    lstPlayers[i].score[holeNumber - 1] = int.Parse(lstPlayerTexts[i].Text);
                }
            }
            catch
            {
                MessageBox.Show("Score must be a whole number.");
                return;
            }

            foreach (TextBox t in lstPlayerTexts)
            {
                t.Text = "";
            }

            if (holeNumber == 17)
            {
                mnuItmNext.Text = "Finish Round";
                holeNumber++;
            }
            else
            {
                if (holeNumber == 18)
                {

                    lblHoleNumber.Text = "Final Scores:";

                    /*int score = 0;

                    for (int i = 0; i < player1Score.Length; i++)
                    {
                        score += player1Score[i];
                    }

                    txtPlayer1.Text = score.ToString();*/
                    mnuItmNext.Text = "Done";

                }
                else if (holeNumber == 18 && lblHoleNumber.Text == "Final Scores:")
                {
                    mnuItmNext.Text = "Done";
                }
                else
                {
                    holeNumber++;
                }
            }

            lblHoleNumber.Text = "Hole #" + holeNumber.ToString() + " (Par " + pars[holeNumber - 1] + ")";
        }

        private void mnuItmScorecard_Click(object sender, EventArgs e)
        {
            frmScoreCard scorecard = new frmScoreCard(lstPlayers);
            scorecard.ShowDialog();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            frmMap map = new frmMap();
            map.ShowDialog();
        }
    }
}