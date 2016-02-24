using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EasyTest.BL;

namespace EasyTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainform = new MainForm();
            RawDataProcessor rawProcessor = new RawDataProcessor();
            ReportCreator reportCreator = new ReportCreator();
            DocumentCreator documentCreator = new DocumentCreator();

            Presenter presenter = new Presenter(rawProcessor, reportCreator,
                documentCreator, mainform);

            Application.Run(mainform);
        }
    }
}
