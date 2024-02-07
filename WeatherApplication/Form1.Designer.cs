namespace WeatherApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbCondition = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.lbSunrise = new System.Windows.Forms.Label();
            this.NSunrise = new System.Windows.Forms.Label();
            this.lbSunset = new System.Windows.Forms.Label();
            this.Nsunset = new System.Windows.Forms.Label();
            this.lbWind = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.WSN = new System.Windows.Forms.Label();
            this.NAPre = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.BackColor = System.Drawing.Color.Transparent;
            this.lbCity.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCity.ForeColor = System.Drawing.Color.White;
            this.lbCity.Location = new System.Drawing.Point(172, 73);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(75, 39);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City:";
            this.lbCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCity.Click += new System.EventHandler(this.TBCITY_Click);
            // 
            // tbCity
            // 
            this.tbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCity.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCity.Location = new System.Drawing.Point(286, 73);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(626, 47);
            this.tbCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(957, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 56);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.BackColor = System.Drawing.Color.Transparent;
            this.lbCondition.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCondition.ForeColor = System.Drawing.Color.White;
            this.lbCondition.Location = new System.Drawing.Point(172, 302);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(144, 39);
            this.lbCondition.TabIndex = 3;
            this.lbCondition.Text = "Condition";
            this.lbCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbDetails.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDetails.ForeColor = System.Drawing.Color.White;
            this.lbDetails.Location = new System.Drawing.Point(172, 381);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(106, 39);
            this.lbDetails.TabIndex = 4;
            this.lbDetails.Text = "Details";
            this.lbDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSunrise
            // 
            this.lbSunrise.AutoSize = true;
            this.lbSunrise.BackColor = System.Drawing.Color.Transparent;
            this.lbSunrise.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSunrise.ForeColor = System.Drawing.Color.White;
            this.lbSunrise.Location = new System.Drawing.Point(172, 472);
            this.lbSunrise.Name = "lbSunrise";
            this.lbSunrise.Size = new System.Drawing.Size(113, 39);
            this.lbSunrise.TabIndex = 5;
            this.lbSunrise.Text = "Sunrise";
            this.lbSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSunrise
            // 
            this.NSunrise.AutoSize = true;
            this.NSunrise.BackColor = System.Drawing.Color.Transparent;
            this.NSunrise.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NSunrise.ForeColor = System.Drawing.Color.White;
            this.NSunrise.Location = new System.Drawing.Point(284, 559);
            this.NSunrise.Name = "NSunrise";
            this.NSunrise.Size = new System.Drawing.Size(68, 39);
            this.NSunrise.TabIndex = 6;
            this.NSunrise.Text = "N/A";
            this.NSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSunset
            // 
            this.lbSunset.AutoSize = true;
            this.lbSunset.BackColor = System.Drawing.Color.Transparent;
            this.lbSunset.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSunset.ForeColor = System.Drawing.Color.White;
            this.lbSunset.Location = new System.Drawing.Point(172, 559);
            this.lbSunset.Name = "lbSunset";
            this.lbSunset.Size = new System.Drawing.Size(106, 39);
            this.lbSunset.TabIndex = 7;
            this.lbSunset.Text = "Sunset";
            this.lbSunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nsunset
            // 
            this.Nsunset.AutoSize = true;
            this.Nsunset.BackColor = System.Drawing.Color.Transparent;
            this.Nsunset.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Nsunset.ForeColor = System.Drawing.Color.White;
            this.Nsunset.Location = new System.Drawing.Point(291, 472);
            this.Nsunset.Name = "Nsunset";
            this.Nsunset.Size = new System.Drawing.Size(68, 39);
            this.Nsunset.TabIndex = 8;
            this.Nsunset.Text = "N/A";
            this.Nsunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWind
            // 
            this.lbWind.AutoSize = true;
            this.lbWind.BackColor = System.Drawing.Color.Transparent;
            this.lbWind.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbWind.ForeColor = System.Drawing.Color.White;
            this.lbWind.Location = new System.Drawing.Point(908, 454);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(174, 39);
            this.lbWind.TabIndex = 9;
            this.lbWind.Text = "Wind Speed";
            this.lbWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.BackColor = System.Drawing.Color.Transparent;
            this.lbPressure.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPressure.ForeColor = System.Drawing.Color.White;
            this.lbPressure.Location = new System.Drawing.Point(908, 559);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(131, 39);
            this.lbPressure.TabIndex = 10;
            this.lbPressure.Text = "Pressure";
            this.lbPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WSN
            // 
            this.WSN.AutoSize = true;
            this.WSN.BackColor = System.Drawing.Color.Transparent;
            this.WSN.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WSN.ForeColor = System.Drawing.Color.White;
            this.WSN.Location = new System.Drawing.Point(1117, 454);
            this.WSN.Name = "WSN";
            this.WSN.Size = new System.Drawing.Size(68, 39);
            this.WSN.TabIndex = 11;
            this.WSN.Text = "N/A";
            this.WSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NAPre
            // 
            this.NAPre.AutoSize = true;
            this.NAPre.BackColor = System.Drawing.Color.Transparent;
            this.NAPre.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NAPre.ForeColor = System.Drawing.Color.White;
            this.NAPre.Location = new System.Drawing.Point(1117, 559);
            this.NAPre.Name = "NAPre";
            this.NAPre.Size = new System.Drawing.Size(68, 39);
            this.NAPre.TabIndex = 12;
            this.NAPre.Text = "N/A";
            this.NAPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(179, 160);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(180, 105);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // FLP
            // 
            this.FLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(140, 627);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(1045, 158);
            this.FLP.TabIndex = 14;
            this.FLP.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 873);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.NAPre);
            this.Controls.Add(this.WSN);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbWind);
            this.Controls.Add(this.Nsunset);
            this.Controls.Add(this.lbSunset);
            this.Controls.Add(this.NSunrise);
            this.Controls.Add(this.lbSunrise);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.lbCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lbCity);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Label lbSunrise;
        private System.Windows.Forms.Label NSunrise;
        private System.Windows.Forms.Label lbSunset;
        private System.Windows.Forms.Label Nsunset;
        private System.Windows.Forms.Label lbWind;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label WSN;
        private System.Windows.Forms.Label NAPre;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

