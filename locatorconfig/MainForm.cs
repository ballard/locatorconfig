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

                if (tabIndex > 0)
                {
                    this.waysTabControl.SelectedIndex = tabIndex - 1;
                }
                else
                {
                    this.waysTabControl.SelectedIndex = 0;
                }
            }
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        private /*async void*/ string saveToFile() {
            var fileString = new StringBuilder();
            fileString.AppendFormat("m_version_cfg = {0} {1}", AppConstants.MAJOR_VERSION, AppConstants.MINOR_VERSION);
            fileString.AppendLine();
            fileString.AppendFormat("m_num_ways = {0}", tabsNum);
            fileString.AppendLine();
            if (0 < tabsNum)
            {
                for (var i = 0; i < tabsNum; i++) {
                    foreach (var wayControl in waysTabControl.TabPages[i].Controls)
                    {
                        if (wayControl is WayUserСontrol)
                        {
                            var currentWay = (WayUserСontrol)wayControl;
                            fileString.AppendFormat(
                                "m_way_{0} = {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16}",
                                i + 1,
                                currentWay.RailWay.direction,
                                currentWay.RailWay.delayLR,
                                currentWay.RailWay.delayRL.ToString(),
                                currentWay.RailWay.maxSpeedLR.ToString(),
                                currentWay.RailWay.maxSpeedRL.ToString(),
                                currentWay.RailWay.timeCounterWrongL.ToString(),
                                currentWay.RailWay.timeCounterWrongR.ToString(),
                                currentWay.RailWay.timeNotificationTrainNotExitRL.ToString(),
                                currentWay.RailWay.timeNotificationTrainNotExitLR.ToString(),
                                3,
                                1,
                                2,
                                3,
                                3,
                                2,
                                1);
                            fileString.AppendLine();
                            var currenCircuitConfigNormalizedPoints = new double[6];
                            switch (currentWay.RailWay.wayCircuitConfig)
                            {
                                case CircuitConfig.FirstOverlay:
                                    currenCircuitConfigNormalizedPoints[0] = currentWay.RailWay.wayCircuitConfigPoints[0];
                                    currenCircuitConfigNormalizedPoints[1] = currentWay.RailWay.wayCircuitConfigPoints[2];
                                    currenCircuitConfigNormalizedPoints[2] = currentWay.RailWay.wayCircuitConfigPoints[1];
                                    currenCircuitConfigNormalizedPoints[3] = currentWay.RailWay.wayCircuitConfigPoints[2];
                                    currenCircuitConfigNormalizedPoints[4] = currentWay.RailWay.wayCircuitConfigPoints[2];
                                    currenCircuitConfigNormalizedPoints[5] = currentWay.RailWay.wayCircuitConfigPoints[3];
                                    break;
                                case CircuitConfig.SecondOverlay:
                                    currenCircuitConfigNormalizedPoints[0] = currentWay.RailWay.wayCircuitConfigPoints[0];
                                    currenCircuitConfigNormalizedPoints[1] = currentWay.RailWay.wayCircuitConfigPoints[1];
                                    currenCircuitConfigNormalizedPoints[2] = currentWay.RailWay.wayCircuitConfigPoints[1];
                                    currenCircuitConfigNormalizedPoints[3] = currentWay.RailWay.wayCircuitConfigPoints[2];
                                    currenCircuitConfigNormalizedPoints[4] = currentWay.RailWay.wayCircuitConfigPoints[1];
                                    currenCircuitConfigNormalizedPoints[5] = currentWay.RailWay.wayCircuitConfigPoints[3];
                                    break;
                                case CircuitConfig.NoOverlay:
                                    currenCircuitConfigNormalizedPoints[0] = currentWay.RailWay.wayCircuitConfigPoints[0];
                                    currenCircuitConfigNormalizedPoints[1] = currentWay.RailWay.wayCircuitConfigPoints[1];
                                    currenCircuitConfigNormalizedPoints[2] = currentWay.RailWay.wayCircuitConfigPoints[1];
                                    currenCircuitConfigNormalizedPoints[3] = currentWay.RailWay.wayCircuitConfigPoints[2];
                                    currenCircuitConfigNormalizedPoints[4] = currentWay.RailWay.wayCircuitConfigPoints[2];
                                    currenCircuitConfigNormalizedPoints[5] = currentWay.RailWay.wayCircuitConfigPoints[3];
                                    break;
                            }
                            for (var j = 0; j < currentWay.RailWay.sensors.Count(); j++)
                            {
                                var currentSensorType = currentWay.RailWay.sensors[j].getCirciutType();
                                fileString.AppendFormat("m_sensor_{0}_{1} = {2} {3} {4} ",
                                    i + 1,
                                    j + 1,
                                    (currentSensorType == RailCircuitType.Digital) ? 1 : 2,
                                    currenCircuitConfigNormalizedPoints[j * 2],
                                    currenCircuitConfigNormalizedPoints[j * 2 + 1]
                                );
                                switch (currentSensorType)
                                {                                   
                                    case RailCircuitType.Digital:
                                        var digitalSensor = (DigitalRailCircuit)currentWay.RailWay.sensors[j];
                                        fileString.AppendFormat("{0} {1}",                                            
                                            digitalSensor.portNumber,
                                            digitalSensor.pinNumber);
                                        fileString.AppendLine();
                                        break;
                                    case RailCircuitType.Radio:
                                        var radioSensor = (RadioRailCircuit)currentWay.RailWay.sensors[j];
                                        fileString.AppendFormat("{0} {1}",
                                        radioSensor.frequency,
                                        50);
                                        fileString.AppendLine();                                        
                                        break;
                                }
                            }
                            break;
                        }
                    }
                }                
            }


            return fileString.ToString();// (fileString.ToString());             

            //string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);            
            //using (var outputFile = new StreamWriter(mydocpath + @"\WriteTextAsync.txt"))
            //{
            //    await outputFile.WriteAsync(fileString.ToString());                
            //}
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "All files (*.*)|*.*|CFG files (*.cfg)|*.cfg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var sstream = new MemoryStream(Encoding.UTF8.GetBytes(saveToFile()));
                    sstream.CopyTo(myStream);
                    myStream.Close();
                }
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
