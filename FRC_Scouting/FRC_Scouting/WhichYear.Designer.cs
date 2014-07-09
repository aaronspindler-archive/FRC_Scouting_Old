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
            this.programInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(887, 184);
            this.tableLayout.TabIndex = 0;
            // 
            // whichYearComboBox
            // 
            this.tableLayout.SetColumnSpan(this.whichYearComboBox, 8);
            this.whichYearComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whichYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whichYearComboBox.FormattingEnabled = true;
            this.whichYearComboBox.Location = new System.Drawing.Point(3, 95);
            this.whichYearComboBox.Name = "whichYearComboBox";
            this.whichYearComboBox.Size = new System.Drawing.Size(881, 33);
            this.whichYearComboBox.TabIndex = 1;
            this.whichYearComboBox.SelectedIndexChanged += new System.EventHandler(this.whichYearComboBox_SelectedIndexChanged);
            // 
            // whichYearInformationLabel
            // 
            this.whichYearInformationLabel.AutoSize = true;
            this.tableLayout.SetColumnSpan(this.whichYearInformationLabel, 8);
            this.whichYearInformationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whichYearInformationLabel.Location = new System.Drawing.Point(3, 46);
            this.whichYearInformationLabel.Name = "whichYearInformationLabel";
            this.whichYearInformationLabel.Size = new System.Drawing.Size(881, 46);
            this.whichYearInformationLabel.TabIndex = 1;
            this.whichYearInformationLabel.Text = "Use this form to select which year\'s scouting application you would like to open." +
    "\r\n";
            this.whichYearInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmSelectionButton
            // 
            this.tableLayout.SetColumnSpan(this.confirmSelectionButton, 4);
            this.confirmSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmSelectionButton.Location = new System.Drawing.Point(223, 141);
            this.confirmSelectionButton.Name = "confirmSelectionButton";
            this.confirmSelectionButton.Size = new System.Drawing.Size(434, 40);
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
            this.programInformationToolStripMenuItem,
            this.licenseInformationToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(887, 46);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 42);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // programInformationToolStripMenuItem
            // 
            this.programInformationToolStripMenuItem.Name = "programInformationToolStripMenuItem";
            this.programInformationToolStripMenuItem.Size = new System.Drawing.Size(249, 42);
            this.programInformationToolStripMenuItem.Text = "Program Information";
            this.programInformationToolStripMenuItem.Click += new System.EventHandler(this.programInformationToolStripMenuItem_Click);
            // 
            // licenseInformationToolStripMenuItem
            // 
            this.licenseInformationToolStripMenuItem.Name = "licenseInformationToolStripMenuItem";
            this.licenseInformationToolStripMenuItem.Size = new System.Drawing.Size(237, 42);
            this.licenseInformationToolStripMenuItem.Text = "License Information";
            this.licenseInformationToolStripMenuItem.Click += new System.EventHandler(this.licenseInformationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 42);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // WhichYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 184);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "WhichYear";
            this.Text = "FRC Scouting w/ Reporting Application";
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
        private System.Windows.Forms.ToolStripMenuItem programInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInformationToolStripMenuItem;
    }
}