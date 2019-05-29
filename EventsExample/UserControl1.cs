using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EventsExample
{
    public partial class UserControl1 : UserControl
    {

        int border;
        int _numberOfStars = 0;
        public UserControl1()
        {
            InitializeComponent();
            border = pictureBox1.Size.Width / 6;
        }

        public delegate void MyDelegate(int oldVal, int newVal);
        public event MyDelegate OnStarCountChange;


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int mousepos = e.X;
            int newStarNumber = 0;

            newStarNumber = e.X / (pictureBox1.Size.Width / 6);
            if (newStarNumber != _numberOfStars)
            {
                drawStars(newStarNumber);
            }
        }


        private void drawStars(int newStarNumber)
        {
            switch (newStarNumber)
            {
                case (0):
                    pictureBox1.Image = Properties.Resources._0;
                    break;
                case (1):
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case (2):
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case (3):
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case (4):
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case (5):
                    pictureBox1.Image = Properties.Resources._5;
                    break;

                default:
                    break;
            }

            OnStarCountChange?.Invoke(_numberOfStars, newStarNumber);
            _numberOfStars = newStarNumber;
        }
    }
}
