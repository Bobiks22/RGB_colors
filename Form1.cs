using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_colors
{
    public partial class Form1 : Form
    {
        int red = 0;
        int blue = 0;
        int green = 0;
        int maximum;
        double koef;

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            maximum = 255;
            chbPercent.Checked = false;
            koef = 1.0;

           

            scrollBlue.Maximum = maximum;
            scrollGreen.Maximum = maximum;
            scrollRed.Maximum = maximum;

            scrollRed.Value = red;
            scrollBlue.Value = blue;
            scrollGreen.Value = green;
            timerColor.Start();
            
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {

            colorBox.BackColor = Color.FromArgb(red, green, blue);
            UpdateTb();

        }

        private void UpdateTb()
        {
            if(tbRed.Focused == false)
            {
                tbRed.Text = Convert.ToString(Math.Round(red * koef));
            }

            if(tbGreen.Focused == false)
            {
                tbGreen.Text = Convert.ToString(Math.Round(green * koef));
            }

            if(tbBlue.Focused == false)
            {
                tbBlue.Text = Convert.ToString(Math.Round(blue * koef));
            }
            
        }
        private void chbPercent_CheckStateChanged(object sender, EventArgs e)
        {
            if(chbPercent.Checked == true)
            {
                maximum = 100;

                koef = 0.3921;

                lblBlue.Text = "Blue (%)";
                lblRed.Text = "Red (%)";
                lblGreen.Text = "Green (%)";
            }
            else if(chbPercent.Checked == false)
            {
                maximum = 255;

                koef = 1.0;

                lblBlue.Text = "Blue";
                lblRed.Text = "Red";
                lblGreen.Text = "Green";
            }
            scrollBlue.Maximum = maximum;
            scrollGreen.Maximum = maximum;
            scrollRed.Maximum = maximum;

            scrollRed.Value = Convert.ToInt32(Math.Round(red * koef));
            scrollBlue.Value = Convert.ToInt32(Math.Round(blue * koef));
            scrollGreen.Value = Convert.ToInt32(Math.Round(green * koef));

        }

        private void scrollRed_Scroll(object sender, EventArgs e)
        {
            red = Convert.ToInt32(Math.Round(scrollRed.Value / koef));
           
        }

        private void scrollGreen_Scroll(object sender, EventArgs e)
        {
            green = Convert.ToInt32(Math.Round(scrollGreen.Value / koef));
            
           
        }

        private void scrollBlue_Scroll(object sender, EventArgs e)
        {
            blue = Convert.ToInt32(Math.Round(scrollBlue.Value / koef));
            
           
        }

        //private void tbRed_TextChanged(object sender, EventArgs e)
        //{
        //    if (tbRed.Text != string.Empty && tbRed.Text.Length <= 3)
        //    {
        //        int value = Int32.Parse(tbRed.Text);
        //        if (value >= 0 && value <= maximum)
        //        {
        //            red = Convert.ToInt32(Math.Round(value * koef));
        //            scrollRed.Value = value;
        //        }
        //    }
        //}

        //private void tbGreen_TextChanged(object sender, EventArgs e)
        //{

        //    if (tbGreen.Text != string.Empty && tbGreen.Text.Length <= 3)
        //    {
        //        int value = Int32.Parse(tbGreen.Text);
        //        if (value >= 0 && value <= maximum)
        //        {
        //            green = Convert.ToInt32(Math.Round(value * koef));
        //            scrollGreen.Value = value;
        //        }
        //    }
        //}

        //private void tbBlue_TextChanged(object sender, EventArgs e)
        //{
        //    if (tbBlue.Text != string.Empty && tbBlue.Text.Length <= 3)
        //    {
        //        int value = Int32.Parse(tbBlue.Text);
        //        if (value >= 0 && value <= maximum)
        //        {
        //            blue = Convert.ToInt32(Math.Round(value * koef));
        //            scrollBlue.Value = value;
        //        }
        //    }
        //}
    }
}
