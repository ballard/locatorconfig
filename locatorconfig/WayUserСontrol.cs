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
            cbxDirection.SelectedIndex = 0;
            for (var i = 0; i < AppConstants.NUM_OF_SENSORS; i++)
            {
                var uc = new DigitalRailCircuitUserControl();
                uc.Dock = DockStyle.Fill;
                var tp = new TabPage(String.Format(AppConstants.RAIL_CHAIN_STRING, i + 1));
                tp.Controls.Add(uc);
                this.tabRailChain.TabPages.Add(tp);
            }
            this.updateCircuitConfigPoints();
            this.wayConfigImagePanel.BackgroundImage = Properties.Resources.OverlayFirst;
            this.wayConfigImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
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
                    uc = new DigitalRailCircuitUserControl();
                    break;
                case RailCircuitType.Radio:
                    uc = new RadioRailCircuitUserControl();
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
        private void updateModel()
        {
            System.Console.WriteLine("Model updated");
            RailWay.direction = cbxDirection.SelectedIndex + 1;
            RailWay.delayLR = Convert.ToDouble((tbxDelayLR.Text == "") ? "0" : tbxDelayLR.Text);
            RailWay.delayRL = Convert.ToDouble((tbxDelayRL.Text == "") ? "0" : tbxDelayRL.Text);
            RailWay.maxSpeedLR = Convert.ToDouble((tbxMaxSpeedLR.Text == "") ? "0" : tbxMaxSpeedLR.Text);
            RailWay.maxSpeedRL = Convert.ToDouble((tbxMaxSpeedRL.Text == "") ? "0" : tbxMaxSpeedRL.Text);
            RailWay.timeCounterWrongL = Convert.ToDouble((tbxTimeCounterWrongL.Text == "") ? "0" : tbxTimeCounterWrongL.Text);
            RailWay.timeCounterWrongR = Convert.ToDouble((tbxTimeCounterWrongR.Text == "") ? "0" : tbxTimeCounterWrongR.Text);
            RailWay.timeNotificationTrainNotExitRL = Convert.ToDouble((tbxTimeNotificationTrainNotExitRL.Text == "") ? "0" : tbxTimeNotificationTrainNotExitRL.Text);
            RailWay.timeNotificationTrainNotExitLR = Convert.ToDouble((tbxTimeNotificationTrainNotExitLR.Text == "") ? "0" : tbxTimeNotificationTrainNotExitLR.Text);
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
