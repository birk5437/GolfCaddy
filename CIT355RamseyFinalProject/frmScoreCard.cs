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
    public partial class frmScoreCard : Form
    {
        int scrollX, scoreImgXpos;
        SolidBrush mBrushText;
        Font fntScoreCard;
        Bitmap bmpScores, bmpNames;
        Graphics scoreGraphics, nameGraphics;
        Pen pen1, pen2;

        List<clsPlayer> lstPlayers;

        Rectangle mSourceRect;
        Rectangle mDestRect;

        int[] pars;

        int[] playerScore;

        string[] playerNames;

        int rowSize = 25;
        int columnSize = 25;

        public frmScoreCard(List<clsPlayer> players)
        {
            lstPlayers = players;

            //playerNames = players;

            //readCourseFile(courseFile);

            //playerScore = player1Score;

            InitializeComponent();
        }

        private void readCourseFile(string fileName)
        {
            String[] strCourseFileContents;
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

        private void drawOffScreen()
        {
            int playerNameToDraw = 0;
            for (int i = 0; i < (rowSize * 9); i += rowSize)
            {
                scoreGraphics.DrawLine(pen1, 0, i, columnSize * 21, i);

                nameGraphics.DrawLine(pen2, 0, i, 75, i);

                if (i >= (rowSize * 3))
                {
                    if (playerNameToDraw < lstPlayers.Count)
                    {
                        nameGraphics.DrawString(lstPlayers[playerNameToDraw].name, fntScoreCard, mBrushText, 5, i + 5);

                        for (int j = 0; j < lstPlayers[playerNameToDraw].score.Length; j++)
                        {
                            if (lstPlayers[playerNameToDraw].score[j] != 0)
                            {
                                scoreGraphics.DrawString(lstPlayers[playerNameToDraw].score[j].ToString(), fntScoreCard, mBrushText, (j * columnSize) + 5, i + 5);
                            }
                        }

                        playerNameToDraw++;
                    }
                }
            }

            int holeNumberToDraw = 1;

            for (int i = columnSize; i < (columnSize * 22); i += columnSize)
            {
                scoreGraphics.DrawLine(pen1, i, 0, i, rowSize * 8);

                if ((i / columnSize) == 10)
                {
                    scoreGraphics.DrawString("Out", fntScoreCard, mBrushText, (i - columnSize) + 3, rowSize / 3.5f);
                }
                else
                {
                    if (holeNumberToDraw <= 18)
                    {
                        scoreGraphics.DrawString(holeNumberToDraw.ToString(), fntScoreCard, mBrushText, (i - columnSize) + (columnSize / 3), rowSize / 3.5f);
                        holeNumberToDraw++;
                    }
                    else
                    {
                        if (holeNumberToDraw == 19)
                        {
                            scoreGraphics.DrawString("In", fntScoreCard, mBrushText, (i - columnSize) + 7, rowSize / 3.5f);
                            holeNumberToDraw++;
                        }
                        else if (holeNumberToDraw == 20)
                        {
                            scoreGraphics.DrawString("Tot", fntScoreCard, mBrushText, (i - columnSize) + 3, rowSize / 3.5f);
                            holeNumberToDraw++;
                        }
                    }
                }
            }

            nameGraphics.DrawString("Hole", fntScoreCard, mBrushText, 2, 5);

            /*foreach (string name in playerNames)
            {
                nameGraphics.DrawString("test", fntScoreCard, mBrushText, 2, i + 5);
            }*/


            nameGraphics.DrawLine(pen2, 74, 0, 74, (rowSize * 8));
            //nameGraphics.DrawLine(pen2, 0, bmpNames.Height - 1, bmpScores.Width, bmpNames.Height - 1);

            //scoreGraphics.DrawLine(pen1, 0, bmpScores.Height - 1, bmpScores.Width, bmpScores.Height - 1);

            //offScreenGraphics.DrawLine(pen1, 5, 5, ClientRectangle.Width - 5, 5);
            //offScreenGraphics.DrawLine(pen1, 5, ClientRectangle.Height - 5, ClientRectangle.Width - 5, ClientRectangle.Height - 5);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.Black);
            //e.Graphics.DrawImage(bmpScores, scoreImgXpos, 0);
            e.Graphics.DrawImage(bmpScores, mDestRect, mSourceRect, GraphicsUnit.Pixel);
            e.Graphics.DrawImage(bmpNames, 0, 0);
            //drawOffScreen();
            //e.Graphics.DrawImage(, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void frmScoreCard_Load(object sender, EventArgs e)
        {
            pars = new int[18];

            scrollX = 0;
            scoreImgXpos = 75;

            rowSize = (int)(ClientRectangle.Height / 9);
            pen1 = new Pen(Color.White);
            pen2 = new Pen(Color.Green);

            bmpScores = new Bitmap((columnSize * 23), ClientRectangle.Height);
            scoreGraphics = Graphics.FromImage(bmpScores);

            fntScoreCard = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
            mBrushText = new SolidBrush(Color.White);

            bmpNames = new Bitmap(75, ClientRectangle.Height);
            nameGraphics = Graphics.FromImage(bmpNames);

            mDestRect = new Rectangle();
            mDestRect.Y = 0;
            mDestRect.X = 75;
            mDestRect.Width = (ClientRectangle.Width - 75);
            mDestRect.Height = ClientRectangle.Height;

            mSourceRect = new Rectangle();
            mSourceRect.X = 0;
            mSourceRect.Y = 0;
            mSourceRect.Width = (ClientRectangle.Width - 75);
            mSourceRect.Height = ClientRectangle.Height;


            drawOffScreen();
            Invalidate();
        }

        private void frmScoreCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Close();
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.F2))
            {
                // Soft Key 2
                // Not handled when menu is present.
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                scrollX -= (2 * columnSize);
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                scrollX += (2 * columnSize);
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D1))
            {
                // 1
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D2))
            {
                // 2
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D3))
            {
                // 3
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D4))
            {
                // 4
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D5))
            {
                // 5
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D6))
            {
                // 6
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D7))
            {
                // 7
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D8))
            {
                // 8
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D9))
            {
                // 9
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.F8))
            {
                // *
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D0))
            {
                // 0
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.F9))
            {
                // #
            }

        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            if (scrollX < mSourceRect.X)
            {
                mSourceRect.X -= 5;
                Invalidate();
            }
            else if (scrollX > mSourceRect.X)
            {
                mSourceRect.X += 5;
                Invalidate();
            }
        }
    }
}