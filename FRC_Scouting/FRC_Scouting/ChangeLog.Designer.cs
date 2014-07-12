namespace FRC_Scouting
{
    partial class ChangeLog
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.changelogTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.changelogTextBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 517);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // changelogTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.changelogTextBox, 2);
            this.changelogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changelogTextBox.Location = new System.Drawing.Point(3, 3);
            this.changelogTextBox.Name = "changelogTextBox";
            this.changelogTextBox.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.changelogTextBox, 2);
            this.changelogTextBox.Size = new System.Drawing.Size(733, 511);
            this.changelogTextBox.TabIndex = 0;
            this.changelogTextBox.Text = "";
            // 
            // ChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(741, 573);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ChangeLog";
            this.Text = "Change Log";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox changelogTextBox;
    }
}
