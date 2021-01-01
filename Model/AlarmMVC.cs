/*
 * AlarmMVC.cs
 * Regan Hale
 * 10/12/20
 * CIS501
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501MVC
{
    /// <summary>
    /// The ringtones available in this iteration of the Alarm501App
    /// </summary>
    public enum Tone
    {
        Radar,
        Beacon,
        Chimes,
        Circuit,
        Reflection
    }
    /// <summary>
    /// Represents the current status of an alarm in the alarm clock app
    /// </summary>
    public enum AlarmStatus
    {
        Running,
        Off,
        Stopped,
        Snoozed,
        Alarming
    }

    public class AlarmMVC
    {
        private int snooze;

        /// <summary>
        /// Current status of the alarm
        /// </summary>
        public AlarmStatus Status { get; set; }

        /// <summary>
        /// Time the alarm is set to go off
        /// Day, month, year set to 1, alarm time in h, m, s
        /// </summary>
        public DateTime Time { get; private set; }

        /// <summary>
        /// Interval of "snooze" feature by which alarm is reset for
        /// 0-30 minutes after initial alarm
        /// </summary>
        public int SnoozeInterval {
            get { return snooze; }
            set
            {
                if (value >= 0 && value <= 30) snooze = value;
            }
        }

        /// <summary>
        /// The ringtone set for this alarm
        /// </summary>
        public Tone Ringtone { get; set; }

        /// <summary>
        /// Constructor for creating an alarm where hour input is 0-23
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <param name="set"></param>
        public AlarmMVC(int hours, int minutes, int seconds, bool set, int snooze, Tone ringtone)
        {
            if (set) Status = AlarmStatus.Running;
            else Status = AlarmStatus.Off;
            Time = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, hours, minutes, seconds);
            this.snooze = snooze;
            this.Ringtone = ringtone;
        }
        /// <summary>
        /// Snoozes the alarm for the amount of time indicated in parameters
        /// </summary>
        /// <param name="hours">Number of hours to snooze the alarm</param>
        /// <param name="minutes">Number of minutes to snooze the alarm</param>
        /// <param name="seconds">Number of seconds to snooze the alarm</param>
        public void Snooze(int minutes)
        {
            this.Time = this.Time.AddMinutes(minutes);
        }

        /// <summary>
        /// Overridden function to display the alarm in the listbox as 
        /// described in the functional requirements
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";
            string afternoon = "am";
            string set = Status.ToString();

            if (Time.Hour > 12)
            {
                afternoon = "pm";
                result += (Time.Hour - 12).ToString();
            }
            else if (Time.Hour == 0) result += "12";
            else
            {
                result += Time.Hour.ToString();
            }
            return result += $":{Time.Minute:00} {afternoon} {set}";
        }
    }
}
