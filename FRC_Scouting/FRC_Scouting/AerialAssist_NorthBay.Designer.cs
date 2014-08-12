namespace FRC_Scouting
{
    partial class AerialAssist_NorthBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AerialAssist_NorthBay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamSelector = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.scoutingTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.generalTeamInformationTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameDisplay = new System.Windows.Forms.Label();
            this.teamNumberLabel = new System.Windows.Forms.Label();
            this.teamNumberDisplay = new System.Windows.Forms.Label();
            this.teamLocationLabel = new System.Windows.Forms.Label();
            this.teamLocationDisplay = new System.Windows.Forms.Label();
            this.eventInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.scoutingTab.SuspendLayout();
            this.generalTeamInformationTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.teamSelector, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 4);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eventInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(196, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // teamSelector
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.teamSelector, 4);
            this.teamSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamSelector.FormattingEnabled = true;
            this.teamSelector.Location = new System.Drawing.Point(199, 3);
            this.teamSelector.Name = "teamSelector";
            this.teamSelector.Size = new System.Drawing.Size(190, 21);
            this.teamSelector.TabIndex = 1;
            this.teamSelector.SelectedIndexChanged += new System.EventHandler(this.teamSelector_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 8);
            this.tabControl1.Controls.Add(this.scoutingTab);
            this.tabControl1.Controls.Add(this.generalTeamInformationTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl1, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 282);
            this.tabControl1.TabIndex = 2;
            // 
            // scoutingTab
            // 
            this.scoutingTab.Controls.Add(this.tableLayoutPanel2);
            this.scoutingTab.Location = new System.Drawing.Point(4, 22);
            this.scoutingTab.Name = "scoutingTab";
            this.scoutingTab.Padding = new System.Windows.Forms.Padding(3);
            this.scoutingTab.Size = new System.Drawing.Size(378, 256);
            this.scoutingTab.TabIndex = 0;
            this.scoutingTab.Text = "Scouting Tab";
            this.scoutingTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 250);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // generalTeamInformationTab
            // 
            this.generalTeamInformationTab.Controls.Add(this.tableLayoutPanel3);
            this.generalTeamInformationTab.Location = new System.Drawing.Point(4, 22);
            this.generalTeamInformationTab.Name = "generalTeamInformationTab";
            this.generalTeamInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTeamInformationTab.Size = new System.Drawing.Size(378, 256);
            this.generalTeamInformationTab.TabIndex = 1;
            this.generalTeamInformationTab.Text = "General Team Information";
            this.generalTeamInformationTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Controls.Add(this.teamNameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.teamNameDisplay, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.teamNumberLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.teamNumberDisplay, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.teamLocationLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.teamLocationDisplay, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 250);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.teamNameLabel, 2);
            this.teamNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamNameLabel.Location = new System.Drawing.Point(3, 0);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(86, 31);
            this.teamNameLabel.TabIndex = 1;
            this.teamNameLabel.Text = "Team Name :";
            this.teamNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamNameDisplay
            // 
            this.teamNameDisplay.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.teamNameDisplay, 6);
            this.teamNameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamNameDisplay.Location = new System.Drawing.Point(95, 0);
            this.teamNameDisplay.Name = "teamNameDisplay";
            this.teamNameDisplay.Size = new System.Drawing.Size(274, 31);
            this.teamNameDisplay.TabIndex = 2;
            this.teamNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamNumberLabel
            // 
            this.teamNumberLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.teamNumberLabel, 2);
            this.teamNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamNumberLabel.Location = new System.Drawing.Point(3, 31);
            this.teamNumberLabel.Name = "teamNumberLabel";
            this.teamNumberLabel.Size = new System.Drawing.Size(86, 31);
            this.teamNumberLabel.TabIndex = 3;
            this.teamNumberLabel.Text = "Team Number :";
            this.teamNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamNumberDisplay
            // 
            this.teamNumberDisplay.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.teamNumberDisplay, 6);
            this.teamNumberDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamNumberDisplay.Location = new System.Drawing.Point(95, 31);
            this.teamNumberDisplay.Name = "teamNumberDisplay";
            this.teamNumberDisplay.Size = new System.Drawing.Size(274, 31);
            this.teamNumberDisplay.TabIndex = 4;
            this.teamNumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamLocationLabel
            // 
            this.teamLocationLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.teamLocationLabel, 2);
            this.teamLocationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamLocationLabel.Location = new System.Drawing.Point(3, 62);
            this.teamLocationLabel.Name = "teamLocationLabel";
            this.teamLocationLabel.Size = new System.Drawing.Size(86, 31);
            this.teamLocationLabel.TabIndex = 5;
            this.teamLocationLabel.Text = "Team Location :";
            this.teamLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamLocationDisplay
            // 
            this.teamLocationDisplay.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.teamLocationDisplay, 6);
            this.teamLocationDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamLocationDisplay.Location = new System.Drawing.Point(95, 62);
            this.teamLocationDisplay.Name = "teamLocationDisplay";
            this.teamLocationDisplay.Size = new System.Drawing.Size(274, 31);
            this.teamLocationDisplay.TabIndex = 6;
            this.teamLocationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventInformationToolStripMenuItem
            // 
            this.eventInformationToolStripMenuItem.Name = "eventInformationToolStripMenuItem";
            this.eventInformationToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.eventInformationToolStripMenuItem.Text = "Event Information";
            // 
            // AerialAssist_NorthBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AerialAssist_NorthBay";
            this.Text = "AerialAssist | Northbay | 2014";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AerialAssist_Nipissing_FormClosing);
            this.Load += new System.EventHandler(this.AerialAssist_Nipissing_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.scoutingTab.ResumeLayout(false);
            this.generalTeamInformationTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox teamSelector;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage scoutingTab;
        private System.Windows.Forms.TabPage generalTeamInformationTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label teamNameDisplay;
        private System.Windows.Forms.Label teamNumberLabel;
        private System.Windows.Forms.Label teamNumberDisplay;
        private System.Windows.Forms.Label teamLocationLabel;
        private System.Windows.Forms.Label teamLocationDisplay;
        private System.Windows.Forms.ToolStripMenuItem eventInformationToolStripMenuItem;
    }
}