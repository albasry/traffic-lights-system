using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Lights
{
    public partial class FrmMain: Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        byte TimeCounter = 0;
        byte TrafficNum = 0;

        private void TrafficCaseOne()
        {
            ImgNorthGreen.Visible = false;
            ImgNorthYellow.Visible = false;
            ImgNorthRed.Visible = true;

            ImgEastGreen.Visible = true;
            ImgEastYellow.Visible = false;
            ImgEastRed.Visible = false;

            ImgSouthGreen.Visible = false;
            ImgSouthYellow.Visible = false;
            ImgSouthRed.Visible = true;

            ImgWestGreen.Visible = false;
            ImgWestYellow.Visible = false;
            ImgWestRed.Visible = true;
        }

        private void TrafficCaseTwo()
        {
            ImgNorthYellow.Visible = true;
            ImgNorthRed.Visible = false;

            ImgEastGreen.Visible = false;
            ImgEastYellow.Visible = true;
        }

        private void TrafficCaseThree()
        {
            ImgNorthGreen.Visible = true;
            ImgNorthYellow.Visible = false;

            ImgEastYellow.Visible = false;
            ImgEastRed.Visible = true;
        }

        private void TrafficCaseFour()
        {
            ImgNorthGreen.Visible = false;
            ImgNorthYellow.Visible = true;

            ImgWestYellow.Visible = true;
            ImgWestRed.Visible = false;
        }

        private void TrafficCaseFive()
        {
            ImgNorthYellow.Visible = false;
            ImgNorthRed.Visible = true;

            ImgWestGreen.Visible = true;
            ImgWestYellow.Visible = false;
        }

        private void TrafficCaseSix()
        {
            ImgSouthYellow.Visible = true;
            ImgSouthRed.Visible = false;

            ImgWestGreen.Visible = false;
            ImgWestYellow.Visible = true;
        }

        private void TrafficCaseSeven()
        {
            ImgSouthGreen.Visible = true;
            ImgSouthYellow.Visible = false;

            ImgWestYellow.Visible = false;
            ImgWestRed.Visible = true;
        }

        private void TrafficCaseEight()
        {
            ImgEastYellow.Visible = true;
            ImgEastRed.Visible = false;

            ImgSouthGreen.Visible = false;
            ImgSouthYellow.Visible = true;
        }

        private void ChangeLights()
        {
            TrafficNum++;

            if (TrafficNum == 9)
                TrafficNum = 1;

            switch (TrafficNum)
            {
                case 1:
                    TrafficCaseOne();

                    break;

                case 2:
                    TrafficCaseTwo();

                    break;

                case 3:
                    TrafficCaseThree();

                    break;

                case 4:
                    TrafficCaseFour();

                    break;

                case 5:
                    TrafficCaseFive();

                    break;

                case 6:
                    TrafficCaseSix();

                    break;

                case 7:
                    TrafficCaseSeven();

                    break;

                case 8:
                    TrafficCaseEight();

                    break;

                default:
                    break;
            }
        }

        private void TrafficLightsCounter()
        {
            TimeCounter++;

            LblNorth.Text = TimeCounter.ToString();
            LblEast.Text = TimeCounter.ToString();
            LblSouth.Text = TimeCounter.ToString();
            LblWest.Text = TimeCounter.ToString();

            if (TimeCounter == 5)
            {
                ChangeLights();
                TimeCounter = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer1_Tick method is an event handler that
            // is called repeatedly by the Timer control at regular intervals.
            TrafficLightsCounter();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
