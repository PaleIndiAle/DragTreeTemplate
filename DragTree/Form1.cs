using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragTree 
{
    public partial class Form1 : Form
    {
        // TODO - create an int variable to track currentRow,
        int currentRow;
        // TODO - create a Stopwatch object called stopwatch 
        Stopwatch stopwatch = new Stopwatch();

        // TODO - create a timer on the form called lightTimer (interval 400ms)
        // TODO - create the tick event for the lightTimer

        // place the following comments in the lighTimer tick event
        // TODO - create a switch block that checks currentRow. In each case
        // it will light up the appropriate lights, (labels). 

        // TODO - increment the currentRow value by 1

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            lightTimer.Enabled = true;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch

            // TODO - check if the ellapsed time in milliseconds is > 0. 
            // If yes show the time.
            // If no show "FOUL START" 

            if (stopwatch.ElapsedMilliseconds > 0)
            {
                timeLabel.Text = stopwatch.Elapsed.ToString(@"ss\:ff");
            }
            else
            {
                timeLabel.Text = "Too Early! Foul Start.";
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch

            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen

            // TODO - reset row value and timeLabel text

            row1col1.BackColor = Color.DimGray;
            row1col2.BackColor = Color.DimGray;
            row2col1.BackColor = Color.DimGray;
            row2col2.BackColor = Color.DimGray;
            row3col1.BackColor = Color.DimGray;
            row3col2.BackColor = Color.DimGray;
            row4col1.BackColor = Color.Red;
            row4col2.BackColor = Color.Red;
            stopwatch.Reset();
            timeLabel.Text = "0:00";
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            currentRow++;

            switch (currentRow)
            {
                case 1:
                    row1col1.BackColor = Color.Green;
                    row1col2.BackColor = Color.Green;
                    break;
                case 2:
                    row2col1.BackColor = Color.Green;
                    row2col2.BackColor = Color.Green;
                    break;
                case 3:
                    row3col1.BackColor = Color.Green;
                    row3col2.BackColor = Color.Green;
                    break;
                case 4:
                    row4col1.BackColor = Color.DarkOliveGreen;
                    row4col2.BackColor = Color.DarkOliveGreen;
                    lightTimer.Enabled = false;
                    currentRow = 0;
                    stopwatch.Start();
                    break;
            }
        }
    }
}
