using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locatorconfig
{
    public partial class WayUserСontrol : UserControl
    {
        public Way RailWay { get; set; }

        public WayUserСontrol()
        {
            InitializeComponent();

            RailWay = new Way();

            cbxDirection.SelectedIndex = RailWay.direction;
            tbxDelayLR.Text = RailWay.delayLR.ToString();
            tbxDelayRL.Text = RailWay.delayRL.ToString();
            tbxMaxSpeedLR.Text = RailWay.maxSpeedLR.ToString();
            tbxMaxSpeedRL.Text = RailWay.maxSpeedRL.ToString();
            tbxTimeCounterWrongL.Text = RailWay.timeCounterWrongL.ToString();
            tbxTimeCounterWrongR.Text = RailWay.timeCounterWrongR.ToString();
            tbxTimeNotificationTrainNotExitLR.Text = RailWay.timeNotificationTrainNotExitLR.ToString();
            tbxTimeNotificationTrainNotExitRL.Text = RailWay.timeNotificationTrainNotExitRL.ToString();

            for (var i = 0; i < AppConstants.NUM_OF_SENSORS; i++)
            {
                var sensor = (DigitalRailCircuit)RailWay.sensors[i];
                var uc = new DigitalRailCircuitUserControl(sensor.pinNumber, sensor.portNumber);
                uc.Dock = DockStyle.Fill;
                var tp = new TabPage(String.Format(AppConstants.RAIL_CHAIN_STRING, i + 1));
                tp.Controls.Add(uc);
                this.tabRailChain.TabPages.Add(tp);
            }
            this.updateCircuitConfigPoints();
            this.wayConfigImagePanel.BackgroundImage = Properties.Resources.OverlayFirst;
            this.wayConfigImagePanel.BackgroundImageLayout = ImageLayout.Zoom;

            updateModel();
            initialSetupControls(this);
        }

        private void initialSetupControls(Control control)
        {
            if (control is NumericUpDown)
            {
                control.Controls.RemoveAt(0);
                control.TextChanged += new EventHandler(controlOnTextChanged);
            } else if (control is TextBox) {
                control.TextChanged += new EventHandler(controlOnTextChanged);
            } else if (control is ComboBox) {
                control.TextChanged += new EventHandler(controlOnTextChanged);
            }

            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    initialSetupControls(childControl);
                }
            }
        }

        public void disposeControls(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    disposeControls(childControl);
                }
            } else
            {
                control.Dispose();
            }

        }

        private void controlOnTextChanged(object sender, System.EventArgs e)
        {
            if (this.IsHandleCreated)
                updateModel();
        }

        private void updateCircuitConfigPoints()
        {
            if (RailWay.wayCircuitConfigPoints.Count() >= 4)
            {
                this.lblPointA.Text = String.Format(AppConstants.POINT_A_TEXT, this.RailWay.wayCircuitConfigPoints[0].ToString());
                this.lblPointB.Text = String.Format(AppConstants.POINT_B_TEXT, this.RailWay.wayCircuitConfigPoints[1].ToString());
                this.lblPointC.Text = String.Format(AppConstants.POINT_C_TEXT, this.RailWay.wayCircuitConfigPoints[2].ToString());
                this.lblPointD.Text = String.Format(AppConstants.POINT_D_TEXT, this.RailWay.wayCircuitConfigPoints[3].ToString());
            }
        }      

        private void btnChangeRailType_Click(object sender, EventArgs e)
        {
            var currentTabIndex = this.tabRailChain.SelectedIndex;
            System.Console.WriteLine("Rail circuit #{0} is going to be changed", currentTabIndex);
            switch (RailWay.sensors[currentTabIndex].getCirciutType())
            {
                case RailCircuitType.Digital:
                    var changeRailTypeDigital = new RailCircuitTypeDialog(RailCircuitType.Digital);
                    changeRailTypeDigital.ShowDialog();
                    if (changeRailTypeDigital.DialogResult == DialogResult.OK)
                    {
                        swapTabSontrol(RailCircuitType.Radio, currentTabIndex);
                    }
                    break;
                case RailCircuitType.Radio:
                    var changeRailTypeRadio = new RailCircuitTypeDialog(RailCircuitType.Radio);
                    changeRailTypeRadio.ShowDialog();
                    if (changeRailTypeRadio.DialogResult == DialogResult.OK)
                    {
                        swapTabSontrol(RailCircuitType.Digital, currentTabIndex);
                    }
                    break;
            }
        }

        private void swapTabSontrol(RailCircuitType currentType, int tabIndex)
        {
            UserControl uc = new UserControl();
            switch (currentType)
            {
                case RailCircuitType.Digital:

                    var digitalCircuit = new DigitalRailCircuit();
                    uc = new DigitalRailCircuitUserControl(digitalCircuit.pinNumber, digitalCircuit.portNumber);
                    break;
                case RailCircuitType.Radio:
                    var radioCircuit = new RadioRailCircuit();
                    uc = new RadioRailCircuitUserControl(radioCircuit.frequency);
                    break;
            }
            System.Console.WriteLine("new control type is: " + uc.GetType().ToString());
            this.tabRailChain.TabPages.Remove(this.tabRailChain.SelectedTab);            
            initialSetupControls(uc);
            uc.Dock = DockStyle.Fill;
            var tp = new TabPage(String.Format(AppConstants.RAIL_CHAIN_STRING, tabIndex + 1));
            tp.Controls.Add(uc);
            this.tabRailChain.TabPages.Insert(tabIndex, tp);
            RailWay.changeRailCircuitType(tabIndex, currentType);
            this.tabRailChain.SelectTab(tabIndex);
            updateModel();
        }

        private void btnSaveWayChanges_Click(object sender, EventArgs e)
        {
            updateModel();
        }

        private void loadModel()
        {

        }

        private void updateModel()
        {
            System.Console.WriteLine("Model updated");
            RailWay.direction = cbxDirection.SelectedIndex + 1;
            RailWay.delayLR = Convert.ToDouble(((this.tbxDelayLR.Text == "") || (this.tbxDelayLR.Text == "-")) ? "0" : this.tbxDelayLR.Text);
            RailWay.delayRL = Convert.ToDouble(((this.tbxDelayRL.Text == "") || (this.tbxDelayRL.Text == "-")) ? "0" : this.tbxDelayRL.Text);
            RailWay.maxSpeedLR = Convert.ToDouble(((this.tbxMaxSpeedLR.Text == "") || (this.tbxMaxSpeedLR.Text == "-")) ? "0" : this.tbxMaxSpeedLR.Text);
            RailWay.maxSpeedRL = Convert.ToDouble(((this.tbxMaxSpeedRL.Text == "") || (this.tbxMaxSpeedRL.Text == "-")) ? "0" : this.tbxMaxSpeedRL.Text);
            RailWay.timeCounterWrongL = Convert.ToDouble(((this.tbxTimeCounterWrongL.Text == "") || (this.tbxTimeCounterWrongL.Text == "-")) ? "0" : this.tbxTimeCounterWrongL.Text);
            RailWay.timeCounterWrongR = Convert.ToDouble(((this.tbxTimeCounterWrongR.Text == "") || (this.tbxTimeCounterWrongR.Text == "-")) ? "0" : this.tbxTimeCounterWrongR.Text);
            RailWay.timeNotificationTrainNotExitRL = Convert.ToDouble(((this.tbxTimeNotificationTrainNotExitRL.Text == "") || (this.tbxTimeNotificationTrainNotExitRL.Text == "-")) ? "0" : this.tbxTimeNotificationTrainNotExitRL.Text);
            RailWay.timeNotificationTrainNotExitLR = Convert.ToDouble(((this.tbxTimeNotificationTrainNotExitLR.Text == "") || (this.tbxTimeNotificationTrainNotExitLR.Text == "-")) ? "0" : this.tbxTimeNotificationTrainNotExitLR.Text);
            for (int i = 0; i < AppConstants.NUM_OF_SENSORS; i++)
            {
                switch (RailWay.sensors[i].getCirciutType())
                {
                    case RailCircuitType.Digital:
                        foreach (var control in tabRailChain.TabPages[i].Controls)
                        {
                            if (control is DigitalRailCircuitUserControl)
                            {
                                var digitalControl = (DigitalRailCircuitUserControl)control;
                                var digitalCircuit = new DigitalRailCircuit();
                                digitalCircuit.pinNumber = digitalControl.getPin();
                                digitalCircuit.portNumber = digitalControl.getPort();
                                RailWay.sensors[i] = digitalCircuit;
                                break;
                            }
                        }
                        break;
                    case RailCircuitType.Radio:
                        foreach (var control in tabRailChain.TabPages[i].Controls)
                        {
                            if (control is RadioRailCircuitUserControl)
                            {
                                var radioControl = (RadioRailCircuitUserControl)control;
                                var radioCircuit = new RadioRailCircuit();
                                radioCircuit.frequency = radioControl.getFrequency();
                                RailWay.sensors[i] = radioCircuit;
                                break;
                            }
                        }
                        break;
                }
            }
            RailWay.print();
        }

        private void btnSetRailCircuitCoordinates_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Rail circuit configuration is going to be changed");
            var changeRailCircuitConfig = new circuitConfigSelectDialog(RailWay.wayCircuitConfig, RailWay.wayCircuitConfigPoints);
            changeRailCircuitConfig.ShowDialog();
            if (changeRailCircuitConfig.DialogResult == DialogResult.OK)
            {
                switch (changeRailCircuitConfig.railCircuitConfig)
                {
                    case CircuitConfig.FirstOverlay:
                        changeCircuitConfig(CircuitConfig.FirstOverlay, Properties.Resources.OverlayFirst);
                        break;
                    case CircuitConfig.SecondOverlay:
                        changeCircuitConfig(CircuitConfig.SecondOverlay, Properties.Resources.OverlaySecond);
                        break;
                    case CircuitConfig.NoOverlay:
                        changeCircuitConfig(CircuitConfig.NoOverlay, Properties.Resources.NoOverlay);
                        break;
                }
                Array.Copy(changeRailCircuitConfig.points, RailWay.wayCircuitConfigPoints, AppConstants.NUM_OF_POINTS);
                this.updateCircuitConfigPoints();
                RailWay.print();
            }
        }

        private void changeCircuitConfig(CircuitConfig config, Bitmap image)
        {
            RailWay.wayCircuitConfig = config;
            this.wayConfigImagePanel.BackgroundImage = image;
            this.wayConfigImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
            System.Console.WriteLine("Rail circuit configuration changed to " + config.GetType().ToString());
        }

    }
}
