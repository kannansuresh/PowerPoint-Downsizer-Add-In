
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.AneejianLink = new System.Windows.Forms.LinkLabel();
            this.BmcLink = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.LogoBox);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 156);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoBox.Image = global::Aneejian.PowerPoint.Downsizer.AddIn.Properties.Resources.banner;
            this.LogoBox.Location = new System.Drawing.Point(3, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(100, 150);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 9;
            this.LogoBox.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.labelProductName);
            this.flowLayoutPanel2.Controls.Add(this.labelVersion);
            this.flowLayoutPanel2.Controls.Add(this.labelCopyright);
            this.flowLayoutPanel2.Controls.Add(this.labelCompanyName);
            this.flowLayoutPanel2.Controls.Add(this.AneejianLink);
            this.flowLayoutPanel2.Controls.Add(this.BmcLink);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(109, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(165, 102);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(1, 1);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(1);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Padding = new System.Windows.Forms.Padding(1);
            this.labelProductName.Size = new System.Drawing.Size(163, 15);
            this.labelProductName.TabIndex = 27;
            this.labelProductName.Text = "PowerPoint Downsizer Add-In";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(1, 18);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(1);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(1);
            this.labelVersion.Size = new System.Drawing.Size(74, 15);
            this.labelVersion.TabIndex = 22;
            this.labelVersion.Text = "Version 1.0.0";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(1, 35);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(1);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Padding = new System.Windows.Forms.Padding(1);
            this.labelCopyright.Size = new System.Drawing.Size(135, 15);
            this.labelCopyright.TabIndex = 23;
            this.labelCopyright.Text = "Copyright Aneejian 2021";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(1, 52);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(1);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Padding = new System.Windows.Forms.Padding(1);
            this.labelCompanyName.Size = new System.Drawing.Size(54, 15);
            this.labelCompanyName.TabIndex = 24;
            this.labelCompanyName.Text = "Aneejian";
            // 
            // AneejianLink
            // 
            this.AneejianLink.AutoSize = true;
            this.AneejianLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.AneejianLink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AneejianLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AneejianLink.Location = new System.Drawing.Point(1, 69);
            this.AneejianLink.Margin = new System.Windows.Forms.Padding(1);
            this.AneejianLink.Name = "AneejianLink";
            this.AneejianLink.Padding = new System.Windows.Forms.Padding(1);
            this.AneejianLink.Size = new System.Drawing.Size(79, 15);
            this.AneejianLink.TabIndex = 26;
            this.AneejianLink.TabStop = true;
            this.AneejianLink.Text = "Visit Aneejian";
            this.AneejianLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BmcLink
            // 
            this.BmcLink.AutoSize = true;
            this.BmcLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.BmcLink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmcLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BmcLink.Location = new System.Drawing.Point(1, 86);
            this.BmcLink.Margin = new System.Windows.Forms.Padding(1);
            this.BmcLink.Name = "BmcLink";
            this.BmcLink.Padding = new System.Windows.Forms.Padding(1);
            this.BmcLink.Size = new System.Drawing.Size(76, 15);
            this.BmcLink.TabIndex = 28;
            this.BmcLink.TabStop = true;
            this.BmcLink.Text = "Buy a Coffee!";
            this.BmcLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 214);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel AneejianLink;
        private System.Windows.Forms.LinkLabel BmcLink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}