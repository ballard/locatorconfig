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
        public event EventHandler ContentChanged;
        public RadioRailCircuitUserControl()
        {
            InitializeComponent();
        }
        public int getFrequency()
        {
            return Convert.ToInt32((this.editFrequency.Text == "") ? "0" : this.editFrequency.Text);
        }
        private void editFrequency_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, new EventArgs());
        }
    }
}
