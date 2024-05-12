using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SMS
{
    public partial class homepage : Form
    {
        private string[] words = new string[] { "Hassan Nawaz", "Taha Ahmed", "Asjid Rauf" };
        private int currentWordIndex = 0;
        private int currentLength = 0;
        private bool increasing = true;
        private string textToAnimate = "";
        public homepage()
        {
            InitializeComponent();

            //
            //create timer
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 150;
            timer1.Elapsed += Timer1_Tick;
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (textToAnimate == "")
            {
                textToAnimate = words[currentWordIndex];
            }

            if (increasing)
            {
                currentLength++;
                if (currentLength > textToAnimate.Length)
                {
                    increasing = false;
                    currentLength -= 1;
                }
            }
            else
            {
                currentLength--;
                if (currentLength <= 0)
                {
                    increasing = true;
                    currentLength = 0;
                    currentWordIndex++;
                    if (currentWordIndex >= words.Length)
                    {
                        currentWordIndex = 0;
                    }
                    textToAnimate = words[currentWordIndex];
                }
            }

            dyn_label.Text = textToAnimate.Substring(0, Math.Max(currentLength, 0));
        }



    }
}
