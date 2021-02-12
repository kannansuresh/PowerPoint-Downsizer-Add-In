
namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    partial class DownsizerRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DownsizerRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabDownsizer = this.Factory.CreateRibbonTab();
            this.GrpDownsizer = this.Factory.CreateRibbonGroup();
            this.BtnDownsizeSlideMaster = this.Factory.CreateRibbonButton();
            this.BtnHelp = this.Factory.CreateRibbonButton();
            this.BtnDonate = this.Factory.CreateRibbonButton();
            this.DownsizerSeparator = this.Factory.CreateRibbonSeparator();
            this.BtnGetDownsizePotential = this.Factory.CreateRibbonButton();
            this.TabDownsizer.SuspendLayout();
            this.GrpDownsizer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabDownsizer
            // 
            this.TabDownsizer.Groups.Add(this.GrpDownsizer);
            this.TabDownsizer.Label = "Downsizer";
            this.TabDownsizer.Name = "TabDownsizer";
            // 
            // GrpDownsizer
            // 
            this.GrpDownsizer.Items.Add(this.BtnGetDownsizePotential);
            this.GrpDownsizer.Items.Add(this.BtnDownsizeSlideMaster);
            this.GrpDownsizer.Items.Add(this.DownsizerSeparator);
            this.GrpDownsizer.Items.Add(this.BtnHelp);
            this.GrpDownsizer.Items.Add(this.BtnDonate);
            this.GrpDownsizer.Label = "Downsizer";
            this.GrpDownsizer.Name = "GrpDownsizer";
            // 
            // BtnDownsizeSlideMaster
            // 
            this.BtnDownsizeSlideMaster.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnDownsizeSlideMaster.Description = "Removes unused custom layouts and master slides.";
            this.BtnDownsizeSlideMaster.Label = "Downsize Slide Master";
            this.BtnDownsizeSlideMaster.Name = "BtnDownsizeSlideMaster";
            this.BtnDownsizeSlideMaster.OfficeImageId = "DeleteSlideContextual";
            this.BtnDownsizeSlideMaster.ScreenTip = "Remove unused Slide Masters";
            this.BtnDownsizeSlideMaster.ShowImage = true;
            this.BtnDownsizeSlideMaster.SuperTip = "Removes unused custom layouts and master slides.";
            this.BtnDownsizeSlideMaster.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnDownsizeSlideMaster_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Description = "Get help";
            this.BtnHelp.Label = "Help";
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.OfficeImageId = "FunctionsLogicalInsertGallery";
            this.BtnHelp.ScreenTip = "Help";
            this.BtnHelp.ShowImage = true;
            this.BtnHelp.SuperTip = "Get help on PowerPoint Downsizer Add-In";
            this.BtnHelp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnHelp_Click);
            // 
            // BtnDonate
            // 
            this.BtnDonate.Description = "Love this add-in? Consider buying a coffee for the developer!";
            this.BtnDonate.Label = "Buy me a Coffee!";
            this.BtnDonate.Name = "BtnDonate";
            this.BtnDonate.OfficeImageId = "Coffee";
            this.BtnDonate.ScreenTip = "Buy me a Coffee!";
            this.BtnDonate.ShowImage = true;
            this.BtnDonate.SuperTip = "Love this add-in? Consider buying a coffee for the developer!";
            this.BtnDonate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnDonate_Click);
            // 
            // DownsizerSeparator
            // 
            this.DownsizerSeparator.Name = "DownsizerSeparator";
            // 
            // BtnGetDownsizePotential
            // 
            this.BtnGetDownsizePotential.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnGetDownsizePotential.Description = "Shows the number of unused layouts and master slides.";
            this.BtnGetDownsizePotential.Label = "Get Downsize Potential";
            this.BtnGetDownsizePotential.Name = "BtnGetDownsizePotential";
            this.BtnGetDownsizePotential.OfficeImageId = "FileViewDigitalSignatures";
            this.BtnGetDownsizePotential.ScreenTip = "Get Downsize Potential";
            this.BtnGetDownsizePotential.ShowImage = true;
            this.BtnGetDownsizePotential.SuperTip = "Shows the number of unused layouts and master slides.";
            this.BtnGetDownsizePotential.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnGetDownsizePotential_Click);
            // 
            // DownsizerRibbon
            // 
            this.Name = "DownsizerRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.TabDownsizer);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.DownsizerRibbon_Load);
            this.TabDownsizer.ResumeLayout(false);
            this.TabDownsizer.PerformLayout();
            this.GrpDownsizer.ResumeLayout(false);
            this.GrpDownsizer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabDownsizer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GrpDownsizer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnDownsizeSlideMaster;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnHelp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnDonate;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator DownsizerSeparator;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnGetDownsizePotential;
    }

    partial class ThisRibbonCollection
    {
        internal DownsizerRibbon DownsizerRibbon
        {
            get { return this.GetRibbon<DownsizerRibbon>(); }
        }
    }
}
