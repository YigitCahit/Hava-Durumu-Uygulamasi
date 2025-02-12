namespace Hava_Durumu
{
    partial class Form1
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
        private void InitializeComponent()
        {
            txtCity = new TextBox();
            btnGetWeather = new Button();
            lblTemperature = new Label();
            lblCondition = new Label();
            lblHumidity = new Label();
            lblWind = new Label();
            pbWeatherIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbWeatherIcon).BeginInit();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(12, 12);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Şehir";
            txtCity.Size = new Size(144, 23);
            txtCity.TabIndex = 0;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(12, 41);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(144, 23);
            btnGetWeather.TabIndex = 1;
            btnGetWeather.Text = "Hava Durumu";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(78, 70);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(46, 15);
            lblTemperature.TabIndex = 2;
            lblTemperature.Text = "Sıcaklık";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(78, 85);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(44, 15);
            lblCondition.TabIndex = 3;
            lblCondition.Text = "Durum";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Location = new Point(78, 100);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(33, 15);
            lblHumidity.TabIndex = 4;
            lblHumidity.Text = "Nem";
            // 
            // lblWind
            // 
            lblWind.AutoSize = true;
            lblWind.Location = new Point(78, 115);
            lblWind.Name = "lblWind";
            lblWind.Size = new Size(43, 15);
            lblWind.TabIndex = 5;
            lblWind.Text = "Rüzgar";
            // 
            // pbWeatherIcon
            // 
            pbWeatherIcon.Location = new Point(12, 70);
            pbWeatherIcon.Name = "pbWeatherIcon";
            pbWeatherIcon.Size = new Size(60, 60);
            pbWeatherIcon.TabIndex = 6;
            pbWeatherIcon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 281);
            Controls.Add(pbWeatherIcon);
            Controls.Add(lblWind);
            Controls.Add(lblHumidity);
            Controls.Add(lblCondition);
            Controls.Add(lblTemperature);
            Controls.Add(btnGetWeather);
            Controls.Add(txtCity);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Hava Durumu";
            ((System.ComponentModel.ISupportInitialize)pbWeatherIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCity;
        private Button btnGetWeather;
        private Label lblTemperature;
        private Label lblCondition;
        private Label lblHumidity;
        private Label lblWind;
        private PictureBox pbWeatherIcon;
    }
}
