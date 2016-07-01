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
    public partial class RailCircuitTypeDialog : Form
    {
        public RailCircuitType railCircuitType { get; set; }
        private RailCircuitType orginalRailCircuitType;
        public RailCircuitTypeDialog()
        {
            InitializeComponent();
        }
        public RailCircuitTypeDialog(RailCircuitType railChain)
        {
            InitializeComponent();
            switch (railChain)
            {
                case RailCircuitType.Digital:
                    this.railCircuitType = RailCircuitType.Digital;
                    this.orginalRailCircuitType = RailCircuitType.Digital;
                    if (rbTypeDigital.Checked == false)
                    {
                        rbTypeDigital.Checked = true;
                        rbTypeRadio.Checked = false;
                    }
                    break;
                case RailCircuitType.Radio:
                    this.railCircuitType = RailCircuitType.Radio;
                    this.orginalRailCircuitType = RailCircuitType.Radio;
                    if (rbTypeRadio.Checked == false)
                    {
                        rbTypeRadio.Checked = true;
                        rbTypeDigital.Checked = false;
                    }
                    break;
            }
        }
        private void rbTypeDigital_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbTypeDigital.Checked)
                this.railCircuitType = RailCircuitType.Digital;
        }
        private void rbTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbTypeRadio.Checked)
                this.railCircuitType = RailCircuitType.Radio;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (this.orginalRailCircuitType != this.railCircuitType)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}
