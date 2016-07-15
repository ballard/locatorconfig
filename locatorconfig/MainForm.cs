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
        private int tabsNum// = 0;
        {   
            get { return this.waysTabControl.TabCount; }
        }

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
                var newWay = new Way();
                createWay(newWay);
            }
        }

        private void createWay(Way newWay)
        {
            var tabIndex = this.waysTabControl.SelectedIndex;
            var uc = new WayUserСontrol(newWay);
            uc.Dock = DockStyle.Fill;
            var tp = new TabPage(String.Format(AppConstants.STR_WAY, tabIndex + 1));
            //tabsNum++;
            tp.Controls.Add(uc);
            this.waysTabControl.TabPages.Insert(tabIndex + 1, tp);
            this.updateWaysNums();
            this.waysTabControl.SelectedIndex = tabIndex + 1;
        }

        private void btnRemoveWay_Click(object sender, EventArgs e)
        {
            removeWay();
        }

        private void removeWay()
        {
            var tabIndex = this.waysTabControl.SelectedIndex;

            if (0 < tabsNum)
            {
                var currentTab = waysTabControl.SelectedTab;

                foreach (var userContolrol in waysTabControl.SelectedTab.Controls)
                {
                    if (userContolrol is WayUserСontrol)
                    {
                        var currentWayUserControl = (WayUserСontrol)userContolrol;
                        currentWayUserControl.disposeControls(currentWayUserControl);
                    }
                }

                this.waysTabControl.TabPages.Remove(currentTab);
                currentTab.Dispose();

                //tabsNum--;
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

                            var configId = 0;
                            switch (currentWay.RailWay.wayCircuitConfig)
                            {
                                case CircuitConfig.FirstOverlay:
                                    configId = 1;
                                    break;
                                case CircuitConfig.SecondOverlay:
                                    configId = 2;
                                    break;
                                case CircuitConfig.NoOverlay:
                                    configId = 3;
                                    break;                         
                            }
                            fileString.AppendFormat("m_way_{0}_circuit_config = {1}", i+1, configId);
                            fileString.AppendLine();
                            break;
                        }
                    }
                }                
            }

            return fileString.ToString();
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

        private void openFile_Click(object sender, EventArgs e)
        {

            var fileData = new List<string[]>();

            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "cfg files (*.cfg)|*.cfg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(myStream))
                        {
                            string textLine = string.Empty;
                            int lineCounter = 0;
                            while ((textLine = reader.ReadLine()) != null)
                            {
                                fileData.Add(textLine.Split(' '));
                                System.Console.WriteLine(string.Format("Строка {0}: " + textLine, lineCounter));
                                lineCounter++;
                            }
                        }

                        loadModel(fileData);

                    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Ошибка чтения файла. Текст ошибки: " + ex.Message);
                //}
            }            
        }

        private void loadModel(List<string[]> data)
        {
            if (tabsNum > 0)
            {
                var tabsCount = tabsNum;
                while (tabsCount > 0)
                {
                    removeWay();
                    tabsCount--;
                }
            }

            foreach (var numWaysStr in data)
            {
                if (numWaysStr[0] == AppConstants.M_NUM_WAYS)
                {
                    var m_num_ways = Convert.ToInt32(numWaysStr[2]);
                    for (int i = 0; i < m_num_ways; i++)
                    {
                        var wayCount = i + 1;
                        System.Console.WriteLine(string.Format("Create way number {0}", wayCount));
                        var way = new Way();
                        foreach (var wayConfig in data)
                        {
                            var currentWayConfig = string.Format(AppConstants.M_WAY_PREFIX, wayCount);
                            if (wayConfig[0] == currentWayConfig)
                            {
                                way.direction = Convert.ToInt32(wayConfig[2]);
                                way.delayLR = Convert.ToDouble(wayConfig[3]);
                                way.delayRL = Convert.ToDouble(wayConfig[4]);
                                way.maxSpeedLR = Convert.ToDouble(wayConfig[5]);
                                way.maxSpeedRL = Convert.ToDouble(wayConfig[6]);
                                way.timeCounterWrongL = Convert.ToDouble(wayConfig[7]);
                                way.timeCounterWrongR = Convert.ToDouble(wayConfig[8]);
                                way.timeNotificationTrainNotExitRL = Convert.ToDouble(wayConfig[9]);
                                way.timeNotificationTrainNotExitLR = Convert.ToDouble(wayConfig[10]);

                                foreach (var sensorsConfig in data)
                                {
                                    if (sensorsConfig[0].Contains(string.Format(AppConstants.M_CIRCUIT_CONFIG, wayCount)))
                                    {
                                        switch (sensorsConfig[2])
                                        {
                                            case "1":
                                                way.wayCircuitConfig = CircuitConfig.FirstOverlay;
                                                break;
                                            case "2":
                                                way.wayCircuitConfig = CircuitConfig.SecondOverlay;
                                                break;
                                            case "3":
                                                way.wayCircuitConfig = CircuitConfig.NoOverlay;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                                
                                foreach (var sensors in data)
                                {
                                    if (sensors[0].Contains(string.Format(AppConstants.M_SENSOR_PREFIX, wayCount)))
                                    {
                                        var currentCircuitId = Convert.ToInt32(sensors[0].Last().ToString()) - 1;
                                        switch (sensors[2])
                                        {
                                            case "1":
                                                var digitalSensor = new DigitalRailCircuit();
                                                digitalSensor.portNumber = Convert.ToInt32(sensors[5]);
                                                digitalSensor.pinNumber = Convert.ToInt32(sensors[6]);
                                                way.sensors[currentCircuitId] = digitalSensor;
                                                break;
                                            case "2":
                                                var radioSensor = new RadioRailCircuit();
                                                radioSensor.frequency = Convert.ToInt32(sensors[5]);
                                                way.sensors[currentCircuitId] = radioSensor;
                                                break;
                                            default:
                                                break;
                                        }

                                        switch (currentCircuitId)
                                        {
                                            case 1:
                                                way.wayCircuitConfigPoints[0] = Convert.ToDouble(sensors[3]);
                                                break;
                                            case 2:
                                                way.wayCircuitConfigPoints[1] = Convert.ToDouble(sensors[3]);
                                                way.wayCircuitConfigPoints[2] = Convert.ToDouble(sensors[4]);
                                                break;
                                            case 3:
                                                way.wayCircuitConfigPoints[3] = Convert.ToDouble(sensors[4]);
                                                break;
                                        }
                                    }
                                }                                
                            }
                        }
                        System.Console.WriteLine("Путь: " );
                        way.print();

                        if (AppConstants.MAX_WAYS > tabsNum)
                        {
                            createWay(way);
                        }
                    }                    
                }
            }
        }
    }
}
