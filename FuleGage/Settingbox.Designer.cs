namespace FuleGage
{
    partial class Settingbox
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
            this.Applybutton = new System.Windows.Forms.Button();
            this.RBG1 = new System.Windows.Forms.TextBox();
            this.RBG2 = new System.Windows.Forms.TextBox();
            this.RBG3 = new System.Windows.Forms.TextBox();
            this.showoverlay = new System.Windows.Forms.CheckBox();
            this.GreenLable = new System.Windows.Forms.Label();
            this.blueLable = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            // 
            // Applybutton
            // 
            this.Applybutton.Location = new System.Drawing.Point(124, 126);
            this.Applybutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Applybutton.Name = "Applybutton";
            this.Applybutton.Size = new System.Drawing.Size(88, 27);
            this.Applybutton.TabIndex = 5;
            this.Applybutton.Text = "OK";
            this.Applybutton.UseVisualStyleBackColor = true;
            this.Applybutton.Click += new System.EventHandler(this.Applybutton_Click);
            // 
            // RBG1
            // 
            this.RBG1.Location = new System.Drawing.Point(14, 58);
            this.RBG1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBG1.MaxLength = 3;
            this.RBG1.Name = "RBG1";
            this.RBG1.Size = new System.Drawing.Size(62, 23);
            this.RBG1.TabIndex = 1;
            // 
            // RBG2
            // 
            this.RBG2.Location = new System.Drawing.Point(84, 58);
            this.RBG2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBG2.MaxLength = 3;
            this.RBG2.Name = "RBG2";
            this.RBG2.Size = new System.Drawing.Size(60, 23);
            this.RBG2.TabIndex = 2;
            // 
            // RBG3
            // 
            this.RBG3.Location = new System.Drawing.Point(152, 58);
            this.RBG3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBG3.MaxLength = 3;
            this.RBG3.Name = "RBG3";
            this.RBG3.Size = new System.Drawing.Size(60, 23);
            this.RBG3.TabIndex = 3;
            // 
            // showoverlay
            // 
            this.showoverlay.AutoSize = true;
            this.showoverlay.Location = new System.Drawing.Point(14, 87);
            this.showoverlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showoverlay.Name = "showoverlay";
            this.showoverlay.Size = new System.Drawing.Size(156, 19);
            this.showoverlay.TabIndex = 4;
            this.showoverlay.Text = "Show overlay backgrond";
            this.showoverlay.UseVisualStyleBackColor = true;
            this.showoverlay.CheckedChanged += new System.EventHandler(this.Showoverlay_CheckedChanged);
            // 
            // GreenLable
            // 
            this.GreenLable.AutoSize = true;
            this.GreenLable.Location = new System.Drawing.Point(84, 40);
            this.GreenLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GreenLable.Name = "GreenLable";
            this.GreenLable.Size = new System.Drawing.Size(38, 15);
            this.GreenLable.TabIndex = 6;
            this.GreenLable.Text = "Green";
            // 
            // blueLable
            // 
            this.blueLable.AutoSize = true;
            this.blueLable.Location = new System.Drawing.Point(152, 40);
            this.blueLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blueLable.Name = "blueLable";
            this.blueLable.Size = new System.Drawing.Size(30, 15);
            this.blueLable.TabIndex = 6;
            this.blueLable.Text = "Blue";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(14, 40);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 15);
            this.RedLabel.TabIndex = 13;
            this.RedLabel.Text = "Red";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(14, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(103, 15);
            this.title.TabIndex = 14;
            this.title.Text = "Overlay Text Color";
            // 
            // Settingbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(262, 194);
            this.ControlBox = false;
            this.Controls.Add(this.title);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.showoverlay);
            this.Controls.Add(this.Applybutton);
            this.Controls.Add(this.RBG1);
            this.Controls.Add(this.RBG2);
            this.Controls.Add(this.RBG3);
            this.Controls.Add(this.GreenLable);
            this.Controls.Add(this.blueLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settingbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Settingbox_Load);

        }

        #endregion
        private System.Windows.Forms.Button Applybutton;
        public System.Windows.Forms.TextBox RBG1;
        public System.Windows.Forms.TextBox RBG2;
        public System.Windows.Forms.TextBox RBG3;
        private System.Windows.Forms.CheckBox showoverlay;
        private System.Windows.Forms.Label GreenLable;
        private System.Windows.Forms.Label blueLable;
     
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label title;
    }
}