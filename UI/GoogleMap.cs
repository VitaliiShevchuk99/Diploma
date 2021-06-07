using GoogleMapsApi;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.Entities.Geocoding.Request;
using GoogleMapsApi.Entities.Geocoding.Response;
using GoogleMapsApi.StaticMaps;
using GoogleMapsApi.StaticMaps.Entities;
using System.Text;
using System.Windows.Controls;
using UI;
namespace UI
{
    public class GoogleMap
    {
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();
        public void GetMap()
        {

            string district = textBox1.Text;
            string province = textBox2.Text;
            string country = txtBox3.text;
            StringBuilder location = new StringBuilder("http://maps.google.com/maps?q=&#8221");
            if (district !=" "){
                location.Append(district + "," + "+");
            }
            if (province !=" "){
                location.Append(province + "," + "+");
            }
            if (country !=" "){
                location.Append(country + "," + "+");
            }
            Browser1.Navigate("location.ToString()");
        }
    }
}
