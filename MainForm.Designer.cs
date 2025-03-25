namespace Traffic_Lights
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblNorth = new System.Windows.Forms.Label();
            this.LblEast = new System.Windows.Forms.Label();
            this.LblSouth = new System.Windows.Forms.Label();
            this.LblWest = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ImgNorthGreen = new System.Windows.Forms.PictureBox();
            this.ImgNorthYellow = new System.Windows.Forms.PictureBox();
            this.ImgNorthRed = new System.Windows.Forms.PictureBox();
            this.ImgSouthRed = new System.Windows.Forms.PictureBox();
            this.ImgSouthYellow = new System.Windows.Forms.PictureBox();
            this.ImgSouthGreen = new System.Windows.Forms.PictureBox();
            this.ImgEastRed = new System.Windows.Forms.PictureBox();
            this.ImgEastYellow = new System.Windows.Forms.PictureBox();
            this.ImgEastGreen = new System.Windows.Forms.PictureBox();
            this.ImgWestRed = new System.Windows.Forms.PictureBox();
            this.ImgWestYellow = new System.Windows.Forms.PictureBox();
            this.ImgWestGreen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNorthGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNorthYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNorthRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSouthRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSouthYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSouthGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEastRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEastYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEastGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWestRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWestYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWestGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnStop);
            this.panel1.Controls.Add(this.BtnStart);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 112);
            this.panel1.TabIndex = 0;
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Red;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnStop.Location = new System.Drawing.Point(18, 57);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 39);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnStart.Location = new System.Drawing.Point(18, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 39);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblNorth
            // 
            this.LblNorth.AutoSize = true;
            this.LblNorth.BackColor = System.Drawing.Color.Transparent;
            this.LblNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNorth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNorth.Location = new System.Drawing.Point(235, 122);
            this.LblNorth.Name = "LblNorth";
            this.LblNorth.Size = new System.Drawing.Size(22, 23);
            this.LblNorth.TabIndex = 1;
            this.LblNorth.Text = "0";
            // 
            // LblEast
            // 
            this.LblEast.AutoSize = true;
            this.LblEast.BackColor = System.Drawing.Color.Transparent;
            this.LblEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEast.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEast.Location = new System.Drawing.Point(555, 224);
            this.LblEast.Name = "LblEast";
            this.LblEast.Size = new System.Drawing.Size(22, 23);
            this.LblEast.TabIndex = 2;
            this.LblEast.Text = "0";
            // 
            // LblSouth
            // 
            this.LblSouth.AutoSize = true;
            this.LblSouth.BackColor = System.Drawing.Color.Transparent;
            this.LblSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSouth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSouth.Location = new System.Drawing.Point(443, 535);
            this.LblSouth.Name = "LblSouth";
            this.LblSouth.Size = new System.Drawing.Size(22, 23);
            this.LblSouth.TabIndex = 3;
            this.LblSouth.Text = "0";
            // 
            // LblWest
            // 
            this.LblWest.AutoSize = true;
            this.LblWest.BackColor = System.Drawing.Color.Transparent;
            this.LblWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblWest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWest.Location = new System.Drawing.Point(120, 431);
            this.LblWest.Name = "LblWest";
            this.LblWest.Size = new System.Drawing.Size(22, 23);
            this.LblWest.TabIndex = 4;
            this.LblWest.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImgNorthGreen
            // 
            this.ImgNorthGreen.BackColor = System.Drawing.Color.Transparent;
            this.ImgNorthGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgNorthGreen.BackgroundImage")));
            this.ImgNorthGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgNorthGreen.Location = new System.Drawing.Point(232, 160);
            this.ImgNorthGreen.Name = "ImgNorthGreen";
            this.ImgNorthGreen.Size = new System.Drawing.Size(26, 26);
            this.ImgNorthGreen.TabIndex = 5;
            this.ImgNorthGreen.TabStop = false;
            this.ImgNorthGreen.Visible = false;
            // 
            // ImgNorthYellow
            // 
            this.ImgNorthYellow.BackColor = System.Drawing.Color.Transparent;
            this.ImgNorthYellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgNorthYellow.BackgroundImage")));
            this.ImgNorthYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgNorthYellow.Location = new System.Drawing.Point(232, 189);
            this.ImgNorthYellow.Name = "ImgNorthYellow";
            this.ImgNorthYellow.Size = new System.Drawing.Size(26, 26);
            this.ImgNorthYellow.TabIndex = 6;
            this.ImgNorthYellow.TabStop = false;
            this.ImgNorthYellow.Visible = false;
            // 
            // ImgNorthRed
            // 
            this.ImgNorthRed.BackColor = System.Drawing.Color.Transparent;
            this.ImgNorthRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgNorthRed.BackgroundImage")));
            this.ImgNorthRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgNorthRed.Location = new System.Drawing.Point(232, 217);
            this.ImgNorthRed.Name = "ImgNorthRed";
            this.ImgNorthRed.Size = new System.Drawing.Size(26, 26);
            this.ImgNorthRed.TabIndex = 7;
            this.ImgNorthRed.TabStop = false;
            // 
            // ImgSouthRed
            // 
            this.ImgSouthRed.BackColor = System.Drawing.Color.Transparent;
            this.ImgSouthRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgSouthRed.BackgroundImage")));
            this.ImgSouthRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgSouthRed.Location = new System.Drawing.Point(439, 494);
            this.ImgSouthRed.Name = "ImgSouthRed";
            this.ImgSouthRed.Size = new System.Drawing.Size(26, 26);
            this.ImgSouthRed.TabIndex = 10;
            this.ImgSouthRed.TabStop = false;
            // 
            // ImgSouthYellow
            // 
            this.ImgSouthYellow.BackColor = System.Drawing.Color.Transparent;
            this.ImgSouthYellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgSouthYellow.BackgroundImage")));
            this.ImgSouthYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgSouthYellow.Location = new System.Drawing.Point(439, 466);
            this.ImgSouthYellow.Name = "ImgSouthYellow";
            this.ImgSouthYellow.Size = new System.Drawing.Size(26, 26);
            this.ImgSouthYellow.TabIndex = 9;
            this.ImgSouthYellow.TabStop = false;
            this.ImgSouthYellow.Visible = false;
            // 
            // ImgSouthGreen
            // 
            this.ImgSouthGreen.BackColor = System.Drawing.Color.Transparent;
            this.ImgSouthGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgSouthGreen.BackgroundImage")));
            this.ImgSouthGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgSouthGreen.Location = new System.Drawing.Point(439, 437);
            this.ImgSouthGreen.Name = "ImgSouthGreen";
            this.ImgSouthGreen.Size = new System.Drawing.Size(26, 26);
            this.ImgSouthGreen.TabIndex = 8;
            this.ImgSouthGreen.TabStop = false;
            this.ImgSouthGreen.Visible = false;
            // 
            // ImgEastRed
            // 
            this.ImgEastRed.BackColor = System.Drawing.Color.Transparent;
            this.ImgEastRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgEastRed.BackgroundImage")));
            this.ImgEastRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgEastRed.Location = new System.Drawing.Point(502, 222);
            this.ImgEastRed.Name = "ImgEastRed";
            this.ImgEastRed.Size = new System.Drawing.Size(26, 26);
            this.ImgEastRed.TabIndex = 13;
            this.ImgEastRed.TabStop = false;
            this.ImgEastRed.Visible = false;
            // 
            // ImgEastYellow
            // 
            this.ImgEastYellow.BackColor = System.Drawing.Color.Transparent;
            this.ImgEastYellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgEastYellow.BackgroundImage")));
            this.ImgEastYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgEastYellow.Location = new System.Drawing.Point(474, 222);
            this.ImgEastYellow.Name = "ImgEastYellow";
            this.ImgEastYellow.Size = new System.Drawing.Size(26, 26);
            this.ImgEastYellow.TabIndex = 12;
            this.ImgEastYellow.TabStop = false;
            // 
            // ImgEastGreen
            // 
            this.ImgEastGreen.BackColor = System.Drawing.Color.Transparent;
            this.ImgEastGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgEastGreen.BackgroundImage")));
            this.ImgEastGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgEastGreen.Location = new System.Drawing.Point(445, 222);
            this.ImgEastGreen.Name = "ImgEastGreen";
            this.ImgEastGreen.Size = new System.Drawing.Size(26, 26);
            this.ImgEastGreen.TabIndex = 11;
            this.ImgEastGreen.TabStop = false;
            this.ImgEastGreen.Visible = false;
            // 
            // ImgWestRed
            // 
            this.ImgWestRed.BackColor = System.Drawing.Color.Transparent;
            this.ImgWestRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgWestRed.BackgroundImage")));
            this.ImgWestRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgWestRed.Location = new System.Drawing.Point(168, 429);
            this.ImgWestRed.Name = "ImgWestRed";
            this.ImgWestRed.Size = new System.Drawing.Size(26, 26);
            this.ImgWestRed.TabIndex = 16;
            this.ImgWestRed.TabStop = false;
            // 
            // ImgWestYellow
            // 
            this.ImgWestYellow.BackColor = System.Drawing.Color.Transparent;
            this.ImgWestYellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgWestYellow.BackgroundImage")));
            this.ImgWestYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgWestYellow.Location = new System.Drawing.Point(197, 429);
            this.ImgWestYellow.Name = "ImgWestYellow";
            this.ImgWestYellow.Size = new System.Drawing.Size(26, 26);
            this.ImgWestYellow.TabIndex = 15;
            this.ImgWestYellow.TabStop = false;
            this.ImgWestYellow.Visible = false;
            // 
            // ImgWestGreen
            // 
            this.ImgWestGreen.BackColor = System.Drawing.Color.Transparent;
            this.ImgWestGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgWestGreen.BackgroundImage")));
            this.ImgWestGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgWestGreen.Location = new System.Drawing.Point(226, 429);
            this.ImgWestGreen.Name = "ImgWestGreen";
            this.ImgWestGreen.Size = new System.Drawing.Size(26, 26);
            this.ImgWestGreen.TabIndex = 14;
            this.ImgWestGreen.TabStop = false;
            this.ImgWestGreen.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.ImgWestRed);
            this.Controls.Add(this.ImgWestYellow);
            this.Controls.Add(this.ImgWestGreen);
            this.Controls.Add(this.ImgEastRed);
            this.Controls.Add(this.ImgEastYellow);
            this.Controls.Add(this.ImgEastGreen);
            this.Controls.Add(this.ImgSouthRed);
            this.Controls.Add(this.ImgSouthYellow);
            this.Controls.Add(this.ImgSouthGreen);
            this.Controls.Add(this.ImgNorthRed);
            this.Controls.Add(this.ImgNorthYellow);
            this.Controls.Add(this.ImgNorthGreen);
            this.Controls.Add(this.LblWest);
            this.Controls.Add(this.LblSouth);
            this.Controls.Add(this.LblEast);
            this.Controls.Add(this.LblNorth);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Lights";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgNorthGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNorthYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNorthRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSouthRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSouthYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSouthGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEastRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEastYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEastGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWestRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWestYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWestGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label LblNorth;
        private System.Windows.Forms.Label LblEast;
        private System.Windows.Forms.Label LblSouth;
        private System.Windows.Forms.Label LblWest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ImgNorthGreen;
        private System.Windows.Forms.PictureBox ImgNorthYellow;
        private System.Windows.Forms.PictureBox ImgNorthRed;
        private System.Windows.Forms.PictureBox ImgSouthRed;
        private System.Windows.Forms.PictureBox ImgSouthYellow;
        private System.Windows.Forms.PictureBox ImgSouthGreen;
        private System.Windows.Forms.PictureBox ImgEastRed;
        private System.Windows.Forms.PictureBox ImgEastYellow;
        private System.Windows.Forms.PictureBox ImgEastGreen;
        private System.Windows.Forms.PictureBox ImgWestRed;
        private System.Windows.Forms.PictureBox ImgWestYellow;
        private System.Windows.Forms.PictureBox ImgWestGreen;
    }
}

