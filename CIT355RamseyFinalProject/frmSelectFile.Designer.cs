namespace CIT355RamseyFinalProject
{
    partial class frmSelectFile
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
            this.mnuItmSelect = new System.Windows.Forms.MenuItem();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.lblTop = new System.Windows.Forms.Label();
            this.cmbStates = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuItmSelect);
            // 
            // mnuItmSelect
            // 
            this.mnuItmSelect.Text = "Get Files";
            this.mnuItmSelect.Click += new System.EventHandler(this.mnuItmSelect_Click);
            // 
            // lvwMain
            // 
            this.lvwMain.Location = new System.Drawing.Point(4, 32);
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(169, 88);
            this.lvwMain.TabIndex = 0;
            this.lvwMain.View = System.Windows.Forms.View.List;
            this.lvwMain.SelectedIndexChanged += new System.EventHandler(this.lvwMain_SelectedIndexChanged);
            // 
            // lblTop
            // 
            this.lblTop.Location = new System.Drawing.Point(4, 4);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(84, 22);
            this.lblTop.Text = "Select A State:";
            // 
            // cmbStates
            // 
            this.cmbStates.Location = new System.Drawing.Point(95, 4);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(78, 22);
            this.cmbStates.TabIndex = 2;
            this.cmbStates.SelectedIndexChanged += new System.EventHandler(this.cmbStates_SelectedIndexChanged);
            // 
            // frmSelectFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(176, 180);
            this.Controls.Add(this.cmbStates);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lvwMain);
            this.KeyPreview = true;
            this.Menu = this.mnuMain;
            this.Name = "frmSelectFile";
            this.Text = "frmSelectFile";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSelectFile_KeyDown);
            this.Load += new System.EventHandler(this.frmSelectFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwMain;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.MenuItem mnuItmSelect;
        private System.Windows.Forms.ComboBox cmbStates;
    }
}