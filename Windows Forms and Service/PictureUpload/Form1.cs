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

namespace PictureUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.Jfif; *.png)|*.jpg; *.jpeg; *.png;*.Jfif;";
            if(open.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}
