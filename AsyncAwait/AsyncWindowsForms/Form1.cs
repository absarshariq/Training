using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private int CountWords()
        {
            int count = 0;
            using (StreamReader str=new StreamReader("C:/Users/Dell/Desktop/Documents/file.txt"))
            {
                string s = str.ReadToEnd();
                count = s.Length;
                Thread.Sleep(10000);
                
            }
            return count;
        }
        private async void Button1(object sender, EventArgs e)
        {
            Task<int> t = new Task<int>(CountWords);
            t.Start();
            label1.Text = "Processing File...Please Wait";
            int c = await t;
            label1.Text = c.ToString() + " Characters in the file";

        }
    }
}
