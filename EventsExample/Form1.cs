using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.OnStarCountChange += Uc1_OnStarCountChange;
        }

        private void Uc1_OnStarCountChange(int oldVal, int newVal)
        {
            Debug.WriteLine($"Old Number of Stars: {oldVal} --- New Number of Stars: {newVal}");
        }
    }
}
