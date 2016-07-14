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
    public partial class DigitalRailCircuitUserControl : UserControl
    {
        public DigitalRailCircuitUserControl()
        {
            InitializeComponent();
        }

        public DigitalRailCircuitUserControl(int pin, int port)
        {
            InitializeComponent();
            this.editPin.Text = pin.ToString();
            this.editPort.Text = port.ToString();
        }

        public int getPin()
        {
            return Convert.ToInt32(((this.editPin.Text == "") || (this.editPin.Text == "-")) ? "0" : this.editPin.Text);
        }
        public int getPort()
        {
            return Convert.ToInt32(((this.editPort.Text == "") || (this.editPort.Text == "-")) ? "0" : this.editPort.Text);
        }
    }
}
