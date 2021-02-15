
namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    partial class AboutBox
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
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.AneejianLink = new System.Windows.Forms.LinkLabel();
            this.BmcLink = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.BmcLink, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LogoBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AneejianLink, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(312, 133);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::Aneejian.PowerPoint.Downsizer.AddIn.Properties.Resources.downsizer_100by100;
            this.LogoBox.Location = new System.Drawing.Point(3, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(100, 100);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoBox.TabIndex = 6;
            this.LogoBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelProductName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCompanyName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCopyright, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(109, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelProductName.Location = new System.Drawing.Point(2, 2);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(2);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(161, 13);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "PowerPoint Downsizer Add-In";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCompanyName.Location = new System.Drawing.Point(2, 53);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(52, 45);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "Aneejian";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelVersion.Location = new System.Drawing.Point(2, 19);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(2);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(31, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "1.0.0";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCopyright.Location = new System.Drawing.Point(2, 36);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(2);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(133, 13);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright Aneejian 2021";
            // 
            // AneejianLink
            // 
            this.AneejianLink.AutoSize = true;
            this.AneejianLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AneejianLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AneejianLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AneejianLink.Location = new System.Drawing.Point(3, 106);
            this.AneejianLink.Name = "AneejianLink";
            this.AneejianLink.Size = new System.Drawing.Size(100, 17);
            this.AneejianLink.TabIndex = 7;
            this.AneejianLink.TabStop = true;
            this.AneejianLink.Text = "Visit Aneejian";
            this.AneejianLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AneejianLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AneejianLink_LinkClicked);
            // 
            // BmcLink
            // 
            this.BmcLink.AutoSize = true;
            this.BmcLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BmcLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmcLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BmcLink.Location = new System.Drawing.Point(109, 106);
            this.BmcLink.Name = "BmcLink";
            this.BmcLink.Size = new System.Drawing.Size(200, 17);
            this.BmcLink.TabIndex = 9;
            this.BmcLink.TabStop = true;
            this.BmcLink.Text = "Buy a Coffee!";
            this.BmcLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BmcLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BmcLink_LinkClicked);
            // 
            // AboutBox
            // 
            this.AcceptButton = this.AneejianLink;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.AneejianLink;
            this.ClientSize = new System.Drawing.Size(633, 425);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.TopMost = true;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.LinkLabel AneejianLink;
        private System.Windows.Forms.LinkLabel BmcLink;
    }
}