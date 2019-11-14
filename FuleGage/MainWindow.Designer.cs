using System;
using FuleGage.Properties;


namespace FuleGage
{
    public partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.res = new System.Windows.Forms.Label();
            this.res_value = new System.Windows.Forms.Label();
            this.MTank = new System.Windows.Forms.Label();
            this.Mtanke_value = new System.Windows.Forms.Label();
            this.Used = new System.Windows.Forms.Label();
            this.used_value = new System.Windows.Forms.Label();
            this.Jump = new System.Windows.Forms.Label();
            this.Jump_value = new System.Windows.Forms.Label();
            
            this.overlay_box = new System.Windows.Forms.CheckBox();
            this.Bution_seeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(20, 19);
            this.res.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(104, 19);
            this.res.TabIndex = 0;
            this.res.Text = "Fuel Reservoir";
            // 
            // res_value
            // 
            this.res_value.AutoSize = true;
            this.res_value.Location = new System.Drawing.Point(162, 19);
            this.res_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.res_value.Name = "res_value";
            this.res_value.Size = new System.Drawing.Size(82, 19);
            this.res_value.TabIndex = 1;
            this.res_value.Text = "0.000000 T";
            // 
            // MTank
            // 
            this.MTank.AutoSize = true;
            this.MTank.Location = new System.Drawing.Point(20, 69);
            this.MTank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MTank.Name = "MTank";
            this.MTank.Size = new System.Drawing.Size(78, 19);
            this.MTank.TabIndex = 2;
            this.MTank.Text = "Fuel Main";
            // 
            // Mtanke_value
            // 
            this.Mtanke_value.AutoSize = true;
            this.Mtanke_value.Location = new System.Drawing.Point(162, 69);
            this.Mtanke_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mtanke_value.Name = "Mtanke_value";
            this.Mtanke_value.Size = new System.Drawing.Size(82, 19);
            this.Mtanke_value.TabIndex = 3;
            this.Mtanke_value.Text = "0.000000 T";
            // 
            // Used
            // 
            this.Used.AutoSize = true;
            this.Used.Location = new System.Drawing.Point(20, 120);
            this.Used.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Used.Name = "Used";
            this.Used.Size = new System.Drawing.Size(76, 19);
            this.Used.TabIndex = 4;
            this.Used.Text = "Fuel Used";
            // 
            // used_value
            // 
            this.used_value.AutoSize = true;
            this.used_value.Location = new System.Drawing.Point(162, 120);
            this.used_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.used_value.Name = "used_value";
            this.used_value.Size = new System.Drawing.Size(82, 19);
            this.used_value.TabIndex = 5;
            this.used_value.Text = "0.000000 T";
            // 
            // Jump
            // 
            this.Jump.AutoSize = true;
            this.Jump.Location = new System.Drawing.Point(20, 171);
            this.Jump.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump.Name = "Jump";
            this.Jump.Size = new System.Drawing.Size(74, 19);
            this.Jump.TabIndex = 6;
            this.Jump.Text = "JumpDist";
            // 
            // Jump_value
            // 
            this.Jump_value.AutoSize = true;
            this.Jump_value.Location = new System.Drawing.Point(162, 171);
            this.Jump_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump_value.Name = "Jump_value";
            this.Jump_value.Size = new System.Drawing.Size(82, 19);
            this.Jump_value.TabIndex = 7;
            this.Jump_value.Text = "0.00000 LY";
            // 
            
            
            
            // 
            // overlay_box
            // 
            this.overlay_box.AutoSize = true;
            this.overlay_box.Location = new System.Drawing.Point(18, 193);
            this.overlay_box.Name = "overlay_box";
            this.overlay_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.overlay_box.Size = new System.Drawing.Size(80, 23);
            this.overlay_box.TabIndex = 8;
            this.overlay_box.Text = "Overlay";
            this.overlay_box.UseVisualStyleBackColor = true;
            this.overlay_box.CheckedChanged += new System.EventHandler(this.Overlay_box_CheckedChanged);
            // 
            // Bution_seeting
            // 
            this.Bution_seeting.BackColor = System.Drawing.Color.Silver;
            this.Bution_seeting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bution_seeting.Location = new System.Drawing.Point(153, 192);
            this.Bution_seeting.Name = "Bution_seeting";
            this.Bution_seeting.Size = new System.Drawing.Size(75, 23);
            this.Bution_seeting.TabIndex = 9;
            this.Bution_seeting.Text = "Setting";
            this.Bution_seeting.UseVisualStyleBackColor = false;
            this.Bution_seeting.Click += new System.EventHandler(this.Bution_seeting_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(249, 221);
            this.Controls.Add(this.Bution_seeting);
            this.Controls.Add(this.overlay_box);
            this.Controls.Add(this.Jump_value);
            this.Controls.Add(this.Jump);
            this.Controls.Add(this.used_value);
            this.Controls.Add(this.Used);
            this.Controls.Add(this.Mtanke_value);
            this.Controls.Add(this.MTank);
            this.Controls.Add(this.res_value);
            this.Controls.Add(this.res);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        //   this.Icon = ((System.Drawing.Icon)(resources.GetObject("Imperial_Cutter")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel tank";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion


        private System.Windows.Forms.Label res;
        public System.Windows.Forms.Label res_value;
        private System.Windows.Forms.Label MTank;
        public System.Windows.Forms.Label Mtanke_value;
        private System.Windows.Forms.Label Used;
        public System.Windows.Forms.Label used_value;
        private System.Windows.Forms.Label Jump;
        public System.Windows.Forms.Label Jump_value;
        private System.Windows.Forms.CheckBox overlay_box;
        private System.Windows.Forms.Button Bution_seeting;
    }
}

