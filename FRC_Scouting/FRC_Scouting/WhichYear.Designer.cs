namespace FRC_Scouting
{
    partial class WhichYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhichYear));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.whichYearComboBox = new System.Windows.Forms.ComboBox();
            this.whichYearInformationLabel = new System.Windows.Forms.Label();
            this.confirmSelectionButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayout.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 8;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayout.Controls.Add(this.whichYearComboBox, 0, 2);
            this.tableLayout.Controls.Add(this.whichYearInformationLabel, 0, 1);
            this.tableLayout.Controls.Add(this.confirmSelectionButton, 2, 3);
            this.tableLayout.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayout.Size = new System.Drawing.Size(444, 96);
            this.tableLayout.TabIndex = 0;
            // 
            // whichYearComboBox
            // 
            this.tableLayout.SetColumnSpan(this.whichYearComboBox, 8);
            this.whichYearComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whichYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whichYearComboBox.FormattingEnabled = true;
            this.whichYearComboBox.Location = new System.Drawing.Point(2, 50);
            this.whichYearComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.whichYearComboBox.Name = "whichYearComboBox";
            this.whichYearComboBox.Size = new System.Drawing.Size(440, 21);
            this.whichYearComboBox.TabIndex = 1;
            this.whichYearComboBox.SelectedIndexChanged += new System.EventHandler(this.whichYearComboBox_SelectedIndexChanged);
            // 
            // whichYearInformationLabel
            // 
            this.whichYearInformationLabel.AutoSize = true;
            this.tableLayout.SetColumnSpan(this.whichYearInformationLabel, 8);
            this.whichYearInformationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whichYearInformationLabel.Location = new System.Drawing.Point(2, 24);
            this.whichYearInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whichYearInformationLabel.Name = "whichYearInformationLabel";
            this.whichYearInformationLabel.Size = new System.Drawing.Size(440, 24);
            this.whichYearInformationLabel.TabIndex = 1;
            this.whichYearInformationLabel.Text = "Use this form to select which year\'s scouting application you would like to open." +
    "\r\n";
            this.whichYearInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmSelectionButton
            // 
            this.tableLayout.SetColumnSpan(this.confirmSelectionButton, 4);
            this.confirmSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmSelectionButton.Location = new System.Drawing.Point(112, 74);
            this.confirmSelectionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmSelectionButton.Name = "confirmSelectionButton";
            this.confirmSelectionButton.Size = new System.Drawing.Size(216, 20);
            this.confirmSelectionButton.TabIndex = 2;
            this.confirmSelectionButton.Text = "Confirm Selection";
            this.confirmSelectionButton.UseVisualStyleBackColor = true;
            this.confirmSelectionButton.Click += new System.EventHandler(this.confirmSelectionButton_Click);
            // 
            // menuStrip
            // 
            this.tableLayout.SetColumnSpan(this.menuStrip, 8);
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.teamDirectoryToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(444, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changelogToolStripMenuItem,
            this.licenseToolStripMenuItem,
            this.programInformationToolStripMenuItem1});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // programInformationToolStripMenuItem1
            // 
            this.programInformationToolStripMenuItem1.Name = "programInformationToolStripMenuItem1";
            this.programInformationToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.programInformationToolStripMenuItem1.Text = "Program Information";
            this.programInformationToolStripMenuItem1.Click += new System.EventHandler(this.programInformationToolStripMenuItem1_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllSettingsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // resetAllSettingsToolStripMenuItem
            // 
            this.resetAllSettingsToolStripMenuItem.Name = "resetAllSettingsToolStripMenuItem";
            this.resetAllSettingsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetAllSettingsToolStripMenuItem.Text = "Reset all Settings";
            this.resetAllSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetAllSettingsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // teamDirectoryToolStripMenuItem
            // 
            this.teamDirectoryToolStripMenuItem.Name = "teamDirectoryToolStripMenuItem";
            this.teamDirectoryToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.teamDirectoryToolStripMenuItem.Text = "Team Directory";
            this.teamDirectoryToolStripMenuItem.Click += new System.EventHandler(this.teamDirectoryToolStripMenuItem_Click);
            // 
            // WhichYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 96);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "WhichYear";
            this.Text = "FRC Scouting by xNovax";
            this.Load += new System.EventHandler(this.WhichYear_Load);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label whichYearInformationLabel;
        private System.Windows.Forms.ComboBox whichYearComboBox;
        private System.Windows.Forms.Button confirmSelectionButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamDirectoryToolStripMenuItem;
    }
}