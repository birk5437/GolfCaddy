namespace CIT355RamseyFinalProject
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHoleNumber = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer3 = new System.Windows.Forms.TextBox();
            this.txtPlayer4 = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuItmMain = new System.Windows.Forms.MenuItem();
            this.mnuItmNext = new System.Windows.Forms.MenuItem();
            this.mnuItmScorecard = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // lblHoleNumber
            // 
            this.lblHoleNumber.Location = new System.Drawing.Point(4, 4);
            this.lblHoleNumber.Name = "lblHoleNumber";
            this.lblHoleNumber.Size = new System.Drawing.Size(86, 22);
            this.lblHoleNumber.Text = "Hole #1";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(96, 28);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(34, 22);
            this.txtPlayer1.TabIndex = 1;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Location = new System.Drawing.Point(4, 28);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(53, 22);
            this.lblPlayer1.Text = "Player 1:";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(96, 56);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(34, 22);
            this.txtPlayer2.TabIndex = 3;
            // 
            // txtPlayer3
            // 
            this.txtPlayer3.Location = new System.Drawing.Point(96, 84);
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.Size = new System.Drawing.Size(34, 22);
            this.txtPlayer3.TabIndex = 4;
            // 
            // txtPlayer4
            // 
            this.txtPlayer4.Location = new System.Drawing.Point(96, 112);
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.Size = new System.Drawing.Size(34, 22);
            this.txtPlayer4.TabIndex = 5;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Location = new System.Drawing.Point(3, 56);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(54, 22);
            this.lblPlayer2.Text = "Player 2:";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.Location = new System.Drawing.Point(3, 84);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(54, 22);
            this.lblPlayer3.Text = "Player 3:";
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.Location = new System.Drawing.Point(4, 112);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(53, 22);
            this.lblPlayer4.Text = "Player 4:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.Text = "Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuItmMain);
            this.mnuMain.MenuItems.Add(this.mnuItmNext);
            // 
            // mnuItmMain
            // 
            this.mnuItmMain.MenuItems.Add(this.mnuItmScorecard);
            this.mnuItmMain.MenuItems.Add(this.menuItem3);
            this.mnuItmMain.Text = "Menu";
            // 
            // mnuItmNext
            // 
            this.mnuItmNext.Text = "Next Hole";
            this.mnuItmNext.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // mnuItmScorecard
            // 
            this.mnuItmScorecard.Text = "View Scorecard";
            this.mnuItmScorecard.Click += new System.EventHandler(this.mnuItmScorecard_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "View Map";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtPlayer4);
            this.Controls.Add(this.txtPlayer3);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblHoleNumber);
            this.Menu = this.mnuMain;
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHoleNumber;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer3;
        private System.Windows.Forms.TextBox txtPlayer4;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuItmMain;
        private System.Windows.Forms.MenuItem mnuItmScorecard;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuItmNext;
    }
}