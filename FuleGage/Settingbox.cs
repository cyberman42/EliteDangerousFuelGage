using FuleGage.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuleGage
{
    public partial class Settingbox : Form
    {
        public Settingbox()
        {
            InitializeComponent();
        }



        private void Settingbox_Load(object sender, EventArgs e)
        {

            RBG1.Text = Settings.Default.ColorR.ToString();
            RBG2.Text = Settings.Default.ColorG.ToString();
            RBG3.Text = Settings.Default.ColorB.ToString();


        }

        private void Applybutton_Click(object sender, EventArgs e)
        {
            Settings.Default.ColorR = int.Parse(RBG1.Text);
            Settings.Default.ColorG = int.Parse(RBG2.Text);
            Settings.Default.ColorB = int.Parse(RBG3.Text);
            Settings.Default.PosTop = MainWindow.Over.Location.Y;
            Settings.Default.PosRight = MainWindow.Over.Location.X;
            Settings.Default.Save();
            Settings.Default.Upgrade();
            

            this.Close();
            showoverlay.Checked = false;
        }

        private void Showoverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (showoverlay.Checked == true)

            {


                MainWindow.Over.TransparencyKey = Color.Empty;
                MainWindow.Over.FormBorderStyle = FormBorderStyle.FixedDialog;
                MainWindow.Over.Show();
            


            }
            else
            {
                MainWindow.Over.FormBorderStyle = FormBorderStyle.None;
                MainWindow.Over.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
                MainWindow.Over.Hide();


            }

        }

      




    }
}
