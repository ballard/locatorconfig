namespace locatorconfig
{
    partial class RadioRailCircuitUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DigitalRailChainPanel = new System.Windows.Forms.Panel();
            this.DigitalRailChainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.editFrequency = new System.Windows.Forms.NumericUpDown();
            this.DigitalRailChainPanel.SuspendLayout();
            this.DigitalRailChainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // DigitalRailChainPanel
            // 
            this.DigitalRailChainPanel.AutoScroll = true;
            this.DigitalRailChainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DigitalRailChainPanel.Controls.Add(this.DigitalRailChainTableLayout);
            this.DigitalRailChainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DigitalRailChainPanel.Location = new System.Drawing.Point(0, 0);
            this.DigitalRailChainPanel.Name = "DigitalRailChainPanel";
            this.DigitalRailChainPanel.Size = new System.Drawing.Size(560, 151);
            this.DigitalRailChainPanel.TabIndex = 1;
            // 
            // DigitalRailChainTableLayout
            // 
            this.DigitalRailChainTableLayout.ColumnCount = 2;
            this.DigitalRailChainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DigitalRailChainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DigitalRailChainTableLayout.Controls.Add(this.label1, 0, 0);
            this.DigitalRailChainTableLayout.Controls.Add(this.label2, 0, 1);
            this.DigitalRailChainTableLayout.Controls.Add(this.label5, 0, 2);
            this.DigitalRailChainTableLayout.Controls.Add(this.label7, 1, 0);
            this.DigitalRailChainTableLayout.Controls.Add(this.label8, 1, 1);
            this.DigitalRailChainTableLayout.Controls.Add(this.editFrequency, 1, 2);
            this.DigitalRailChainTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.DigitalRailChainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.DigitalRailChainTableLayout.Name = "DigitalRailChainTableLayout";
            this.DigitalRailChainTableLayout.RowCount = 3;
            this.DigitalRailChainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DigitalRailChainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DigitalRailChainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DigitalRailChainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DigitalRailChainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DigitalRailChainTableLayout.Size = new System.Drawing.Size(560, 151);
            this.DigitalRailChainTableLayout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование параметра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сигнал";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "Частота, Гц";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(283, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "Значение";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(283, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 50);
            this.label8.TabIndex = 7;
            this.label8.Text = "Радио";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editFrequency
            // 
            this.editFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editFrequency.DecimalPlaces = 2;
            this.editFrequency.Location = new System.Drawing.Point(283, 115);
            this.editFrequency.Name = "editFrequency";
            this.editFrequency.Size = new System.Drawing.Size(274, 20);
            this.editFrequency.TabIndex = 8;
            // 
            // RadioRailCircuitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DigitalRailChainPanel);
            this.Name = "RadioRailCircuitUserControl";
            this.Size = new System.Drawing.Size(560, 151);
            this.DigitalRailChainPanel.ResumeLayout(false);
            this.DigitalRailChainTableLayout.ResumeLayout(false);
            this.DigitalRailChainTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DigitalRailChainPanel;
        private System.Windows.Forms.TableLayoutPanel DigitalRailChainTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown editFrequency;
    }
}
