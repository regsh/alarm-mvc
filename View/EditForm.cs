/*
 * EditForm.cs
 * Regan Hale
 * 10/12/20
 * CIS501
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501MVC
{
    /// <summary>
    /// Form used to add or edit alarms in the alarm application
    /// </summary>
    public partial class EditForm : Form
    {

        /// <summary>
        /// If not null, the index of the selected alarm in the AlarmClock form's 
        /// alarmList
        /// </summary>
        private int alarmIndex;

        /// <summary>
        /// Delegate function to handle input from user
        /// </summary>
        private EditHandler handler;

        /// <summary>
        /// Constructor passing alarm and its index
        /// </summary>
        /// <param name="a">alarm to be edited, or null if new alarm</param>
        /// <param name="index">index of alarm in alarmList</param>
        public EditForm(AlarmMVC a, int index, EditHandler eh)
        {
            InitializeComponent();
            handler = eh;
            uxTimePicker.Format = DateTimePickerFormat.Time;
            uxTimePicker.ShowUpDown = true;
            uxToneComboBx.DataSource = Enum.GetValues(typeof(Tone));

            alarmIndex = index;
            if (a != null)
            {
                DateTime alarmValue = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, a.Time.Hour, a.Time.Minute, a.Time.Second);
                uxTimePicker.Value = alarmValue;
                uxOn.Checked = (a.Status == AlarmStatus.Running);
                uxToneComboBx.SelectedItem = a.Ringtone;
                uxSnoozeIntvlUpDwn.Value = a.SnoozeInterval;
            }
        }
        /// <summary>
        /// Handles click event on the cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Handles click event on the set button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSetAlarmBtn_Click(object sender, EventArgs e)
        {
            AlarmMVC result;
            DateTime selectedTime = uxTimePicker.Value;
            int snooze = Convert.ToUInt16(uxSnoozeIntvlUpDwn.Value);
            Tone tone = (Tone)uxToneComboBx.SelectedItem;
            result = new AlarmMVC(selectedTime.Hour, selectedTime.Minute, selectedTime.Second, uxOn.Checked, snooze, tone);
            handler(result, alarmIndex);
            this.Close();
        }

        /// <summary>
        /// Toggles whether alarm is set based on radio button
        /// Overrides default behavior in order to turn off with a click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOn_Click(object sender, EventArgs e)
        {
            uxOn.Checked = !uxOn.Checked;
        }
    }
}
