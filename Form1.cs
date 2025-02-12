using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing;

namespace Hava_Durumu
{
    public partial class Form1 : Form
    {
        private string apiKey = "API_Key";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            if (!string.IsNullOrWhiteSpace(city))
            {
                GetWeather(city);
            }
            else
            {
                GetWeather("auto:ip");
            }
        }

        private void GetWeather(string city)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}";
                    string json = client.DownloadString(url);
                    dynamic weatherData = JsonConvert.DeserializeObject(json);
                    string temperature = weatherData.current.temp_c + "°C";
                    string condition = weatherData.current.condition.text;
                    string humidity = "Nem: " + weatherData.current.humidity + "%";
                    string wind = "Rüzgar: " + weatherData.current.wind_kph + " km/h";
                    string iconUrl = "https:" + weatherData.current.condition.icon;

                    lblTemperature.Text = "Sýcaklýk: " + temperature;
                    lblCondition.Text = "Durum: " + condition;
                    lblHumidity.Text = humidity;
                    lblWind.Text = wind;
                    pbWeatherIcon.Load(iconUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hava durumu bilgisi alýnamadý!\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
