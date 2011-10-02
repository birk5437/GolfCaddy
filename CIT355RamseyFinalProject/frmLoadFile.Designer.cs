namespace CIT355RamseyFinalProject
{
    partial class frmLoadFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mnuMain;

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
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.listFiles = new System.Windows.Forms.ListView();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.menuItem1);
            this.mnuMain.MenuItems.Add(this.menuItem2);
            // 
            // listFiles
            // 
            this.listFiles.Location = new System.Drawing.Point(4, 4);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(169, 173);
            this.listFiles.TabIndex = 0;
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Load";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Cancel";
            // 
            // frmLoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.listFiles);
            this.Menu = this.mnuMain;
            this.Name = "frmLoadFile";
            this.Text = "frmLoadFile";
            this.Load += new System.EventHandler(this.frmLoadFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}