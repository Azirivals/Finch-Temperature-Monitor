using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;
using System.Windows.Forms;

namespace Finch_Temperature_Monitor___JTaber
{
    // **************************************************
    //
    // Title: Finch Temperature Monitor
    // Description: A small application that monitors temperature and warns the user once the threshold has been passed.
    // Application Type: WinForms
    // Author: Taber, Jake
    // Dated Created: 4/10/2021
    // Last Modified: 4/17/2021
    //
    // **************************************************
    public partial class frm_TempMon : Form
    {
        Finch finchRobot;

        /// <summary>
        /// This initializes the WinForms and allows the FinchAPI to be used throughout the application.
        /// </summary>
        public frm_TempMon()
        {
            InitializeComponent();

            finchRobot = new Finch();
        }
        /// <summary>
        /// This is the opening how to text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_TempMon_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The Finch temperate monitor is a very simple program. It will monitor temperature and will set of an alarm when the temperature threashold has been passed by the user set threshold. " +
                "There are 4 steps. 1.Connect your finch to your computer, you must do this before you start the application. " +
               "2. Click the Connect To Finch button, the finch will pull the temperature when it connects. " +
               "3. Enter the tempature you want the alarm to go off at in the Enter Threshold box and press the Confirm Temp Threshold Button, this will now show your confirmed temp in the Temp Threshold box." +
               " 4. Press the Start Monitor button to start monitoring temperature. When the threshold has been reached, the finch will flash red and beep, as well as your computer." +
               " It will pop up a text box saying that the threshold has been reached and then display the time the alarm went off in the Threshold Reached At box. ", "How to Use");
        }
        /// <summary>
        /// This will change the temperature box to show the temperature of the Finch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Temp_TextChanged(object sender, EventArgs e)
        {
            txb_Temp.Text = finchRobot.getTemperature().ToString();
        }

        /// <summary>
        /// App exit screen, display messsage, disconnect Finch and exit application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using my program, have a nice day!", "See You Again Soon!");
            finchRobot.noteOn(1047);
            finchRobot.setLED(0, 0, 255);
            finchRobot.wait(100);
            finchRobot.noteOn(988);
            finchRobot.setLED(0, 255, 0);
            finchRobot.wait(100);
            finchRobot.noteOn(880);
            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(100);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);
            finchRobot.disConnect();
            Environment.Exit(0);
        }
        /// <summary>
        /// Connect the finch and test to see if it has a connection and pull the temperature.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_FinchConnect_Click_Click(object sender, EventArgs e)
        {

            bool robotConnected;

            robotConnected = finchRobot.connect();
            if (robotConnected)
            {
                finchRobot.noteOn(880);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(100);
                finchRobot.noteOn(988);
                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(100);
                finchRobot.noteOn(1047);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(100);
                finchRobot.noteOff();
                finchRobot.setLED(0, 0, 0);

                MessageBox.Show("Your Finch robot is now connected!",
                        "Finch Connected");
            }
            else
            {
                MessageBox.Show("Your Finch could not be connectd, please check to see if it is plugged in and try again", "Connection Error");
            }

            txb_Temp.Text = finchRobot.getTemperature().ToString();
        }
        /// <summary>
        /// Used for the max threshold value for the temperature monitor.
        /// </summary>
        int maxThreshValue;
        /// <summary>
        /// Used to confirm the threshold value for the alarm, if not a whole number it will throw an message to enter one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConfirmTemp_Click(object sender, EventArgs e)
        {
            bool validNumber;
            if (!int.TryParse(txb_thresh.Text, out maxThreshValue))
            {
                validNumber = false;
                MessageBox.Show("Please enter a whole number", "Enter Valid Number");
            }
            else
            {
                txb_threshFinal.Text = maxThreshValue.ToString();
            }
        }
        /// <summary>
        /// Use the timer to monitor to see if the threshold had been passed. This updates every second.
        /// If the threshold has been passed, the loop will break, disable the timer, flash the finch red and play an error sound on both the finch and through speakers
        /// and inform the user the threshold has been reached.
        /// This will also put in the time the threshold was reached at in the alarm time text box and update the temperature of the finch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_mon_Tick(object sender, EventArgs e)
        {
            bool thresholdPassed = false;
            int currentTemp;
            currentTemp = (int)finchRobot.getTemperature();

            while ((maxThreshValue <= currentTemp) && !thresholdPassed)
            {
                break;
            }
            if (maxThreshValue <= currentTemp)
            {
                thresholdPassed = true;
                tmr_mon.Enabled = false;
                finchRobot.noteOn(880);
                Console.Beep();
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                finchRobot.noteOn(880);
                Console.Beep();
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                finchRobot.noteOn(880);
                Console.Beep();
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                finchRobot.noteOn(880);
                Console.Beep();
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                finchRobot.noteOn(880);
                Console.Beep();
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                MessageBox.Show("The threshold has been reached!", "Threshold Reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txb_alarmTime.Text = DateTime.Now.TimeOfDay.ToString();
                txb_Temp.Text = finchRobot.getTemperature().ToString();
            }

        }
        /// <summary>
        /// This will enable the timer and start the monitoring process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_threshMon_Click(object sender, EventArgs e)
        {
            tmr_mon.Enabled = true;
        }
    }
}