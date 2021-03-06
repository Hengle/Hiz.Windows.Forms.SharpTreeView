﻿using Aga.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SampleApp.Net4Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            Console.WriteLine(PerformanceAnalyzer.GenerateReport("OnPaint"));
        }
    }
}
