using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locatorconfig
{
    public partial class circuitConfigSelectDialog : Form
    {
        public CircuitConfig railCircuitConfig { get; set; }
        public double[] points { get; }
        public circuitConfigSelectDialog()
        {
            InitializeComponent();
        }
        
        public circuitConfigSelectDialog(CircuitConfig config, double[] points)
        {
            InitializeComponent();
            switch (config)
            {
                case CircuitConfig.FirstOverlay:
                    this.railCircuitConfig = CircuitConfig.FirstOverlay;
                    if (radioButtonFirstOverlay.Checked == false)
                    {
                        radioButtonFirstOverlay.Checked = true;
                        radioButtonSecondOverlay.Checked = false;
                        radioButtonNoOverlay.Checked = false;
                    }
                    break;
                case CircuitConfig.SecondOverlay:
                    this.railCircuitConfig = CircuitConfig.SecondOverlay;
                    if (radioButtonSecondOverlay.Checked == false)
                    {
                        radioButtonFirstOverlay.Checked = false;
                        radioButtonSecondOverlay.Checked = true;
                        radioButtonNoOverlay.Checked = false;
                    }
                    break;
                case CircuitConfig.NoOverlay:
                    this.railCircuitConfig = CircuitConfig.NoOverlay;
                    if (radioButtonNoOverlay.Checked == false)
                    {
                        radioButtonFirstOverlay.Checked = false;
                        radioButtonSecondOverlay.Checked = false;
                        radioButtonNoOverlay.Checked = true;
                    }
                    break;
            }
            if (points.Count() >= 4)
            {
                this.textBoxPointA.Text = String.Format(points[0].ToString());
                this.textBoxPointB.Text = String.Format(points[1].ToString());
                this.textBoxPointC.Text = String.Format(points[2].ToString());
                this.textBoxPointD.Text = String.Format(points[3].ToString());
                this.points = new double[AppConstants.NUM_OF_POINTS];
                Array.Copy(points, this.points, AppConstants.NUM_OF_POINTS);
            }

            textBoxPointA.Controls.RemoveAt(0);
            textBoxPointB.Controls.RemoveAt(0);
            textBoxPointC.Controls.RemoveAt(0);
            textBoxPointD.Controls.RemoveAt(0);
        }

        private void radioButtonFirstOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFirstOverlay.Checked)
            {
                railCircuitConfig = CircuitConfig.FirstOverlay;
            }
        }

        private void radioButtonSecondOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSecondOverlay.Checked)
            {
                railCircuitConfig = CircuitConfig.SecondOverlay;
            }
        }

        private void radioButtonNoOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoOverlay.Checked)
            {
                railCircuitConfig = CircuitConfig.NoOverlay;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }        

        private void textBoxPointA_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsHandleCreated)
                this.points[0] = Convert.ToInt32(((this.textBoxPointA.Text == "") || (this.textBoxPointA.Text == "-")) ? "0" : this.textBoxPointA.Text);
        }

        private void textBoxPointB_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsHandleCreated)
                this.points[1] = Convert.ToInt32(((this.textBoxPointB.Text == "") || (this.textBoxPointB.Text == "-")) ? "0" : this.textBoxPointB.Text);
        }

        private void textBoxPointC_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsHandleCreated)
                this.points[2] = Convert.ToInt32(((this.textBoxPointC.Text == "") || (this.textBoxPointC.Text == "-")) ? "0" : this.textBoxPointC.Text);
        }

        private void textBoxPointD_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsHandleCreated)
                this.points[3] = Convert.ToInt32(((this.textBoxPointD.Text == "") || (this.textBoxPointD.Text == "-")) ? "0" : this.textBoxPointD.Text);
        }
    }
}
