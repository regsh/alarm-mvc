/*
 * AlarmWriterMVC.cs
 * Regan Hale
 * 10/12/20
 * CIS501
 */

using System.IO;

namespace Alarm501MVC
{
    /// <summary>
    /// Class to save AlarmCollection to persistent storage
    /// </summary>
    public class AlarmWriterMVC
    {
        //Filepath to which to save alarms
        private string filename;
        //AlarmCollection to be stored
        private AlarmCollection data;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ac">data to store</param>
        /// <param name="fn">filepath of storage file</param>
        public AlarmWriterMVC(AlarmCollection ac, string fn)
        {
            filename = fn;
            data = ac;
        }

        /// <summary>
        /// Prints the time and status of the alarm for persistent storage
        ///  HH,MM,SS,STATUS
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private string PrintAlarm(AlarmMVC a)
        {
            return $"{a.Time.Hour},{a.Time.Minute},{a.Time.Second},{a.Status},{a.SnoozeInterval},{a.Ringtone}";
        }
        /// <summary>
        /// Prints collection of alarms to specified file using a StreamWriter
        /// </summary>
        public void SaveAlarms()
        {
            TextWriter txt = new StreamWriter(filename, false);
            foreach(AlarmMVC a in data.alarms)
            {
                txt.WriteLine(PrintAlarm(a));
            }
            txt.Close();
        }
    }
}
