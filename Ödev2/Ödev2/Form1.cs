using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sürükleme;
        int mouseX, mouseY;

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükleme)
            {
                button1.Left += e.X -(button1.Width/2);
                button1.Top += e.Y-(button1.Height/2);

            }

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
                       
            sürükleme = true;
            mouseX = e.X ;
            mouseY = e.Y;

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            sürükleme = false;
        }
    }
}

