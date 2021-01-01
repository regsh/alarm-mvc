namespace Alarm501MVC
{
    partial class EditForm
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
            this.uxTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxOn = new System.Windows.Forms.RadioButton();
            this.uxSetAlarmBtn = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxTimeLbl = new System.Windows.Forms.Label();
            this.uxToneComboBx = new System.Windows.Forms.ComboBox();
            this.uxToneLbl = new System.Windows.Forms.Label();
            this.uxSnoozeIntvlLbl = new System.Windows.Forms.Label();
            this.uxSnoozeIntvlUpDwn = new System.Windows.Forms.NumericUpDown();
            this.uxMinLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeIntvlUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTimePicker
            // 
            this.uxTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTimePicker.Location = new System.Drawing.Point(104, 11);
            this.uxTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.uxTimePicker.Name = "uxTimePicker";
            this.uxTimePicker.Size = new System.Drawing.Size(204, 22);
            this.uxTimePicker.TabIndex = 7;
            // 
            // uxOn
            // 
            this.uxOn.AutoCheck = false;
            this.uxOn.AutoSize = true;
            this.uxOn.Location = new System.Drawing.Point(318, 11);
            this.uxOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxOn.Name = "uxOn";
            this.uxOn.Size = new System.Drawing.Size(48, 21);
            this.uxOn.TabIndex = 6;
            this.uxOn.TabStop = true;
            this.uxOn.Text = "On";
            this.uxOn.UseVisualStyleBackColor = true;
            this.uxOn.Click += new System.EventHandler(this.uxOn_Click);
            // 
            // uxSetAlarmBtn
            // 
            this.uxSetAlarmBtn.Location = new System.Drawing.Point(245, 122);
            this.uxSetAlarmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSetAlarmBtn.Name = "uxSetAlarmBtn";
            this.uxSetAlarmBtn.Size = new System.Drawing.Size(79, 29);
            this.uxSetAlarmBtn.TabIndex = 5;
            this.uxSetAlarmBtn.Text = "Set";
            this.uxSetAlarmBtn.UseVisualStyleBackColor = true;
            this.uxSetAlarmBtn.Click += new System.EventHandler(this.uxSetAlarmBtn_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(16, 122);
            this.uxCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(79, 29);
            this.uxCancel.TabIndex = 4;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxTimeLbl
            // 
            this.uxTimeLbl.AutoSize = true;
            this.uxTimeLbl.Location = new System.Drawing.Point(27, 13);
            this.uxTimeLbl.Name = "uxTimeLbl";
            this.uxTimeLbl.Size = new System.Drawing.Size(39, 17);
            this.uxTimeLbl.TabIndex = 8;
            this.uxTimeLbl.Text = "Time";
            // 
            // uxToneComboBx
            // 
            this.uxToneComboBx.FormattingEnabled = true;
            this.uxToneComboBx.Location = new System.Drawing.Point(104, 45);
            this.uxToneComboBx.Name = "uxToneComboBx";
            this.uxToneComboBx.Size = new System.Drawing.Size(121, 24);
            this.uxToneComboBx.TabIndex = 9;
            // 
            // uxToneLbl
            // 
            this.uxToneLbl.AutoSize = true;
            this.uxToneLbl.Location = new System.Drawing.Point(27, 48);
            this.uxToneLbl.Name = "uxToneLbl";
            this.uxToneLbl.Size = new System.Drawing.Size(41, 17);
            this.uxToneLbl.TabIndex = 10;
            this.uxToneLbl.Text = "Tone";
            // 
            // uxSnoozeIntvlLbl
            // 
            this.uxSnoozeIntvlLbl.AutoSize = true;
            this.uxSnoozeIntvlLbl.Location = new System.Drawing.Point(27, 86);
            this.uxSnoozeIntvlLbl.Name = "uxSnoozeIntvlLbl";
            this.uxSnoozeIntvlLbl.Size = new System.Drawing.Size(106, 17);
            this.uxSnoozeIntvlLbl.TabIndex = 11;
            this.uxSnoozeIntvlLbl.Text = "Snooze Interval";
            // 
            // uxSnoozeIntvlUpDwn
            // 
            this.uxSnoozeIntvlUpDwn.Location = new System.Drawing.Point(151, 84);
            this.uxSnoozeIntvlUpDwn.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uxSnoozeIntvlUpDwn.Name = "uxSnoozeIntvlUpDwn";
            this.uxSnoozeIntvlUpDwn.Size = new System.Drawing.Size(50, 22);
            this.uxSnoozeIntvlUpDwn.TabIndex = 12;
            this.uxSnoozeIntvlUpDwn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxSnoozeIntvlUpDwn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // uxMinLbl
            // 
            this.uxMinLbl.AutoSize = true;
            this.uxMinLbl.Location = new System.Drawing.Point(207, 89);
            this.uxMinLbl.Name = "uxMinLbl";
            this.uxMinLbl.Size = new System.Drawing.Size(57, 17);
            this.uxMinLbl.TabIndex = 13;
            this.uxMinLbl.Text = "minutes";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 171);
            this.Controls.Add(this.uxMinLbl);
            this.Controls.Add(this.uxSnoozeIntvlUpDwn);
            this.Controls.Add(this.uxSnoozeIntvlLbl);
            this.Controls.Add(this.uxToneLbl);
            this.Controls.Add(this.uxToneComboBx);
            this.Controls.Add(this.uxTimeLbl);
            this.Controls.Add(this.uxTimePicker);
            this.Controls.Add(this.uxOn);
            this.Controls.Add(this.uxSetAlarmBtn);
            this.Controls.Add(this.uxCancel);
            this.Name = "EditForm";
            this.Text = "Add/Edit Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeIntvlUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxTimePicker;
        private System.Windows.Forms.RadioButton uxOn;
        private System.Windows.Forms.Button uxSetAlarmBtn;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Label uxTimeLbl;
        private System.Windows.Forms.ComboBox uxToneComboBx;
        private System.Windows.Forms.Label uxToneLbl;
        private System.Windows.Forms.Label uxSnoozeIntvlLbl;
        private System.Windows.Forms.NumericUpDown uxSnoozeIntvlUpDwn;
        private System.Windows.Forms.Label uxMinLbl;
    }
}