using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            GlobalConfig.InitializeConnections(DatabaseType.TextFile);
            Application.Run(new CreatePrizeForm());
        }
    }
}
