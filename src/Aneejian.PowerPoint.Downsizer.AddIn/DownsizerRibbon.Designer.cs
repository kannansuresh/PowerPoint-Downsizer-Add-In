
//namespace Aneejian.PowerPoint.Downsizer.AddIn
//{
//    partial class DownsizerRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        public DownsizerRibbon()
//            : base(Globals.Factory.GetRibbonFactory())
//        {
//            InitializeComponent();
//        }

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownsizerRibbon));
//            this.TabDownsizer = this.Factory.CreateRibbonTab();
//            this.GrpDownsizer = this.Factory.CreateRibbonGroup();
//            this.BtnGetDownsizePotential = this.Factory.CreateRibbonButton();
//            this.BtnDownsizeSlideMaster = this.Factory.CreateRibbonButton();
//            this.BtnHideDownsizerTab = this.Factory.CreateRibbonButton();
//            this.BtnHelp = this.Factory.CreateRibbonButton();
//            this.BtnDonate = this.Factory.CreateRibbonButton();
//            this.TabDownsizerInView = this.Factory.CreateRibbonTab();
//            this.GrpDownSizerInView = this.Factory.CreateRibbonGroup();
//            this.BtnDownsizeInView = this.Factory.CreateRibbonSplitButton();
//            this.BtnDownsizeInViewMenu = this.Factory.CreateRibbonButton();
//            this.BtnPotentionInView = this.Factory.CreateRibbonButton();
//            this.BtnHideTabInView = this.Factory.CreateRibbonButton();
//            this.BtnHelpInView = this.Factory.CreateRibbonButton();
//            this.BtnDonateInView = this.Factory.CreateRibbonButton();
//            this.TabDownsizer.SuspendLayout();
//            this.GrpDownsizer.SuspendLayout();
//            this.TabDownsizerInView.SuspendLayout();
//            this.GrpDownSizerInView.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // TabDownsizer
//            // 
//            this.TabDownsizer.Groups.Add(this.GrpDownsizer);
//            this.TabDownsizer.Label = "Downsizer";
//            this.TabDownsizer.Name = "TabDownsizer";
//            // 
//            // GrpDownsizer
//            // 
//            this.GrpDownsizer.Items.Add(this.BtnGetDownsizePotential);
//            this.GrpDownsizer.Items.Add(this.BtnDownsizeSlideMaster);
//            this.GrpDownsizer.Items.Add(this.BtnHideDownsizerTab);
//            this.GrpDownsizer.Items.Add(this.BtnHelp);
//            this.GrpDownsizer.Items.Add(this.BtnDonate);
//            this.GrpDownsizer.Label = "Downsizer";
//            this.GrpDownsizer.Name = "GrpDownsizer";
//            // 
//            // BtnGetDownsizePotential
//            // 
//            this.BtnGetDownsizePotential.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnGetDownsizePotential.Description = "Shows the number of unused layouts and master slides.";
//            this.BtnGetDownsizePotential.Label = "Get Downsize Potential";
//            this.BtnGetDownsizePotential.Name = "BtnGetDownsizePotential";
//            this.BtnGetDownsizePotential.OfficeImageId = "FileViewDigitalSignatures";
//            this.BtnGetDownsizePotential.ScreenTip = "Get Downsize Potential";
//            this.BtnGetDownsizePotential.ShowImage = true;
//            this.BtnGetDownsizePotential.SuperTip = "Shows the number of unused layouts and master slides.";
//            this.BtnGetDownsizePotential.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnGetDownsizePotential_Click);
//            // 
//            // BtnDownsizeSlideMaster
//            // 
//            this.BtnDownsizeSlideMaster.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnDownsizeSlideMaster.Description = "Removes unused custom layouts and master slides.";
//            this.BtnDownsizeSlideMaster.Image = ((System.Drawing.Image)(resources.GetObject("BtnDownsizeSlideMaster.Image")));
//            this.BtnDownsizeSlideMaster.Label = "Downsize Slide Master";
//            this.BtnDownsizeSlideMaster.Name = "BtnDownsizeSlideMaster";
//            this.BtnDownsizeSlideMaster.OfficeImageId = "DeleteSlideContextual";
//            this.BtnDownsizeSlideMaster.ScreenTip = "Remove unused Slide Masters";
//            this.BtnDownsizeSlideMaster.ShowImage = true;
//            this.BtnDownsizeSlideMaster.SuperTip = "Removes unused custom layouts and master slides.";
//            this.BtnDownsizeSlideMaster.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnDownsizeSlideMaster_Click);
//            // 
//            // BtnHideDownsizerTab
//            // 
//            this.BtnHideDownsizerTab.Description = "Hides the Downsizer tab.";
//            this.BtnHideDownsizerTab.Label = "Hide this tab";
//            this.BtnHideDownsizerTab.Name = "BtnHideDownsizerTab";
//            this.BtnHideDownsizerTab.OfficeImageId = "WindowHide";
//            this.BtnHideDownsizerTab.ScreenTip = "Hide Tab";
//            this.BtnHideDownsizerTab.ShowImage = true;
//            this.BtnHideDownsizerTab.SuperTip = "Hides the downsizer tab.";
//            this.BtnHideDownsizerTab.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnHideDownsizerTab_Click);
//            // 
//            // BtnHelp
//            // 
//            this.BtnHelp.Description = "Get help";
//            this.BtnHelp.Label = "Help";
//            this.BtnHelp.Name = "BtnHelp";
//            this.BtnHelp.OfficeImageId = "FunctionsLogicalInsertGallery";
//            this.BtnHelp.ScreenTip = "Help";
//            this.BtnHelp.ShowImage = true;
//            this.BtnHelp.SuperTip = "Get help on PowerPoint Downsizer Add-In";
//            this.BtnHelp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnHelp_Click);
//            // 
//            // BtnDonate
//            // 
//            this.BtnDonate.Description = "Love this add-in? Consider buying a coffee for the developer!";
//            this.BtnDonate.Label = "Buy me a Coffee!";
//            this.BtnDonate.Name = "BtnDonate";
//            this.BtnDonate.OfficeImageId = "Coffee";
//            this.BtnDonate.ScreenTip = "Buy me a Coffee!";
//            this.BtnDonate.ShowImage = true;
//            this.BtnDonate.SuperTip = "Love this add-in? Consider buying a coffee for the developer!";
//            this.BtnDonate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnDonate_Click);
//            // 
//            // TabDownsizerInView
//            // 
//            this.TabDownsizerInView.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
//            this.TabDownsizerInView.ControlId.OfficeId = "TabView";
//            this.TabDownsizerInView.Groups.Add(this.GrpDownSizerInView);
//            this.TabDownsizerInView.Label = "TabView";
//            this.TabDownsizerInView.Name = "TabDownsizerInView";
//            // 
//            // GrpDownSizerInView
//            // 
//            this.GrpDownSizerInView.Items.Add(this.BtnDownsizeInView);
//            this.GrpDownSizerInView.Name = "GrpDownSizerInView";
//            this.GrpDownSizerInView.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupMasterViews");
//            // 
//            // BtnDownsizeInView
//            // 
//            this.BtnDownsizeInView.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnDownsizeInView.Items.Add(this.BtnDownsizeInViewMenu);
//            this.BtnDownsizeInView.Items.Add(this.BtnPotentionInView);
//            this.BtnDownsizeInView.Items.Add(this.BtnHideTabInView);
//            this.BtnDownsizeInView.Items.Add(this.BtnHelpInView);
//            this.BtnDownsizeInView.Items.Add(this.BtnDonateInView);
//            this.BtnDownsizeInView.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnDownsizeInView.Label = "Downsize Slide Master";
//            this.BtnDownsizeInView.Name = "BtnDownsizeInView";
//            this.BtnDownsizeInView.OfficeImageId = "DeleteSlideContextual";
//            this.BtnDownsizeInView.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnDownsizeInView_Click);
//            // 
//            // BtnDownsizeInViewMenu
//            // 
//            this.BtnDownsizeInViewMenu.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnDownsizeInViewMenu.Description = "Removes unused custom layouts and master slides.";
//            this.BtnDownsizeInViewMenu.Label = "Downsize Slide Master";
//            this.BtnDownsizeInViewMenu.Name = "BtnDownsizeInViewMenu";
//            this.BtnDownsizeInViewMenu.OfficeImageId = "DeleteSlideContextual";
//            this.BtnDownsizeInViewMenu.ScreenTip = "Remove unused Slide Masters";
//            this.BtnDownsizeInViewMenu.ShowImage = true;
//            this.BtnDownsizeInViewMenu.SuperTip = "Removes unused custom layouts and master slides.";
//            this.BtnDownsizeInViewMenu.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnDownsizeInViewMenu_Click);
//            // 
//            // BtnPotentionInView
//            // 
//            this.BtnPotentionInView.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnPotentionInView.Description = "Shows the number of unused layouts and master slides.";
//            this.BtnPotentionInView.Label = "Get Downsize Potential";
//            this.BtnPotentionInView.Name = "BtnPotentionInView";
//            this.BtnPotentionInView.OfficeImageId = "FileViewDigitalSignatures";
//            this.BtnPotentionInView.ScreenTip = "Get Downsize Potential";
//            this.BtnPotentionInView.ShowImage = true;
//            this.BtnPotentionInView.SuperTip = "Shows the number of unused layouts and master slides.";
//            this.BtnPotentionInView.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnPotentionInView_Click);
//            // 
//            // BtnHideTabInView
//            // 
//            this.BtnHideTabInView.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnHideTabInView.Description = "Hides the Downsizer tab.";
//            this.BtnHideTabInView.Label = "Hide this tab";
//            this.BtnHideTabInView.Name = "BtnHideTabInView";
//            this.BtnHideTabInView.OfficeImageId = "WindowHide";
//            this.BtnHideTabInView.ScreenTip = "Hide Tab";
//            this.BtnHideTabInView.ShowImage = true;
//            this.BtnHideTabInView.SuperTip = "Hides the downsizer tab.";
//            this.BtnHideTabInView.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnHideTabInView_Click);
//            // 
//            // BtnHelpInView
//            // 
//            this.BtnHelpInView.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnHelpInView.Description = "Get help";
//            this.BtnHelpInView.Label = "Help";
//            this.BtnHelpInView.Name = "BtnHelpInView";
//            this.BtnHelpInView.OfficeImageId = "FunctionsLogicalInsertGallery";
//            this.BtnHelpInView.ScreenTip = "Help";
//            this.BtnHelpInView.ShowImage = true;
//            this.BtnHelpInView.SuperTip = "Get help on PowerPoint Downsizer Add-In";
//            this.BtnHelpInView.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnHelpInView_Click);
//            // 
//            // BtnDonateInView
//            // 
//            this.BtnDonateInView.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
//            this.BtnDonateInView.Description = "Love this add-in? Consider buying a coffee for the developer!";
//            this.BtnDonateInView.Label = "Buy me a Coffee!";
//            this.BtnDonateInView.Name = "BtnDonateInView";
//            this.BtnDonateInView.OfficeImageId = "Coffee";
//            this.BtnDonateInView.ScreenTip = "Buy me a Coffee!";
//            this.BtnDonateInView.ShowImage = true;
//            this.BtnDonateInView.SuperTip = "Love this add-in? Consider buying a coffee for the developer!";
//            this.BtnDonateInView.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnDonateInView_Click);
//            // 
//            // DownsizerRibbon
//            // 
//            this.Name = "DownsizerRibbon";
//            this.RibbonType = "Microsoft.PowerPoint.Presentation";
//            this.Tabs.Add(this.TabDownsizer);
//            this.Tabs.Add(this.TabDownsizerInView);
//            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.DownsizerRibbon_Load);
//            this.TabDownsizer.ResumeLayout(false);
//            this.TabDownsizer.PerformLayout();
//            this.GrpDownsizer.ResumeLayout(false);
//            this.GrpDownsizer.PerformLayout();
//            this.TabDownsizerInView.ResumeLayout(false);
//            this.TabDownsizerInView.PerformLayout();
//            this.GrpDownSizerInView.ResumeLayout(false);
//            this.GrpDownSizerInView.PerformLayout();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabDownsizer;
//        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GrpDownsizer;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnDownsizeSlideMaster;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnHelp;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnDonate;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnGetDownsizePotential;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnHideDownsizerTab;
//        private Microsoft.Office.Tools.Ribbon.RibbonTab TabDownsizerInView;
//        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GrpDownSizerInView;
//        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton BtnDownsizeInView;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnPotentionInView;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnHideTabInView;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnHelpInView;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnDonateInView;
//        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnDownsizeInViewMenu;
//    }

//    partial class ThisRibbonCollection
//    {
//        internal DownsizerRibbon DownsizerRibbon
//        {
//            get { return this.GetRibbon<DownsizerRibbon>(); }
//        }
//    }
//}
