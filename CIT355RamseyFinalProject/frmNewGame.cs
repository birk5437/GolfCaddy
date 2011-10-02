using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIT355RamseyFinalProject
{
    public partial class frmNewGame : Form
    {
        string strCourseFile = null;

        List<clsPlayer> players;

        public frmNewGame(string courseFile)
        {
            players = new List<clsPlayer>();
            strCourseFile = courseFile;
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != "")
            {
                players.Add(new clsPlayer(txtPlayer1.Text));

                if (txtPlayer2.Text != "")
                {
                    players.Add(new clsPlayer(txtPlayer2.Text));
                }

                if (txtPlayer3.Text != "")
                {
                    players.Add(new clsPlayer(txtPlayer3.Text));
                }

                if (txtPlayer4.Text != "")
                {
                    players.Add(new clsPlayer(txtPlayer4.Text));
                }
            }
            else
            {
                MessageBox.Show("Must enter a name for player 1.");
            }

            frmGame game = new frmGame(players, strCourseFile);
            game.ShowDialog();
        }
    }
}