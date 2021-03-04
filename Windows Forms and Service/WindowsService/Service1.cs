using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.IO;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private static System.Timers.Timer timer;
        protected override void OnStart(string[] args)
        {
            timer = new System.Timers.Timer(10000);
            timer.Elapsed += new ElapsedEventHandler(this.callEvent);
            timer.Enabled = true;
        }
        private void callEvent(object sender, ElapsedEventArgs e)
        {
            DateTime t1 = DateTime.Parse("2021/03/05 00:07:00.000");
            DateTime t2 = DateTime.Now;
            int t = TimeSpan.Compare(t2.TimeOfDay, t1.TimeOfDay);
            if (t >= 0)
            {
                createEvent();
            }
        }


        private void createEvent()
        {

            string fileName = @"C:\Users\Dell\Documents\New folder\file.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName,true))
                {
                    writer.WriteLine("Custom activity started at "+DateTime.Now);
                    writer.WriteLine();
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }



        }
        protected override void OnStop()
        {
            
            timer.Stop();
            timer = null;
            
        }
    }
}

