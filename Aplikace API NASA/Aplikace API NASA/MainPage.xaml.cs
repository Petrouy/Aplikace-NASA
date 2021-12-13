using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Aplikace_API_NASA
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        static async Task Main(string[] args)
        {
            string API_KEY = "76j9PIp3V02cbCvlZUHtQneCn2vHChnhcIEx25c2";

            using (var hc = new HttpClient())
            {
                var response = await hc.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=API_KEY");
                return response;
            }
        }
    }
}
