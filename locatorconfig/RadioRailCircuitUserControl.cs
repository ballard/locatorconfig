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
    public partial class RadioRailCircuitUserControl : UserControl
    {
        public RadioRailCircuitUserControl()
        {
            InitializeComponent();
        }
        public double getFrequency()
        {
            return Convert.ToDouble(((this.editFrequency.Text == "") || (this.editFrequency.Text == "-")) ? "0" : this.editFrequency.Text);
        }
    }
}
