using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace pogoda3
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private const string ApiUrl = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,precipitation";

        public Form1()
        {
            InitializeComponent();
            StartTimer();
            LoadWeatherData();
        }

        private void StartTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 900000; 
            timer.Tick += (sender, e) => LoadWeatherData();
            timer.Start();
        }

      
        private void LoadWeatherData()
        {
            try
            {
            
                HttpClient client = new HttpClient();

       
                client.BaseAddress = new Uri(ApiUrl);

             
                HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;

              
                if (response.IsSuccessStatusCode)
                {
             
                    string result = response.Content.ReadAsStringAsync().Result;

          
                    var data = JObject.Parse(result);

     
                    var temperature = data["current"]?["temperature_2m"]?.ToString();

        
                    var humidity = data["current"]?["relative_humidity_2m"]?.ToString();

                    var precipitation = data["current"]?["precipitation"]?.ToString();

             
                    var lastUpdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

               
                    lblTemperatura.Text = $"{temperature} °C";
                    lblWilgotnosc.Text = !string.IsNullOrEmpty(humidity) ? $"{humidity} %" : "Brak danych";
                    lblOpady.Text = !string.IsNullOrEmpty(precipitation) ? $"{precipitation} mm" : "Brak opadów";
                    lblAktualizacja.Text = $"Ostatnia aktualizacja: {lastUpdate}";
                }
                else
                {
                    MessageBox.Show("B³¹d pobierania danych z API");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d pobierania danych: {ex.Message}");
            }
        }

     
    }
}
