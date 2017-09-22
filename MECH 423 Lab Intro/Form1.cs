using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECH_423_Lab_Intro
{
    public partial class frmMainWindow : Form
    {
        //class Variables
        int timeCounter;
        int currentTime;
        int itemLimit = 20;


        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void txtDrawingWindow_MouseMove(object sender, MouseEventArgs e)
        {
            //Sets the value of fields txt X and Y to the cordinates of X and Y within the Drawing Box
            txtXCoord.Text = e.X.ToString("0000");
            txtYCoord.Text = e.Y.ToString("0000");

            //
            currentTime = timeCounter * tmrMoveDelayCounter.Interval;
            lstDeltaTime.Items.Add(currentTime.ToString("000000"));
            timeCounter = 0;

            //Limits list box entries to itemLimit, and removes old entries
            while (lstDeltaTime.Items.Count > itemLimit)
            {
                lstDeltaTime.Items.RemoveAt(0);
            }
            lstDeltaTime.SelectedIndex = lstDeltaTime.Items.Count - 1;
        }

        private void tmrMoveDelayCounter_Tick(object sender, EventArgs e)
        {
            timeCounter++;
        }
    }
}
