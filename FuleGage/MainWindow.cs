using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using FuleGage.Properties;





namespace FuleGage
{

    public partial class MainWindow : Form
    {
        static readonly string logpath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Saved Games\Frontier Developments\Elite Dangerous\");
        private readonly DirectoryInfo LogDictory;
        private static readonly FileSystemWatcher Logs = new FileSystemWatcher(logpath);
        public string MainFuel, resFuel, Usedinjump, dist;
        public static Overlay Over = new Overlay();
        public static Settingbox settings = new Settingbox();
        public Status statusfile;
        public Allinfo info;
        public FSDJumpInfo LastFsdJump;
        public Point z;


        public MainWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Logs.EnableRaisingEvents = true;
            Logs.Changed += Logs_Changed;
            LogDictory = new DirectoryInfo(logpath);
            Logs.NotifyFilter = NotifyFilters.LastWrite;
            
            
        }

        private void Logs_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                Logs.EnableRaisingEvents = false;

                FileInfo fileLog = LogDictory.GetFiles("*.log").OrderByDescending(x => x.LastWriteTime).First();


                OpenLog(fileLog);

                Jumpdatat(LastFsdJump);


                if (e.Name == "Status.json")
                {
                    FileInfo SJs = new FileInfo(e.FullPath);
                    OpenStatus(SJs);
                    StatusUdate(statusfile);

                }

            }
            finally
            {
                Logs.EnableRaisingEvents = true;
            }


        }

        private void Bution_seeting_Click(object sender, EventArgs e)
        {

           settings.ShowDialog();
            settings.Activate();
        }
        private void Overlay_box_CheckedChanged(object sender, EventArgs e)
        {

            if (overlay_box.Checked)
            {
                Point z = new Point( Settings.Default.PosRight, Settings.Default.PosTop);
                Over.ColorUpate();

                Over.Location = z;
                if (Over.IsDisposed)
                {
                    Over = new Overlay();
                }
                Over.Show();
                
            }
            else
            {
                Over.Close();
            }

        }

        private void Jumpdatat(FSDJumpInfo jumps)
        {

            Usedinjump = jumps.FuelUsed.ToString() + " T";
            dist = jumps.JumpDist.ToString("N2") + " LY";
            Jump_value.Text = dist;
            used_value.Text = Usedinjump;


            if (overlay_box.Checked)
            {
                OverLayUdate();
            }

        }

        private void OpenStatus(FileInfo info)
        {

            FileStream file = info.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader SW = new StreamReader(file);
            string lines = null;
            Status StatusNull = new Status();

            while (!SW.EndOfStream)
            {
                lines = SW.ReadToEnd();

            }
            if (lines == null)
            {
                statusfile = StatusNull;
            }
            else
            {
                statusfile = JsonSerializer.Deserialize<Status>(lines);
            }



            file.Dispose();
            SW.Dispose();





        }

        private void OverLayUdate()
        {
            Over.FuelUsed.Text = Usedinjump;
            Over.jumpDist.Text = dist;
            Over.Fuel_main.Text = MainFuel;
            Over.Fuel_res.Text = resFuel;
        }
        private void OpenLog(FileInfo log)
        {

            FileStream LogFile = log.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader SW = new StreamReader(LogFile);
            List<FSDJumpInfo> Fsdjumps = new List<FSDJumpInfo>();
            while (!SW.EndOfStream)
            {
                string json = SW.ReadLine();
                Allinfo All = JsonSerializer.Deserialize<Allinfo>(json);
                if (All.Event == "FSDJump")
                {
                    FSDJumpInfo jump = JsonSerializer.Deserialize<FSDJumpInfo>(json);
                    Fsdjumps.Add(jump);
                }

            }
            if (Fsdjumps.Count == 0)
            {
                FSDJumpInfo FsdNul = new FSDJumpInfo();
                Fsdjumps.Add(FsdNul);
            }
            LastFsdJump = Fsdjumps.Last();
            Fsdjumps.Clear();
            LogFile.Close();
            SW.Close();
            SW.Dispose();

        }
        private void StatusUdate(Status Stat)
        {
            if (Stat == null)
            {
                Stat = new Status();
            }

            if (Stat.Fuel != null)
            {
                MainFuel = Stat.Fuel.FuelMain.ToString("N3") + " T";
                resFuel = Stat.Fuel.FuelReservoir.ToString("N2") + " T";
                res_value.Text = resFuel;
                Mtanke_value.Text = MainFuel;
            }
            else
            {
               
                res_value.Text = resFuel;
                Mtanke_value.Text = MainFuel;
            }
            if (Stat.InSRV == true)
            {
                SrvUpdate();
            }
            if (Stat.InFighter == true)
            {
                FighterUpdate();
            }


            if (overlay_box.Checked)
            {
                OverLayUdate();
            }
        }
        private void SrvUpdate()
        {
            MainFuel = "In SRV";
            Usedinjump = "IN SRV";
            dist = "In SRV";
            Mtanke_value.Text = MainFuel;
            Jump_value.Text = dist;
            used_value.Text = Usedinjump;

        }
        private void FighterUpdate()
        {
            MainFuel = "In Fighter";
            Usedinjump = "In Fighter";
            dist = "In Fighter";
            Mtanke_value.Text = MainFuel;
            Jump_value.Text = dist;
            used_value.Text = Usedinjump;
        }

    }


}

