using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Office = Microsoft.Office.Core;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new Ribbon();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        private readonly Properties.Settings settings = Properties.Settings.Default;

        private readonly List<string> coffeeButtons = new List<string>() { "BtnCoffeeInView", "BtnCoffeeInSlideMaster", "BtnHideCoffee", "BtnCoffee", "SplitBtnCoffee" };

        private readonly List<string> tabHideOrRevealButtons = new List<string>() { "TabDownsizer", "BtnHideInView", "BtnHideInSlideMaster" };

        public Ribbon()
        {
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("Aneejian.PowerPoint.Downsizer.AddIn.Ribbon.xml");
        }

        #endregion IRibbonExtensibility Members

        #region Ribbon Callbacks

        //Create callback methods here. For more information about adding callback methods, visit https://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            ribbon = ribbonUI;
            settings.PropertyChanged += Default_PropertyChanged;
        }

        public async void GetDownsizePotential(Office.IRibbonControl control)
        {
            await PerformAction.GetPotential().ConfigureAwait(false);
        }

        public async void Downsize(Office.IRibbonControl control)
        {
            await PerformAction.GetPotentialAndDownsize().ConfigureAwait(false);
        }

        public void HideOrReveal(Office.IRibbonControl control)
        {
            settings.Ribbon_ShowDownsizerTab = !settings.Ribbon_ShowDownsizerTab;
            settings.Save();
            if (settings.Ribbon_ShowDownsizerTab)
            {
                ribbon.ActivateTab("TabDownsizer");
            }
        }

        public async void HideCoffee(Office.IRibbonControl control)
        {
            await Reporter.ReportHideCoffee().ConfigureAwait(false);
        }

        public async void Help(Office.IRibbonControl control)
        {
            await PerformAction.Help().ConfigureAwait(false);
        }

        public async void Update(Office.IRibbonControl control)
        {
            await PerformAction.Update().ConfigureAwait(false);
        }

        public void About(Office.IRibbonControl control)
        {
            new AboutBox().ShowDialog();
        }

        private void Default_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(settings.Ribbon_ShowCoffeeButton):
                    {
                        coffeeButtons.ForEach(RefreshRibbonControl);
                        break;
                    }

                case nameof(settings.Ribbon_ShowDownsizerTab):
                    {
                        tabHideOrRevealButtons.ForEach(RefreshRibbonControl);
                        break;
                    }

                case nameof(settings.App_UsageCounter):
                    {
                        if (settings.Ribbon_ShowCoffeeButton)
                        {
                            coffeeButtons.ForEach(RefreshRibbonControl);
                        }
                        else
                        {
                            if (!settings.Coffee_AlreadyBought && settings.App_UsageCounter > 0)
                            {
                                settings.Coffee_HiddenSinceCounter++;
                                settings.Save();
                            }
                        }
                        break;
                    }
                case nameof(settings.Ribbon_ShowUpdateButton):
                    {
                        ribbon.InvalidateControl("BtnUpdate");
                        break;
                    }
            }
        }

        private void RefreshRibbonControl(string controlName)
        {
            ribbon.InvalidateControl(controlName);
        }

        public async void Coffee(Office.IRibbonControl control)
        {
            await PerformAction.Coffee().ConfigureAwait(false);
        }

        public bool GetTabVisibility(Office.IRibbonControl control)
        {
            return settings.Ribbon_ShowDownsizerTab;
        }

        public bool GetHideTabVisibility(Office.IRibbonControl control)
        {
            return !settings.Ribbon_ShowUpdateButton;
        }

        public bool GetUpdateVisibility(Office.IRibbonControl control)
        {
            return settings.Ribbon_ShowUpdateButton;
        }

        public bool GetCoffeeVisibility(Office.IRibbonControl control)
        {
            return settings.Ribbon_ShowCoffeeButton;
        }

        public object GetLabel(Office.IRibbonControl control)
        {
            return PerformAction.GetProperty(control.Tag, ControlProperties.Label);
        }

        public object GetImage(Office.IRibbonControl control)
        {
            return new RibbonControlValues().GetControlProperty(control.Tag, ControlProperties.Image);
        }

        public object GetDescription(Office.IRibbonControl control)
        {
            return new RibbonControlValues().GetControlProperty(control.Tag, ControlProperties.Description);
        }

        public object GetScreentip(Office.IRibbonControl control)
        {
            return new RibbonControlValues().GetControlProperty(control.Tag, ControlProperties.Screentip);
        }

        public object GetSupertip(Office.IRibbonControl control)
        {
            return new RibbonControlValues().GetControlProperty(control.Tag, ControlProperties.Supertip);
        }

        #endregion Ribbon Callbacks

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Equals(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase))
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion Helpers
    }
}