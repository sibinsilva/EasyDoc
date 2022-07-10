namespace EasyDoc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.lstSelection = new System.Windows.Forms.ListView();
            this.btnDown = new MaterialSkin.Controls.MaterialButton();
            this.btnUp = new MaterialSkin.Controls.MaterialButton();
            this.btnMerge = new MaterialSkin.Controls.MaterialButton();
            this.btnSelectTab1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUnlockFile = new MaterialSkin.Controls.MaterialButton();
            this.btnLockFile = new MaterialSkin.Controls.MaterialButton();
            this.btnClearTab2 = new MaterialSkin.Controls.MaterialButton();
            this.lstvEditPdf = new System.Windows.Forms.ListView();
            this.btnSelectTab2 = new MaterialSkin.Controls.MaterialButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.lstSelection);
            this.tabPage1.Controls.Add(this.btnDown);
            this.tabPage1.Controls.Add(this.btnUp);
            this.tabPage1.Controls.Add(this.btnMerge);
            this.tabPage1.Controls.Add(this.btnSelectTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Merge Pdf";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(608, 55);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MaximumSize = new System.Drawing.Size(25, 15);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(25, 15);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "x";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lstSelection
            // 
            this.lstSelection.HideSelection = false;
            this.lstSelection.Location = new System.Drawing.Point(97, 55);
            this.lstSelection.Name = "lstSelection";
            this.lstSelection.Size = new System.Drawing.Size(537, 195);
            this.lstSelection.TabIndex = 11;
            this.lstSelection.UseCompatibleStateImageBehavior = false;
            this.lstSelection.View = System.Windows.Forms.View.List;
            this.lstSelection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSelection_MouseClick);
            // 
            // btnDown
            // 
            this.btnDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDown.Depth = 0;
            this.btnDown.HighEmphasis = true;
            this.btnDown.Icon = null;
            this.btnDown.Location = new System.Drawing.Point(641, 173);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDown.Name = "btnDown";
            this.btnDown.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDown.Size = new System.Drawing.Size(64, 36);
            this.btnDown.TabIndex = 10;
            this.btnDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDown.UseAccentColor = false;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click_1);
            // 
            // btnUp
            // 
            this.btnUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUp.Depth = 0;
            this.btnUp.HighEmphasis = true;
            this.btnUp.Icon = null;
            this.btnUp.Location = new System.Drawing.Point(641, 55);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUp.Name = "btnUp";
            this.btnUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUp.Size = new System.Drawing.Size(64, 36);
            this.btnUp.TabIndex = 9;
            this.btnUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUp.UseAccentColor = false;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click_1);
            // 
            // btnMerge
            // 
            this.btnMerge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMerge.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMerge.Depth = 0;
            this.btnMerge.HighEmphasis = true;
            this.btnMerge.Icon = null;
            this.btnMerge.Location = new System.Drawing.Point(484, 259);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMerge.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMerge.Size = new System.Drawing.Size(112, 36);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "Merge Files";
            this.btnMerge.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMerge.UseAccentColor = false;
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click_1);
            // 
            // btnSelectTab1
            // 
            this.btnSelectTab1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectTab1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectTab1.Depth = 0;
            this.btnSelectTab1.HighEmphasis = true;
            this.btnSelectTab1.Icon = null;
            this.btnSelectTab1.Location = new System.Drawing.Point(97, 259);
            this.btnSelectTab1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectTab1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectTab1.Name = "btnSelectTab1";
            this.btnSelectTab1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectTab1.Size = new System.Drawing.Size(115, 36);
            this.btnSelectTab1.TabIndex = 7;
            this.btnSelectTab1.Text = "Select Files";
            this.btnSelectTab1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectTab1.UseAccentColor = false;
            this.btnSelectTab1.UseVisualStyleBackColor = true;
            this.btnSelectTab1.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUnlockFile);
            this.tabPage2.Controls.Add(this.btnLockFile);
            this.tabPage2.Controls.Add(this.btnClearTab2);
            this.tabPage2.Controls.Add(this.lstvEditPdf);
            this.tabPage2.Controls.Add(this.btnSelectTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Pdf";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUnlockFile
            // 
            this.btnUnlockFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUnlockFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUnlockFile.Depth = 0;
            this.btnUnlockFile.HighEmphasis = true;
            this.btnUnlockFile.Icon = null;
            this.btnUnlockFile.Location = new System.Drawing.Point(618, 157);
            this.btnUnlockFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUnlockFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUnlockFile.Name = "btnUnlockFile";
            this.btnUnlockFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUnlockFile.Size = new System.Drawing.Size(111, 36);
            this.btnUnlockFile.TabIndex = 17;
            this.btnUnlockFile.Text = "Unlock File";
            this.btnUnlockFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUnlockFile.UseAccentColor = false;
            this.btnUnlockFile.UseVisualStyleBackColor = true;
            this.btnUnlockFile.Click += new System.EventHandler(this.btnUnlockFile_Click);
            // 
            // btnLockFile
            // 
            this.btnLockFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLockFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLockFile.Depth = 0;
            this.btnLockFile.HighEmphasis = true;
            this.btnLockFile.Icon = null;
            this.btnLockFile.Location = new System.Drawing.Point(618, 53);
            this.btnLockFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLockFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLockFile.Name = "btnLockFile";
            this.btnLockFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLockFile.Size = new System.Drawing.Size(91, 36);
            this.btnLockFile.TabIndex = 16;
            this.btnLockFile.Text = "Lock File";
            this.btnLockFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLockFile.UseAccentColor = false;
            this.btnLockFile.UseVisualStyleBackColor = true;
            this.btnLockFile.Click += new System.EventHandler(this.btnLockFile_Click);
            // 
            // btnClearTab2
            // 
            this.btnClearTab2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearTab2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearTab2.Depth = 0;
            this.btnClearTab2.HighEmphasis = true;
            this.btnClearTab2.Icon = null;
            this.btnClearTab2.Location = new System.Drawing.Point(574, 40);
            this.btnClearTab2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearTab2.MaximumSize = new System.Drawing.Size(25, 15);
            this.btnClearTab2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearTab2.Name = "btnClearTab2";
            this.btnClearTab2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearTab2.Size = new System.Drawing.Size(25, 15);
            this.btnClearTab2.TabIndex = 15;
            this.btnClearTab2.Text = "x";
            this.btnClearTab2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearTab2.UseAccentColor = false;
            this.btnClearTab2.UseVisualStyleBackColor = true;
            this.btnClearTab2.Click += new System.EventHandler(this.btnClearTab2_Click);
            // 
            // lstvEditPdf
            // 
            this.lstvEditPdf.HideSelection = false;
            this.lstvEditPdf.Location = new System.Drawing.Point(62, 40);
            this.lstvEditPdf.Name = "lstvEditPdf";
            this.lstvEditPdf.Size = new System.Drawing.Size(537, 195);
            this.lstvEditPdf.TabIndex = 14;
            this.lstvEditPdf.UseCompatibleStateImageBehavior = false;
            this.lstvEditPdf.View = System.Windows.Forms.View.List;
            this.lstvEditPdf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstvEditPdf_MouseClick);
            // 
            // btnSelectTab2
            // 
            this.btnSelectTab2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectTab2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectTab2.Depth = 0;
            this.btnSelectTab2.HighEmphasis = true;
            this.btnSelectTab2.Icon = null;
            this.btnSelectTab2.Location = new System.Drawing.Point(62, 244);
            this.btnSelectTab2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectTab2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectTab2.Name = "btnSelectTab2";
            this.btnSelectTab2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectTab2.Size = new System.Drawing.Size(105, 36);
            this.btnSelectTab2.TabIndex = 13;
            this.btnSelectTab2.Text = "Select Pdf";
            this.btnSelectTab2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectTab2.UseAccentColor = false;
            this.btnSelectTab2.UseVisualStyleBackColor = true;
            this.btnSelectTab2.Click += new System.EventHandler(this.btnSelectTab2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.optionToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyDoc";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private System.Windows.Forms.ListView lstSelection;
        private MaterialSkin.Controls.MaterialButton btnDown;
        private MaterialSkin.Controls.MaterialButton btnUp;
        private MaterialSkin.Controls.MaterialButton btnMerge;
        private MaterialSkin.Controls.MaterialButton btnSelectTab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton btnClearTab2;
        private System.Windows.Forms.ListView lstvEditPdf;
        private MaterialSkin.Controls.MaterialButton btnSelectTab2;
        private MaterialSkin.Controls.MaterialButton btnLockFile;
        private MaterialSkin.Controls.MaterialButton btnUnlockFile;
    }
}