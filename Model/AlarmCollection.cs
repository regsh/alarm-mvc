/*
 * AlarmCollection.cs
 * Author:Regan Hale
 * CIS501
 * October 12, 2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501MVC
{
    /// <summary>
    /// Class to represent a collection of alarms
    /// </summary>
    public class AlarmCollection
    {
        //Maximum size of the collection
        private int size;
        //List of alarms to be shown in the GUI
        public BindingList<AlarmMVC> alarms;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sz">max size</param>
        /// <param name="file">file path from which to read alarms to collection</param>
        public AlarmCollection(int sz, string file)
        {
            size = sz;
            alarms = new BindingList<AlarmMVC>();
            AlarmReaderMVC reader = new AlarmReaderMVC(this, file);
            reader.ReadAlarms();
        }
        /// <summary>
        /// Adds an alarm to the collection if maximum size has not been reached
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool AddAlarm(AlarmMVC a)
        {
            bool added = false;
            if (alarms.Count < size)
            {
                alarms.Add(a);
                added = true;
            }
            return added;
        }
        /// <summary>
        /// Edits the indexed alarm by replacing it with AlarmMVC passed as parameter
        /// </summary>
        /// <param name="index"></param>
        /// <param name="a"></param>
        public void EditAlarm(int index, AlarmMVC a)
        {
            alarms[index] = a;
        }
        /// <summary>
        /// Returns alarm object at given index
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public AlarmMVC GetAlarm(int i)
        {
            if (i == -1) return null;
            return alarms[i];
        }
        /// <summary>
        /// Sets off an alarm by changing status 
        /// </summary>
        /// <param name="i"></param>
        public void SoundAlarm(int i)
        {
            alarms[i].Status = AlarmStatus.Alarming;
            alarms.ResetItem(i);
        }
        /// <summary>
        /// Quiets an alarm by snoozing or stopping
        /// </summary>
        /// <param name="i">index of alarm to quiet</param>
        /// <param name="snooze">true if snoozed, false if stopped</param>
        public void QuietAlarm(int i, bool snooze)
        {
            if (snooze)
            {
                alarms[i].Snooze(alarms[i].SnoozeInterval);
                alarms[i].Status = AlarmStatus.Running;
            }
            else
            {
                alarms[i].Status = AlarmStatus.Stopped;
            }
            alarms.ResetItem(i);
        }
    }
}
