/*
 * ControllerMVC.cs
 * Author:Regan Hale
 * CIS501
 * October 12, 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Timers;
using System.Windows.Forms;

namespace Alarm501MVC
{
    /// <summary>
    /// Class to serve as controller for Alarm application
    /// </summary>
    class ControllerMVC
    {
        //Alarm data to represent in the GUI
        private AlarmCollection model;
        
        //Filename to which to save alarms in persistent storage
        private string filename;

        //Observer delegate used to change UI appearance with application state changes
        private StateObs observer;

        //Timer to check system time for comparison to active alarms
        private System.Windows.Forms.Timer myTimer = null;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ac">alarm collection to serve as model</param>
        /// <param name="file">file path to write alarm data on close</param>
        public ControllerMVC(AlarmCollection ac, string file)
        {
            model = ac;
            filename = file;
            myTimer = new Timer();
            myTimer.Interval = 1000;
            myTimer.Tick += CheckAlarms;
            myTimer.Start();
        }
        /// <summary>
        /// Compares current system time to time of alarms in collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAlarms(object sender, EventArgs e)
        {
            DateTime current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            foreach (AlarmMVC a in model.alarms)
            {
                if (a.Status == AlarmStatus.Running && TimeSpan.Compare(a.Time.TimeOfDay, current.TimeOfDay) == 0)
                {
                    SignalAlarm(model.alarms.IndexOf(a));
                }
            }
            myTimer.Enabled = true;
        }

        /// <summary>
        /// Function to change user interface in response to an alarm's time being reached
        /// </summary>
        /// <param name="index">index of alarm that has gone off</param>
        private void SignalAlarm(int index)
        {
            model.SoundAlarm(index);
            observer(AppState.ALARMING, index);
        }

        /// <summary>
        /// Public method to register observer delegate during program assembly
        /// </summary>
        /// <param name="obs"></param>
        public void RegisterObserver(StateObs obs)
        {
            this.observer = obs;
        }
        /// <summary>
        /// Method to edit alarms according th changes made in the edit form
        /// </summary>
        /// <param name="a"></param>
        /// <param name="index"></param>
        public void HandleEdit(AlarmMVC a, int index)
        {
            if (index == -1) model.AddAlarm(a);
            else
            {
                model.EditAlarm(index, a);
            }
            observer(AppState.LISTENING, -1);
        }
        /// <summary>
        /// Creates and deploys edit window when user adds or edits existing alarm
        /// </summary>
        /// <param name="index"></param>
        public void PromptEditWindow(int index)
        {
            EditForm ef = new EditForm(model.GetAlarm(index), index, HandleEdit);
            ef.Show();
        }
        /// <summary>
        /// Saves alarms to designated file
        /// </summary>
        public void SaveAlarms()
        {
            AlarmWriterMVC writer = new AlarmWriterMVC(model, filename);
            writer.SaveAlarms();
            myTimer.Stop();
        }
        /// <summary>
        /// Handles user response to alarm
        /// </summary>
        /// <param name="s">AlarmStatus determined by user selection</param>
        /// <param name="index">index of alarm to be quieted</param>
        public void QuietAlarm(AlarmStatus s, int index)
        {
            switch (s)
            {
                case AlarmStatus.Stopped:
                    model.QuietAlarm(index, false);
                    break;
                case AlarmStatus.Snoozed:
                    model.QuietAlarm(index, true);
                    break;
            }
            observer(AppState.LISTENING, -1);
        }

    }
}
