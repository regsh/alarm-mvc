namespace Alarm501MVC
{
    partial class AlarmForm
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
            this.uxStatusLbl = new System.Windows.Forms.Label();
            this.uxStop = new System.Windows.Forms.Button();
            this.uxSnooze = new System.Windows.Forms.Button();
            this.uxAlarmListbox = new System.Windows.Forms.ListBox();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxStatusLbl
            // 
            this.uxStatusLbl.AutoSize = true;
            this.uxStatusLbl.Location = new System.Drawing.Point(22, 84);
            this.uxStatusLbl.Name = "uxStatusLbl";
            this.uxStatusLbl.Size = new System.Drawing.Size(186, 17);
            this.uxStatusLbl.TabIndex = 11;
            this.uxStatusLbl.Text = "Click the \"+\" to add an alarm";
            // 
            // uxStop
            // 
            this.uxStop.Enabled = false;
            this.uxStop.Location = new System.Drawing.Point(190, 295);
            this.uxStop.Margin = new System.Windows.Forms.Padding(4);
            this.uxStop.Name = "uxStop";
            this.uxStop.Size = new System.Drawing.Size(103, 44);
            this.uxStop.TabIndex = 10;
            this.uxStop.Text = "STOP";
            this.uxStop.UseVisualStyleBackColor = true;
            this.uxStop.Click += new System.EventHandler(this.uxStop_Click);
            // 
            // uxSnooze
            // 
            this.uxSnooze.Enabled = false;
            this.uxSnooze.Location = new System.Drawing.Point(25, 295);
            this.uxSnooze.Margin = new System.Windows.Forms.Padding(4);
            this.uxSnooze.Name = "uxSnooze";
            this.uxSnooze.Size = new System.Drawing.Size(104, 44);
            this.uxSnooze.TabIndex = 9;
            this.uxSnooze.Text = "SNOOZE";
            this.uxSnooze.UseVisualStyleBackColor = true;
            this.uxSnooze.Click += new System.EventHandler(this.uxSnooze_Click);
            // 
            // uxAlarmListbox
            // 
            this.uxAlarmListbox.FormattingEnabled = true;
            this.uxAlarmListbox.ItemHeight = 16;
            this.uxAlarmListbox.Location = new System.Drawing.Point(25, 115);
            this.uxAlarmListbox.Margin = new System.Windows.Forms.Padding(4);
            this.uxAlarmListbox.Name = "uxAlarmListbox";
            this.uxAlarmListbox.Size = new System.Drawing.Size(269, 164);
            this.uxAlarmListbox.TabIndex = 8;
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(190, 24);
            this.uxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(103, 44);
            this.uxAdd.TabIndex = 7;
            this.uxAdd.Text = "+";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxEdit
            // 
            this.uxEdit.CausesValidation = false;
            this.uxEdit.Enabled = false;
            this.uxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEdit.Location = new System.Drawing.Point(25, 24);
            this.uxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(104, 44);
            this.uxEdit.TabIndex = 6;
            this.uxEdit.Text = "EDIT";
            this.uxEdit.UseVisualStyleBackColor = true;
            this.uxEdit.Click += new System.EventHandler(this.uxEdit_Click);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 367);
            this.Controls.Add(this.uxStatusLbl);
            this.Controls.Add(this.uxStop);
            this.Controls.Add(this.uxSnooze);
            this.Controls.Add(this.uxAlarmListbox);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxEdit);
            this.Name = "AlarmForm";
            this.Text = "Alarm501MVC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxStatusLbl;
        private System.Windows.Forms.Button uxStop;
        private System.Windows.Forms.Button uxSnooze;
        private System.Windows.Forms.ListBox uxAlarmListbox;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxEdit;
    }
}

