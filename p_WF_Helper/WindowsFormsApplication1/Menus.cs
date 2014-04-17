using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace WFHelper
{
    public partial class MainForm
    {
       

        // ----------------------------------- Main Menu ----------------------------------------------


        // ----------------------------------- Minimize / Maximize Main Form ----------------------------------------------

        public void MainFormDeactivate(object sender, EventArgs e)
        {//свернуть трей
            if (WindowState != FormWindowState.Minimized) return;

            ShowInTaskbar = false;
            Notify.Visible = true;
        }

        public void NotifyMouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainWindowRestore();
        }

        public void MainWindowRestore() //востановление из трея
        {
            if (WindowState != FormWindowState.Minimized) return;

            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Notify.Visible = false;
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            using (var cms = new ContextMenuStrip())
            {
                cms.Items.Add("Restore");
                cms.Items.Add("Exit");
                Notify.ContextMenuStrip = cms;
                cms.ItemClicked += cms_ItemClicked;
            }

        }

        void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Exit":
                    Close();
                    break;
                case "Restore":
                    MainWindowRestore();
                    break;
            }
        }
 
    }
}
