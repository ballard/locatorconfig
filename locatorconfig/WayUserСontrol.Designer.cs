namespace locatorconfig
{
    partial class WayUserСontrol
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeRailType = new System.Windows.Forms.Button();
            this.tabRailChain = new System.Windows.Forms.TabControl();
            this.btnSetRailCircuitCoordinates = new System.Windows.Forms.Button();
            this.WayParametersPanel = new System.Windows.Forms.Panel();
            this.tblWayParameters = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxDirection = new System.Windows.Forms.ComboBox();
            this.tbxDelayLR = new System.Windows.Forms.NumericUpDown();
            this.tbxDelayRL = new System.Windows.Forms.NumericUpDown();
            this.tbxMaxSpeedLR = new System.Windows.Forms.NumericUpDown();
            this.tbxMaxSpeedRL = new System.Windows.Forms.NumericUpDown();
            this.tbxTimeCounterWrongL = new System.Windows.Forms.NumericUpDown();
            this.tbxTimeCounterWrongR = new System.Windows.Forms.NumericUpDown();
            this.tbxTimeNotificationTrainNotExitRL = new System.Windows.Forms.NumericUpDown();
            this.tbxTimeNotificationTrainNotExitLR = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.wayConfigImagePanel = new System.Windows.Forms.Panel();
            this.lblPointA = new System.Windows.Forms.Label();
            this.lblPointB = new System.Windows.Forms.Label();
            this.lblPointC = new System.Windows.Forms.Label();
            this.lblPointD = new System.Windows.Forms.Label();
            this.mainTable.SuspendLayout();
            this.WayParametersPanel.SuspendLayout();
            this.tblWayParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDelayLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDelayRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMaxSpeedLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMaxSpeedRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeCounterWrongL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeCounterWrongR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeNotificationTrainNotExitRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeNotificationTrainNotExitLR)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 4;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Controls.Add(this.btnChangeRailType, 0, 2);
            this.mainTable.Controls.Add(this.tabRailChain, 0, 1);
            this.mainTable.Controls.Add(this.btnSetRailCircuitCoordinates, 1, 2);
            this.mainTable.Controls.Add(this.WayParametersPanel, 0, 0);
            this.mainTable.Controls.Add(this.tableLayoutPanel1, 3, 1);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 3;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTable.Size = new System.Drawing.Size(839, 663);
            this.mainTable.TabIndex = 0;
            // 
            // btnChangeRailType
            // 
            this.btnChangeRailType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeRailType.Location = new System.Drawing.Point(3, 625);
            this.btnChangeRailType.Name = "btnChangeRailType";
            this.btnChangeRailType.Size = new System.Drawing.Size(77, 35);
            this.btnChangeRailType.TabIndex = 0;
            this.btnChangeRailType.Text = "Изменить тип РЦ";
            this.btnChangeRailType.UseVisualStyleBackColor = true;
            this.btnChangeRailType.Click += new System.EventHandler(this.btnChangeRailType_Click);
            // 
            // tabRailChain
            // 
            this.mainTable.SetColumnSpan(this.tabRailChain, 3);
            this.tabRailChain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRailChain.Location = new System.Drawing.Point(3, 314);
            this.tabRailChain.Name = "tabRailChain";
            this.tabRailChain.SelectedIndex = 0;
            this.tabRailChain.Size = new System.Drawing.Size(411, 305);
            this.tabRailChain.TabIndex = 2;
            // 
            // btnSetRailCircuitCoordinates
            // 
            this.btnSetRailCircuitCoordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetRailCircuitCoordinates.Location = new System.Drawing.Point(86, 625);
            this.btnSetRailCircuitCoordinates.Name = "btnSetRailCircuitCoordinates";
            this.btnSetRailCircuitCoordinates.Size = new System.Drawing.Size(77, 35);
            this.btnSetRailCircuitCoordinates.TabIndex = 3;
            this.btnSetRailCircuitCoordinates.Text = "Задать координаты РЦ";
            this.btnSetRailCircuitCoordinates.UseVisualStyleBackColor = true;
            this.btnSetRailCircuitCoordinates.Click += new System.EventHandler(this.btnSetRailCircuitCoordinates_Click);
            // 
            // WayParametersPanel
            // 
            this.WayParametersPanel.AutoScroll = true;
            this.WayParametersPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTable.SetColumnSpan(this.WayParametersPanel, 4);
            this.WayParametersPanel.Controls.Add(this.tblWayParameters);
            this.WayParametersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WayParametersPanel.Location = new System.Drawing.Point(3, 3);
            this.WayParametersPanel.Name = "WayParametersPanel";
            this.WayParametersPanel.Size = new System.Drawing.Size(833, 305);
            this.WayParametersPanel.TabIndex = 5;
            // 
            // tblWayParameters
            // 
            this.tblWayParameters.AutoSize = true;
            this.tblWayParameters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblWayParameters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblWayParameters.ColumnCount = 2;
            this.tblWayParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblWayParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblWayParameters.Controls.Add(this.label2, 1, 0);
            this.tblWayParameters.Controls.Add(this.label1, 0, 0);
            this.tblWayParameters.Controls.Add(this.label3, 0, 1);
            this.tblWayParameters.Controls.Add(this.label4, 0, 2);
            this.tblWayParameters.Controls.Add(this.label5, 0, 3);
            this.tblWayParameters.Controls.Add(this.label6, 0, 4);
            this.tblWayParameters.Controls.Add(this.label7, 0, 5);
            this.tblWayParameters.Controls.Add(this.label8, 0, 6);
            this.tblWayParameters.Controls.Add(this.label9, 0, 7);
            this.tblWayParameters.Controls.Add(this.label10, 0, 8);
            this.tblWayParameters.Controls.Add(this.label11, 0, 9);
            this.tblWayParameters.Controls.Add(this.cbxDirection, 1, 1);
            this.tblWayParameters.Controls.Add(this.tbxDelayLR, 1, 2);
            this.tblWayParameters.Controls.Add(this.tbxDelayRL, 1, 3);
            this.tblWayParameters.Controls.Add(this.tbxMaxSpeedLR, 1, 4);
            this.tblWayParameters.Controls.Add(this.tbxMaxSpeedRL, 1, 5);
            this.tblWayParameters.Controls.Add(this.tbxTimeCounterWrongL, 1, 6);
            this.tblWayParameters.Controls.Add(this.tbxTimeCounterWrongR, 1, 7);
            this.tblWayParameters.Controls.Add(this.tbxTimeNotificationTrainNotExitRL, 1, 8);
            this.tblWayParameters.Controls.Add(this.tbxTimeNotificationTrainNotExitLR, 1, 9);
            this.tblWayParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblWayParameters.Location = new System.Drawing.Point(0, 0);
            this.tblWayParameters.Name = "tblWayParameters";
            this.tblWayParameters.RowCount = 10;
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblWayParameters.Size = new System.Drawing.Size(833, 291);
            this.tblWayParameters.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(710, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование параметра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(699, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Правильное направление";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(4, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(699, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Задержка, после которой выдавать извещение с направления L->R, сек";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(4, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(699, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Задержка, после которой выдавать извещение с направления L<-R, сек";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(4, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(699, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Максимальная скорость с направления L->R, м/сек";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(4, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(699, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Максимальная скорость с направления L<-R, м/сек";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(4, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(699, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Время, через которое ожидать встречный по неправильному с L, сек";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(4, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(699, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Время, через которое ожидать встречный по неправильному с R, сек";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(4, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(699, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "Время, через которое выдавать извещение, если поезд не вышел за РЦ границы удален" +
    "ия контролируемого участка с направления L<-R, сек";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(4, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(699, 28);
            this.label11.TabIndex = 11;
            this.label11.Text = "Время, через которое выдавать извещение, если поезд не вышел за РЦ границы удален" +
    "ия контролируемого участка с направления L->R, сек";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDirection
            // 
            this.cbxDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDirection.FormattingEnabled = true;
            this.cbxDirection.Items.AddRange(new object[] {
            "->",
            "<-"});
            this.cbxDirection.Location = new System.Drawing.Point(710, 33);
            this.cbxDirection.Name = "cbxDirection";
            this.cbxDirection.Size = new System.Drawing.Size(119, 21);
            this.cbxDirection.TabIndex = 12;
            // 
            // tbxDelayLR
            // 
            this.tbxDelayLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDelayLR.DecimalPlaces = 2;
            this.tbxDelayLR.Location = new System.Drawing.Point(710, 63);
            this.tbxDelayLR.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxDelayLR.Name = "tbxDelayLR";
            this.tbxDelayLR.Size = new System.Drawing.Size(119, 20);
            this.tbxDelayLR.TabIndex = 21;
            // 
            // tbxDelayRL
            // 
            this.tbxDelayRL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDelayRL.DecimalPlaces = 2;
            this.tbxDelayRL.Location = new System.Drawing.Point(710, 92);
            this.tbxDelayRL.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxDelayRL.Name = "tbxDelayRL";
            this.tbxDelayRL.Size = new System.Drawing.Size(119, 20);
            this.tbxDelayRL.TabIndex = 22;
            // 
            // tbxMaxSpeedLR
            // 
            this.tbxMaxSpeedLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMaxSpeedLR.DecimalPlaces = 2;
            this.tbxMaxSpeedLR.Location = new System.Drawing.Point(710, 121);
            this.tbxMaxSpeedLR.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxMaxSpeedLR.Name = "tbxMaxSpeedLR";
            this.tbxMaxSpeedLR.Size = new System.Drawing.Size(119, 20);
            this.tbxMaxSpeedLR.TabIndex = 23;
            // 
            // tbxMaxSpeedRL
            // 
            this.tbxMaxSpeedRL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMaxSpeedRL.DecimalPlaces = 2;
            this.tbxMaxSpeedRL.Location = new System.Drawing.Point(710, 150);
            this.tbxMaxSpeedRL.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxMaxSpeedRL.Name = "tbxMaxSpeedRL";
            this.tbxMaxSpeedRL.Size = new System.Drawing.Size(119, 20);
            this.tbxMaxSpeedRL.TabIndex = 24;
            // 
            // tbxTimeCounterWrongL
            // 
            this.tbxTimeCounterWrongL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimeCounterWrongL.DecimalPlaces = 2;
            this.tbxTimeCounterWrongL.Location = new System.Drawing.Point(710, 179);
            this.tbxTimeCounterWrongL.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxTimeCounterWrongL.Name = "tbxTimeCounterWrongL";
            this.tbxTimeCounterWrongL.Size = new System.Drawing.Size(119, 20);
            this.tbxTimeCounterWrongL.TabIndex = 25;
            // 
            // tbxTimeCounterWrongR
            // 
            this.tbxTimeCounterWrongR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimeCounterWrongR.DecimalPlaces = 2;
            this.tbxTimeCounterWrongR.Location = new System.Drawing.Point(710, 208);
            this.tbxTimeCounterWrongR.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxTimeCounterWrongR.Name = "tbxTimeCounterWrongR";
            this.tbxTimeCounterWrongR.Size = new System.Drawing.Size(119, 20);
            this.tbxTimeCounterWrongR.TabIndex = 26;
            // 
            // tbxTimeNotificationTrainNotExitRL
            // 
            this.tbxTimeNotificationTrainNotExitRL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimeNotificationTrainNotExitRL.DecimalPlaces = 2;
            this.tbxTimeNotificationTrainNotExitRL.Location = new System.Drawing.Point(710, 237);
            this.tbxTimeNotificationTrainNotExitRL.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxTimeNotificationTrainNotExitRL.Name = "tbxTimeNotificationTrainNotExitRL";
            this.tbxTimeNotificationTrainNotExitRL.Size = new System.Drawing.Size(119, 20);
            this.tbxTimeNotificationTrainNotExitRL.TabIndex = 27;
            // 
            // tbxTimeNotificationTrainNotExitLR
            // 
            this.tbxTimeNotificationTrainNotExitLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimeNotificationTrainNotExitLR.DecimalPlaces = 2;
            this.tbxTimeNotificationTrainNotExitLR.Location = new System.Drawing.Point(710, 266);
            this.tbxTimeNotificationTrainNotExitLR.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbxTimeNotificationTrainNotExitLR.Name = "tbxTimeNotificationTrainNotExitLR";
            this.tbxTimeNotificationTrainNotExitLR.Size = new System.Drawing.Size(119, 20);
            this.tbxTimeNotificationTrainNotExitLR.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.wayConfigImagePanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPointA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPointB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPointC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPointD, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(420, 314);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 305);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // wayConfigImagePanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.wayConfigImagePanel, 4);
            this.wayConfigImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wayConfigImagePanel.Location = new System.Drawing.Point(3, 38);
            this.wayConfigImagePanel.Name = "wayConfigImagePanel";
            this.wayConfigImagePanel.Size = new System.Drawing.Size(410, 264);
            this.wayConfigImagePanel.TabIndex = 0;
            // 
            // lblPointA
            // 
            this.lblPointA.AutoSize = true;
            this.lblPointA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPointA.Location = new System.Drawing.Point(3, 0);
            this.lblPointA.Name = "lblPointA";
            this.lblPointA.Size = new System.Drawing.Size(98, 35);
            this.lblPointA.TabIndex = 1;
            this.lblPointA.Text = "А:";
            this.lblPointA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointB
            // 
            this.lblPointB.AutoSize = true;
            this.lblPointB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPointB.Location = new System.Drawing.Point(107, 0);
            this.lblPointB.Name = "lblPointB";
            this.lblPointB.Size = new System.Drawing.Size(98, 35);
            this.lblPointB.TabIndex = 2;
            this.lblPointB.Text = "Б:";
            this.lblPointB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointC
            // 
            this.lblPointC.AutoSize = true;
            this.lblPointC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPointC.Location = new System.Drawing.Point(211, 0);
            this.lblPointC.Name = "lblPointC";
            this.lblPointC.Size = new System.Drawing.Size(98, 35);
            this.lblPointC.TabIndex = 3;
            this.lblPointC.Text = "В:";
            this.lblPointC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointD
            // 
            this.lblPointD.AutoSize = true;
            this.lblPointD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPointD.Location = new System.Drawing.Point(315, 0);
            this.lblPointD.Name = "lblPointD";
            this.lblPointD.Size = new System.Drawing.Size(98, 35);
            this.lblPointD.TabIndex = 4;
            this.lblPointD.Text = "Г:";
            this.lblPointD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WayUserСontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Name = "WayUserСontrol";
            this.Size = new System.Drawing.Size(839, 663);
            this.mainTable.ResumeLayout(false);
            this.WayParametersPanel.ResumeLayout(false);
            this.WayParametersPanel.PerformLayout();
            this.tblWayParameters.ResumeLayout(false);
            this.tblWayParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDelayLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDelayRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMaxSpeedLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMaxSpeedRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeCounterWrongL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeCounterWrongR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeNotificationTrainNotExitRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTimeNotificationTrainNotExitLR)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.Button btnChangeRailType;
        private System.Windows.Forms.TabControl tabRailChain;
        private System.Windows.Forms.Button btnSetRailCircuitCoordinates;
        private System.Windows.Forms.TableLayoutPanel tblWayParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel WayParametersPanel;
        private System.Windows.Forms.ComboBox cbxDirection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel wayConfigImagePanel;
        private System.Windows.Forms.Label lblPointA;
        private System.Windows.Forms.Label lblPointB;
        private System.Windows.Forms.Label lblPointC;
        private System.Windows.Forms.Label lblPointD;
        private System.Windows.Forms.NumericUpDown tbxDelayLR;
        private System.Windows.Forms.NumericUpDown tbxDelayRL;
        private System.Windows.Forms.NumericUpDown tbxMaxSpeedLR;
        private System.Windows.Forms.NumericUpDown tbxMaxSpeedRL;
        private System.Windows.Forms.NumericUpDown tbxTimeCounterWrongL;
        private System.Windows.Forms.NumericUpDown tbxTimeCounterWrongR;
        private System.Windows.Forms.NumericUpDown tbxTimeNotificationTrainNotExitRL;
        private System.Windows.Forms.NumericUpDown tbxTimeNotificationTrainNotExitLR;
    }
}
