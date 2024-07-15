using DevExpress.XtraExport.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burn_management.Classes.Home
{
    public class Cls_PageManager
    {
        private readonly Form_Main main;
        /*private readonly Form_Settings settings;*/
        public Cls_PageManager(Form_Main main)
        {
            this.main = main;
        }
      /*  public Cls_PageManager(Form_Settings settings)
        {
            this.settings = settings;
        }*/
        public void LoadPage(UserControl PageUserControl)
        {
            //==>  Load old page
            var oldpage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldpage != null)
            {
                main.panelContainer.Controls.Remove(oldpage);
                //==> Remove To memory 
                oldpage.Dispose();
            }
            //==> Load New Page
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);
        }
     /*   public void LoadPageSettings(UserControl PageUserControl)
        {
            //==>  Load old page
            var oldpage = settings.panelContainerSettings.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldpage != null)
            {
                settings.panelContainerSettings.Controls.Remove(oldpage);
                //==> Remove To memory 
                oldpage.Dispose();
            }
            //==> Load New Page
            PageUserControl.Dock = DockStyle.Fill;
            settings.panelContainerSettings.Controls.Add(PageUserControl);
        }*/
    }
}
