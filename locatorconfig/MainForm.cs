using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace locatorconfig
{
    public partial class MainForm : Form
    {
        private int tabsNum = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var applicationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppConstants.APPLICATION_FOLDER_NAME);
            if (!Directory.Exists(applicationPath))
            {
                try
                {
                    Directory.CreateDirectory(applicationPath);
                }
                catch
                {
                    MessageBox.Show(AppConstants.MSG_NOT_ENOUGH_USER_RIHTS_TO_WRITE_FILE);
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AppConstants.MAX_WAYS > tabsNum)
            {
                var tabIndex = this.waysTabControl.SelectedIndex;
                var uc = new WayUserСontrol();
                uc.Dock = DockStyle.Fill;
                var tp = new TabPage(String.Format(AppConstants.STR_WAY, tabIndex + 1));
                tabsNum++;
                tp.Controls.Add(uc);
                this.waysTabControl.TabPages.Insert(tabIndex + 1, tp);
                this.updateWaysNums();
                this.waysTabControl.SelectedIndex = tabIndex + 1;
            }
        }

        private void btnRemoveWay_Click(object sender, EventArgs e)
        {
            var tabIndex = this.waysTabControl.SelectedIndex;
            if (0 < tabsNum)
            {
                this.waysTabControl.TabPages.Remove(this.waysTabControl.SelectedTab);
                tabsNum--;
                this.updateWaysNums();
            }
            this.waysTabControl.SelectedIndex = tabIndex - 1;
        }

        private void updateWaysNums()
        {
            for (var i = 0; i< tabsNum; i++)
            {
                this.waysTabControl.TabPages[i].Text = String.Format(AppConstants.STR_WAY, i + 1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < waysTabControl.TabCount; i++)
            {
                var control = (WayUserСontrol)waysTabControl.TabPages[i].Controls[0];
                control.RailWay.print();
                for (int j =0 ; j < 3; j++)
                {
                    //System.Console.WriteLine(control.RailWay.sensors[j].getCirciutType().ToString());
                }
            }
        }
    }
}
