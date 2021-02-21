using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    public partial class DownsizerAddIn
    {
        private void DownsizerAddIn_Startup(object sender, System.EventArgs e)
        {
            _ = Task.Run(() => _ = new UpdateChecker().CheckForUpdates());
        }

        private void DownsizerAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(DownsizerAddIn_Startup);
            this.Shutdown += new System.EventHandler(DownsizerAddIn_Shutdown);
        }

        #endregion VSTO generated code
    }
}