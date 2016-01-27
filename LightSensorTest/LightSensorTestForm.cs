using System;
using Sensors;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace LightSensorTest
{
    public partial class LightSensorTestForm : Form
    {
        ILightSensor mySensor = LightSensorFactory.CreateLightSensor();
        public LightSensorTestForm()
        {
            InitializeComponent();
            mySensor.BrightnessChanged += new BrightnessChangedHandler(mySensor_BrightnessChanged);

            mySensor_BrightnessChanged(mySensor);

            Disposed += new EventHandler(LightSensorTestForm_Disposed);
        }

        // you MUST dispose of the sensor, or the sensor thread will keep running
        // and the application will not exit
        void LightSensorTestForm_Disposed(object sender, EventArgs e)
        {
            mySensor.Dispose();
            mySensor = null;
        }

        void mySensor_BrightnessChanged(ILightSensor sender)
        {
            myBrightness.Text = mySensor.Brightness.ToString();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            myLumens.Text = string.Format("Lumens: {0}", mySensor.GetLumens().ToString());
        }

        private void myExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}