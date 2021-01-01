/*
 * AlarmReaderMVC.cs
 * ReganHale
 * 10/12/20
 * CIS501
 */

using System;
using System.IO;

namespace Alarm501MVC
{
    /// <summary>
    /// Class to read in alarms from persistent file and create an AlarmCollection
    /// </summary>
    class AlarmReaderMVC
    {
        //File from which to read alarm data
        //"..\\..\\AlarmData.txt"
        private string filename;

        private AlarmCollection data;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ac"></param>
        /// <param name="file"></param>
        public AlarmReaderMVC(AlarmCollection ac, string file)
        {
            filename = file;
            data = ac;
        }
        /// <summary>
        /// Reads in alarms from file and populates data field
        /// </summary>
        public void ReadAlarms()
        {
            //Reads in alarm info from persistent text file and populates alarmList variable
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    string[] alarmData = sr.ReadLine().Split(',');
                    Tone t = (Tone)Enum.Parse(typeof(Tone), alarmData[5]);
                    //from AlarmWriter:
                    //return $"{a.Time.Hour},{a.Time.Minute},{a.Time.Second},{a.Status},{a.SnoozeInterval},{a.Ringtone}";
                    bool running = (alarmData[3] == "Running");
                    AlarmMVC a = new AlarmMVC(
                        Convert.ToInt32(alarmData[0]),
                        Convert.ToInt32(alarmData[1]),
                        Convert.ToInt32(alarmData[2]),
                        running,
                        Convert.ToInt32(alarmData[4]),
                        t);
                    data.AddAlarm(a);
                }
                sr.Close();
            }
        }
    }
}
