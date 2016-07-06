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
            //else {
            //    System.Console.WriteLine("control type is: " + control.GetType().ToString());
            //    switch (control.GetType().ToString())
            //    {
            //        case "System.Windows.Forms.TextBox":
            //            control.TextChanged += new EventHandler(controlOnTextChanged);
            //            break;
            //        case "System.Windows.Forms.ComboBox":
            //            control.TextChanged += new EventHandler(controlOnTextChanged);
            //            break;
            //        case "System.Windows.Forms.NumericUpDown":
            //            control.TextChanged += new EventHandler(controlOnTextChanged);
            //            break;

            //        default:
            //            break;
            //    }
            //}
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
                        this.tabRailChain.TabPages.Remove(this.tabRailChain.SelectedTab);
                        var ucRadio = new RadioRailCircuitUserControl();
                        initialSetupControls(ucRadio);
                        ucRadio.Dock = DockStyle.Fill;
                        var tpRadio = new TabPage(String.Format(AppConstants.RAIL_CHAIN_STRING, currentTabIndex + 1));
                        tpRadio.Controls.Add(ucRadio);
                        this.tabRailChain.TabPages.Insert(currentTabIndex, tpRadio);
                        RailWay.changeRailCircuitType(currentTabIndex, RailCircuitType.Radio);
                        this.tabRailChain.SelectTab(currentTabIndex);
                        updateModel();
                    }
                    break;
                case RailCircuitType.Radio:
                    var changeRailTypeRadio = new RailCircuitTypeDialog(RailCircuitType.Radio);
                    changeRailTypeRadio.ShowDialog();
                    if (changeRailTypeRadio.DialogResult == DialogResult.OK)
                    {
                        this.tabRailChain.TabPages.Remove(this.tabRailChain.SelectedTab);
                        var ucDigital = new DigitalRailCircuitUserControl();
                        initialSetupControls(ucDigital);
                        ucDigital.Dock = DockStyle.Fill;
                        var tpDigital = new TabPage(String.Format(AppConstants.RAIL_CHAIN_STRING, currentTabIndex + 1));
                        tpDigital.Controls.Add(ucDigital);
                        this.tabRailChain.TabPages.Insert(currentTabIndex, tpDigital);
                        RailWay.changeRailCircuitType(currentTabIndex, RailCircuitType.Digital);
                        this.tabRailChain.SelectTab(currentTabIndex);
                        updateModel();
                    }
                    break;
            }
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
                        var digtalCircuitControl = (DigitalRailCircuitUserControl)tabRailChain.TabPages[i].Controls[0];
                        var digitalCircuit = new DigitalRailCircuit();
                        digitalCircuit.pinNumber = digtalCircuitControl.getPin();
                        digitalCircuit.portNumber = digtalCircuitControl.getPort();
                        RailWay.sensors[i] = digitalCircuit;
                        break;
                    case RailCircuitType.Radio:
                        var radioCircuitControl = (RadioRailCircuitUserControl)tabRailChain.TabPages[i].Controls[0];
                        var radioCircuit = new RadioRailCircuit();
                        radioCircuit.frequency = radioCircuitControl.getFrequency();
                        RailWay.sensors[i] = radioCircuit;
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
                        RailWay.wayCircuitConfig = CircuitConfig.FirstOverlay;
                        this.wayConfigImagePanel.BackgroundImage = Properties.Resources.OverlayFirst;
                        this.wayConfigImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
                        System.Console.WriteLine("Rail circuit configuration changed to first overlay");
                        break;
                    case CircuitConfig.SecondOverlay:
                        RailWay.wayCircuitConfig = CircuitConfig.SecondOverlay;
                        this.wayConfigImagePanel.BackgroundImage = Properties.Resources.OverlaySecond;
                        this.wayConfigImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
                        System.Console.WriteLine("Rail circuit configuration changed to second overlay");
                        break;
                    case CircuitConfig.NoOverlay:
                        RailWay.wayCircuitConfig = CircuitConfig.NoOverlay;
                        this.wayConfigImagePanel.BackgroundImage = Properties.Resources.NoOverlay;
                        this.wayConfigImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
                        System.Console.WriteLine("Rail circuit configuration changed to no overlay");
                        break;
                }
                Array.Copy(changeRailCircuitConfig.points, RailWay.wayCircuitConfigPoints, AppConstants.NUM_OF_POINTS);
                this.updateCircuitConfigPoints();
                RailWay.print();
            }
        }
    }
}
