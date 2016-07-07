namespace locatorconfig
{
    partial class circuitConfigSelectDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(circuitConfigSelectDialog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonFirstOverlay = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondOverlay = new System.Windows.Forms.RadioButton();
            this.radioButtonNoOverlay = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPointA = new System.Windows.Forms.NumericUpDown();
            this.textBoxPointB = new System.Windows.Forms.NumericUpDown();
            this.textBoxPointC = new System.Windows.Forms.NumericUpDown();
            this.textBoxPointD = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 592);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Варианты конфигурации";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonFirstOverlay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonSecondOverlay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonNoOverlay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonFirstOverlay
            // 
            this.radioButtonFirstOverlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonFirstOverlay.AutoSize = true;
            this.radioButtonFirstOverlay.Location = new System.Drawing.Point(3, 86);
            this.radioButtonFirstOverlay.Name = "radioButtonFirstOverlay";
            this.radioButtonFirstOverlay.Size = new System.Drawing.Size(76, 17);
            this.radioButtonFirstOverlay.TabIndex = 0;
            this.radioButtonFirstOverlay.TabStop = true;
            this.radioButtonFirstOverlay.Text = "Вариант 1";
            this.radioButtonFirstOverlay.UseVisualStyleBackColor = true;
            this.radioButtonFirstOverlay.CheckedChanged += new System.EventHandler(this.radioButtonFirstOverlay_CheckedChanged);
            // 
            // radioButtonSecondOverlay
            // 
            this.radioButtonSecondOverlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonSecondOverlay.AutoSize = true;
            this.radioButtonSecondOverlay.Location = new System.Drawing.Point(3, 277);
            this.radioButtonSecondOverlay.Name = "radioButtonSecondOverlay";
            this.radioButtonSecondOverlay.Size = new System.Drawing.Size(76, 17);
            this.radioButtonSecondOverlay.TabIndex = 2;
            this.radioButtonSecondOverlay.TabStop = true;
            this.radioButtonSecondOverlay.Text = "Вариант 2";
            this.radioButtonSecondOverlay.UseVisualStyleBackColor = true;
            this.radioButtonSecondOverlay.CheckedChanged += new System.EventHandler(this.radioButtonSecondOverlay_CheckedChanged);
            // 
            // radioButtonNoOverlay
            // 
            this.radioButtonNoOverlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonNoOverlay.AutoSize = true;
            this.radioButtonNoOverlay.Location = new System.Drawing.Point(3, 468);
            this.radioButtonNoOverlay.Name = "radioButtonNoOverlay";
            this.radioButtonNoOverlay.Size = new System.Drawing.Size(76, 17);
            this.radioButtonNoOverlay.TabIndex = 1;
            this.radioButtonNoOverlay.TabStop = true;
            this.radioButtonNoOverlay.Text = "Вариант 3";
            this.radioButtonNoOverlay.UseVisualStyleBackColor = true;
            this.radioButtonNoOverlay.CheckedChanged += new System.EventHandler(this.radioButtonNoOverlay_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 184);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::locatorconfig.Properties.Resources.OverlaySecond;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(97, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 185);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::locatorconfig.Properties.Resources.NoOverlay;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(97, 384);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(372, 186);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(408, 627);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(327, 627);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Точка А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Точка Б";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Точка В";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Точка Г";
            // 
            // textBoxPointA
            // 
            this.textBoxPointA.Location = new System.Drawing.Point(66, 7);
            this.textBoxPointA.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.textBoxPointA.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.textBoxPointA.Name = "textBoxPointA";
            this.textBoxPointA.Size = new System.Drawing.Size(59, 20);
            this.textBoxPointA.TabIndex = 11;
            this.textBoxPointA.ValueChanged += new System.EventHandler(this.textBoxPointA_ValueChanged);
            // 
            // textBoxPointB
            // 
            this.textBoxPointB.Location = new System.Drawing.Point(185, 7);
            this.textBoxPointB.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.textBoxPointB.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.textBoxPointB.Name = "textBoxPointB";
            this.textBoxPointB.Size = new System.Drawing.Size(59, 20);
            this.textBoxPointB.TabIndex = 12;
            this.textBoxPointB.ValueChanged += new System.EventHandler(this.textBoxPointB_ValueChanged);
            // 
            // textBoxPointC
            // 
            this.textBoxPointC.Location = new System.Drawing.Point(304, 7);
            this.textBoxPointC.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.textBoxPointC.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.textBoxPointC.Name = "textBoxPointC";
            this.textBoxPointC.Size = new System.Drawing.Size(59, 20);
            this.textBoxPointC.TabIndex = 13;
            this.textBoxPointC.ValueChanged += new System.EventHandler(this.textBoxPointC_ValueChanged);
            // 
            // textBoxPointD
            // 
            this.textBoxPointD.Location = new System.Drawing.Point(422, 7);
            this.textBoxPointD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.textBoxPointD.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.textBoxPointD.Name = "textBoxPointD";
            this.textBoxPointD.Size = new System.Drawing.Size(65, 20);
            this.textBoxPointD.TabIndex = 14;
            this.textBoxPointD.ValueChanged += new System.EventHandler(this.textBoxPointD_ValueChanged);
            // 
            // circuitConfigSelectDialog
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(496, 658);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPointD);
            this.Controls.Add(this.textBoxPointC);
            this.Controls.Add(this.textBoxPointB);
            this.Controls.Add(this.textBoxPointA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "circuitConfigSelectDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор конфигурации РЦ";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPointD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSecondOverlay;
        private System.Windows.Forms.RadioButton radioButtonNoOverlay;
        private System.Windows.Forms.RadioButton radioButtonFirstOverlay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown textBoxPointA;
        private System.Windows.Forms.NumericUpDown textBoxPointB;
        private System.Windows.Forms.NumericUpDown textBoxPointC;
        private System.Windows.Forms.NumericUpDown textBoxPointD;
    }
}