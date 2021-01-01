using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501MVC
{

    public delegate void StateObs(AppState s, int i);

    public delegate void DialogPrompter(int index);

    public delegate void EditHandler(AlarmMVC a, int index);

    public delegate void AlarmResponder(AlarmStatus s, int index);

    public delegate void CloseApplication();

    static class Program
    {
        private static string file = "..\\..\\AlarmDataMVC.txt";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AlarmCollection model = new AlarmCollection(10, file);
            ControllerMVC controller = new ControllerMVC(model, file);
            AlarmForm view = new AlarmForm(controller.PromptEditWindow, controller.QuietAlarm, model);
            view.CloseApp += controller.SaveAlarms;
            controller.RegisterObserver(view.DisplayState);
            
            Application.Run(view);
        }
    }
}
