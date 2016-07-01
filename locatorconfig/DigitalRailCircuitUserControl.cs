﻿using System;
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
        public event EventHandler ContentChanged;

        public DigitalRailCircuitUserControl()
        {
            InitializeComponent();
        }
        public int getPin()
        {
            return Convert.ToInt32((this.editPin.Text == "") ? "0" : this.editPin.Text);
        }
        public int getPort()
        {
            return Convert.ToInt32((this.editPort.Text == "") ? "0" : this.editPort.Text);
        }
        private void editPort_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, new EventArgs());
        }
        private void editPin_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, new EventArgs());
        }
    }
}