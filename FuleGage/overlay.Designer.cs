namespace FuleGage
{
   public partial class Overlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.FuelReservoir_text = new System.Windows.Forms.Label();
            this.Fuel_res = new System.Windows.Forms.Label();
            this.FuelMain_text = new System.Windows.Forms.Label();
            this.Fuel_main = new System.Windows.Forms.Label();
            this.FuelUsed_text = new System.Windows.Forms.Label();
            this.FuelUsed = new System.Windows.Forms.Label();
            this.jumpDist = new System.Windows.Forms.Label();
            this.jumpDist_text = new System.Windows.Forms.Label();
            // 
            // FuelReservoir_text
            // 
            this.FuelReservoir_text.AutoSize = true;
            this.FuelReservoir_text.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FuelReservoir_text.Location = new System.Drawing.Point(2, 7);
            this.FuelReservoir_text.Name = "FuelReservoir_text";
            this.FuelReservoir_text.Size = new System.Drawing.Size(113, 20);
            this.FuelReservoir_text.TabIndex = 0;
            this.FuelReservoir_text.Text = "Fuel Reservoir";
            // 
            // Fuel_res
            // 
            this.Fuel_res.AutoSize = true;
            this.Fuel_res.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fuel_res.Location = new System.Drawing.Point(121, 7);
            this.Fuel_res.Name = "Fuel_res";
            this.Fuel_res.Size = new System.Drawing.Size(88, 20);
            this.Fuel_res.TabIndex = 1;
            this.Fuel_res.Text = "0.000000 T";
            // 
            // FuelMain_text
            // 
            this.FuelMain_text.AutoSize = true;
            this.FuelMain_text.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FuelMain_text.Location = new System.Drawing.Point(215, 7);
            this.FuelMain_text.Name = "FuelMain_text";
            this.FuelMain_text.Size = new System.Drawing.Size(84, 20);
            this.FuelMain_text.TabIndex = 2;
            this.FuelMain_text.Text = "Fuel main ";
            // 
            // Fuel_main
            // 
            this.Fuel_main.AutoSize = true;
            this.Fuel_main.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fuel_main.Location = new System.Drawing.Point(305, 7);
            this.Fuel_main.Name = "Fuel_main";
            this.Fuel_main.Size = new System.Drawing.Size(79, 20);
            this.Fuel_main.TabIndex = 2;
            this.Fuel_main.Text = "0.00000 T";
            // 
            // FuelUsed_text
            // 
            this.FuelUsed_text.AutoSize = true;
            this.FuelUsed_text.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FuelUsed_text.Location = new System.Drawing.Point(390, 7);
            this.FuelUsed_text.Name = "FuelUsed_text";
            this.FuelUsed_text.Size = new System.Drawing.Size(81, 20);
            this.FuelUsed_text.TabIndex = 3;
            this.FuelUsed_text.Text = "Fuel Used";
            // 
            // FuelUsed
            // 
            this.FuelUsed.AutoSize = true;
            this.FuelUsed.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FuelUsed.Location = new System.Drawing.Point(477, 7);
            this.FuelUsed.Name = "FuelUsed";
            this.FuelUsed.Size = new System.Drawing.Size(88, 20);
            this.FuelUsed.TabIndex = 4;
            this.FuelUsed.Text = "0.000000 T";
            // 
            // jumpDist
            // 
            this.jumpDist.AutoSize = true;
            this.jumpDist.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jumpDist.Location = new System.Drawing.Point(668, 7);
            this.jumpDist.Name = "jumpDist";
            this.jumpDist.Size = new System.Drawing.Size(88, 20);
            this.jumpDist.TabIndex = 5;
            this.jumpDist.Text = "0.00000 LY";
            // 
            // jumpDist_text
            // 
            this.jumpDist_text.AutoSize = true;
            this.jumpDist_text.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jumpDist_text.Location = new System.Drawing.Point(588, 7);
            this.jumpDist_text.Name = "jumpDist_text";
            this.jumpDist_text.Size = new System.Drawing.Size(76, 20);
            this.jumpDist_text.TabIndex = 7;
            this.jumpDist_text.Text = "jumpDist";
            // 
            // Overlay
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(796, 45);
            this.Controls.Add(this.jumpDist_text);
            this.Controls.Add(this.jumpDist);
            this.Controls.Add(this.FuelUsed);
            this.Controls.Add(this.FuelUsed_text);
            this.Controls.Add(this.FuelMain_text);
            this.Controls.Add(this.Fuel_res);
            this.Controls.Add(this.FuelReservoir_text);
            this.Controls.Add(this.Fuel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.Load += new System.EventHandler(this.Overlay_Load);

        }


        #endregion

        private System.Windows.Forms.Label FuelReservoir_text;
        private System.Windows.Forms.Label FuelMain_text;
        private System.Windows.Forms.Label FuelUsed_text;
        private System.Windows.Forms.Label jumpDist_text;
        public System.Windows.Forms.Label Fuel_res;
        public System.Windows.Forms.Label Fuel_main;
        public System.Windows.Forms.Label FuelUsed;
        public System.Windows.Forms.Label jumpDist;
    }
}