namespace locatorconfig
{
    partial class RailCircuitTypeDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTypeRadio = new System.Windows.Forms.RadioButton();
            this.rbTypeDigital = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTypeRadio);
            this.groupBox1.Controls.Add(this.rbTypeDigital);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите тип рельсовой цепи:";
            // 
            // rbTypeRadio
            // 
            this.rbTypeRadio.AutoSize = true;
            this.rbTypeRadio.Location = new System.Drawing.Point(7, 44);
            this.rbTypeRadio.Name = "rbTypeRadio";
            this.rbTypeRadio.Size = new System.Drawing.Size(56, 17);
            this.rbTypeRadio.TabIndex = 1;
            this.rbTypeRadio.TabStop = true;
            this.rbTypeRadio.Text = "Радио";
            this.rbTypeRadio.UseVisualStyleBackColor = true;
            this.rbTypeRadio.CheckedChanged += new System.EventHandler(this.rbTypeRadio_CheckedChanged);
            // 
            // rbTypeDigital
            // 
            this.rbTypeDigital.AutoSize = true;
            this.rbTypeDigital.Location = new System.Drawing.Point(7, 20);
            this.rbTypeDigital.Name = "rbTypeDigital";
            this.rbTypeDigital.Size = new System.Drawing.Size(77, 17);
            this.rbTypeDigital.TabIndex = 0;
            this.rbTypeDigital.TabStop = true;
            this.rbTypeDigital.Text = "Цифровой";
            this.rbTypeDigital.UseVisualStyleBackColor = true;
            this.rbTypeDigital.CheckedChanged += new System.EventHandler(this.rbTypeDigital_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(13, 90);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(95, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RailCircuitTypeDialog
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(210, 125);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RailCircuitTypeDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Рельсовая цепь";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTypeRadio;
        private System.Windows.Forms.RadioButton rbTypeDigital;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}