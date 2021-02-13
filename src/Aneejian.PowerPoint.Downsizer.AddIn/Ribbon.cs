using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.ribbon = ribbonUI;
        }

        public async void GetDownsizePotential(Office.IRibbonControl control)
        {
            await PerformAction.GetPotential().ConfigureAwait(false);
        }

        public async void Downsize(Office.IRibbonControl control)
        {
            await PerformAction.DownSize().ConfigureAwait(false);
        }

        public void HideOrReveal(Office.IRibbonControl control)
        {
            Properties.Settings.Default.ShowDownsizerTab = !Properties.Settings.Default.ShowDownsizerTab;
            Properties.Settings.Default.Save();
            ribbon.Invalidate();
        }

        public async void Help(Office.IRibbonControl control)
        {
            await PerformAction.Help().ConfigureAwait(false);
        }

        public async void Coffee(Office.IRibbonControl control)
        {
            await PerformAction.Coffee().ConfigureAwait(false);
        }

        public bool GetTabVisibility(Office.IRibbonControl control)
        {
            return Properties.Settings.Default.ShowDownsizerTab;
        }

        public string GetLabel(Office.IRibbonControl control)
        {
            return PerformAction.GetProperty(control.Tag, ControlProperties.Label);
        }

        public Bitmap GetCoffeeImage(Office.IRibbonControl control)
        {
            return Properties.Resources.coffee_cup;
        }

        public string GetImage(Office.IRibbonControl control)
        {
            return RibbonControlValues.GetControlProperty(control.Tag, ControlProperties.Image);
        }

        public string GetDescription(Office.IRibbonControl control)
        {
            return RibbonControlValues.GetControlProperty(control.Tag, ControlProperties.Description);
        }

        public string GetScreentip(Office.IRibbonControl control)
        {
            return RibbonControlValues.GetControlProperty(control.Tag, ControlProperties.Screentip);
        }

        public string GetSupertip(Office.IRibbonControl control)
        {
            return RibbonControlValues.GetControlProperty(control.Tag, ControlProperties.Supertip);
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