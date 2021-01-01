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
    public partial class AlarmForm : Form
    {
        private DialogPrompter prompter;

        private AlarmResponder responder;

        private AlarmCollection model;

        public event CloseApplication CloseApp;

        public AlarmForm(DialogPrompter p, AlarmResponder r, AlarmCollection a)
        {
            InitializeComponent();
            this.prompter = p;
            this.responder = r;
            this.model = a;
            uxAlarmListbox.DataSource = model.alarms;
            if (model.alarms.Count > 0) DisplayState(AppState.LISTENING, -1);
        }

        public void DisplayState(AppState state, int i)
        {
            switch (state)
            {
                case AppState.LISTENING:
                    ChangeUIForAlarm(false);    
                    break;
                case AppState.ALARMING:
                    ChangeUIForAlarm(true);
                    uxAlarmListbox.SelectedIndex = i;
                    break;
            }
        }

        /// <summary>
        /// Enables/disables UI controls based on whether an alarm is actively going off
        /// </summary>
        /// <param name="alarming"></param>
        private void ChangeUIForAlarm(bool alarming)
        {
            uxAlarmListbox.Enabled = !alarming;
            uxEdit.Enabled = !alarming;
            uxAdd.Enabled = !alarming;
            uxSnooze.Enabled = alarming;
            uxStop.Enabled = alarming;
            if (alarming)
            {
                uxStatusLbl.Text = "YOUR ALARM HAS GONE OFF!!";
            }
            else uxStatusLbl.Text = "Listening for alarms.";
        }

        //NEED TO FIND A WAY TO PASS THIS TO CONTROLLER
        /// <summary>
        /// Overrides OnFormClosing to include saving alarm information to persistent text file
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            //myTimer.Close();
            CloseApp.Invoke();
            base.OnFormClosing(e);
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            prompter(-1);
        }

        private void uxEdit_Click(object sender, EventArgs e)
        {
            int selected = uxAlarmListbox.SelectedIndex;
            prompter(selected);
        }

        private void uxStop_Click(object sender, EventArgs e)
        {
            int selected = uxAlarmListbox.SelectedIndex;
            
            responder(AlarmStatus.Stopped, selected);
        }

        private void uxSnooze_Click(object sender, EventArgs e)
        {
            int selected = uxAlarmListbox.SelectedIndex;
            responder(AlarmStatus.Snoozed, selected);
        }
    }
}
