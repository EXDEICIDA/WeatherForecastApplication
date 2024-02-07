namespace WeatherApplication
{
    partial class ForecastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.lbDT = new System.Windows.Forms.Label();
            this.lbMainWeather = new System.Windows.Forms.Label();
            this.lbWeatherDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(15, 3);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(98, 83);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDT.Location = new System.Drawing.Point(119, 3);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(80, 25);
            this.lbDT.TabIndex = 1;
            this.lbDT.Text = "Sunday";
            // 
            // lbMainWeather
            // 
            this.lbMainWeather.AutoSize = true;
            this.lbMainWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMainWeather.Location = new System.Drawing.Point(119, 28);
            this.lbMainWeather.Name = "lbMainWeather";
            this.lbMainWeather.Size = new System.Drawing.Size(59, 25);
            this.lbMainWeather.TabIndex = 2;
            this.lbMainWeather.Text = "Clear";
            // 
            // lbWeatherDescription
            // 
            this.lbWeatherDescription.AutoSize = true;
            this.lbWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbWeatherDescription.Location = new System.Drawing.Point(119, 53);
            this.lbWeatherDescription.Name = "lbWeatherDescription";
            this.lbWeatherDescription.Size = new System.Drawing.Size(109, 25);
            this.lbWeatherDescription.TabIndex = 3;
            this.lbWeatherDescription.Text = "Description";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbWeatherDescription);
            this.Controls.Add(this.lbMainWeather);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.picWeatherIcon);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(257, 96);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label lbDT;
        public System.Windows.Forms.Label lbMainWeather;
        public System.Windows.Forms.Label lbWeatherDescription;
    }
}
