namespace LightSensorTest
{
    partial class LightSensorTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.myExitMenuItem = new System.Windows.Forms.MenuItem();
            this.myTimer = new System.Windows.Forms.Timer();
            this.myLumens = new System.Windows.Forms.Label();
            this.myBrightness = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.myExitMenuItem);
            // 
            // myExitMenuItem
            // 
            this.myExitMenuItem.Text = "Exit";
            this.myExitMenuItem.Click += new System.EventHandler(this.myExitMenuItem_Click);
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // myLumens
            // 
            this.myLumens.Location = new System.Drawing.Point(4, 4);
            this.myLumens.Name = "myLumens";
            this.myLumens.Size = new System.Drawing.Size(233, 20);
            // 
            // myBrightness
            // 
            this.myBrightness.Location = new System.Drawing.Point(4, 24);
            this.myBrightness.Name = "myBrightness";
            this.myBrightness.Size = new System.Drawing.Size(233, 20);
            // 
            // LightSensorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.myBrightness);
            this.Controls.Add(this.myLumens);
            this.Menu = this.mainMenu1;
            this.Name = "LightSensorTestForm";
            this.Text = "Light Sensor Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem myExitMenuItem;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label myLumens;
        private System.Windows.Forms.Label myBrightness;
    }
}

