using System.ComponentModel;
using ApplicationDMV.Search_Forms;
using ApplicationDMV.InsertForms;
namespace ApplicationDMV
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            MainForm mainWindow = new MainForm();
            Application.Run(mainWindow);
        }
    }
}