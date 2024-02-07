using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using static System.Net.WebRequestMethods;

namespace WeatherApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
      
        //Api Key That Is Given To Me
        string APIKey = "18dede3a5891aa7f0c4f991203e451c0";
        private void TBCITY_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }



        // Convert Unix timestamp to DateTime object in local timezone
        // Convert Unix timestamp to DateTime object in GMT timezone
        // Convert Unix timestamp to DateTime object in GMT timezone
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(sec);
            return TimeZoneInfo.ConvertTimeFromUtc(day, TimeZoneInfo.Utc);
        }


        double lon;
        double lat;
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", tbCity.Text, APIKey);

                try
                {
                    var json = web.DownloadString(url);
                    WeatherInformation.root info = JsonConvert.DeserializeObject<WeatherInformation.root>(json);

                    picIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                    lbCondition.Text = info.weather[0].main;
                    lbDetails.Text = info.weather[0].description;
                    /*
                       Nsunset.Text = DateTimeOffset.FromUnixTimeSeconds(info.sys.sunset).ToString("HH:mm:ss");
                       NSunrise.Text = DateTimeOffset.FromUnixTimeSeconds(info.sys.sunrise).ToString("HH:mm:ss");
                     I guess this time format needs to be fixed it shows wrong time
                    */
                    //lbSunset.Text = convertDateTime(info.sys.sunrise).ToString("HH:mm:ss");
                    // lbSunrise.Text = convertDateTime(info.sys.sunset).ToString("HH:mm:ss");

                    // Display the converted time in a specific timezone (e.g., UTC)
                    // Display the converted time in GMT
                    Nsunset.Text = convertDateTime(info.sys.sunrise).ToString("HH:mm:ss") + " GMT";
                    NSunrise.Text = convertDateTime(info.sys.sunset).ToString("HH:mm:ss") + " GMT";

                    WSN.Text = info.wind.speed.ToString();
                    NAPre.Text = info.main.pressure.ToString();

                    //longitude and latitude here
                    lon = info.coord.lon;
                    lat = info.coord.lat;
                }
                catch (WebException ex)
                {
                    // Handle exception (e.g., display an error message)
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //DateTime Conversion Method here

      

        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}", lat, lon,APIKey);
           
                //be carefull abou the link righ here
                try
                {
                    var json = web.DownloadString(url);
                    WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);
                    //same operations for only this method righ here 

                    ForecastUC FUC;
                    for (int i = 0;i <8; i++)
                    {
                        FUC = new ForecastUC();
                        FUC.picWeatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                        FUC.lbMainWeather.Text = ForecastInfo.daily[i].weather[0].main;
                        FUC.lbWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;
                        FUC.lbDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();


                        FLP.Controls.Add(FUC);
                      //since we have 8 days information in json before deserialzation we gonna use 
                      //loop for 8 days righ here

                    }
                }
                catch (WebException ex)
                {
                    // Handle exception (e.g., display an error message)
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




    }
}
