using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FuleGage.Properties;

namespace FuleGage
{
    public partial class Overlay : Form
    {
        public Overlay()
        {
            InitializeComponent();
            
        }
        public void ColorUpate()
        {
            Color custom = Color.FromArgb(Settings.Default.ColorR, Settings.Default.ColorG, Settings.Default.ColorB);
            FuelReservoir_text.ForeColor = custom;
            Fuel_res.ForeColor = custom;
            FuelMain_text.ForeColor = custom;
            Fuel_main.ForeColor = custom;
            FuelUsed_text.ForeColor = custom;
            FuelUsed.ForeColor = custom;
            jumpDist_text.ForeColor = custom;
            jumpDist.ForeColor = custom;
        }
    

        private void Overlay_Load(object sender, EventArgs e)
        {
            ColorUpate();
        }
    }
}
