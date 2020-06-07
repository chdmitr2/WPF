using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.Threading;
using MainMethod;

namespace ApplicationSample
{
    
    public class StartUp
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application app = new Application();
            MainWindow window = new MainWindow();
            app.Run(window);
        }
    }
}
