using System;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Clima.ViewModel
{
    using ModelView;
    public class WeatherViewModelPage : NotificableModelView
    {
        #region Atributos
        private string temperatura;
        private ImageSource image;


        #endregion

        #region Propiedades

        public ImageSource Image
        {
            get { return image; }
        }


        public string ResultTerm
private string resultTerm;

        public string ResultTerm
        {
            get { return resultTerm; }
            set


        #endregion

            #region Commandos

        public ICommand BuscarCommand
        {
            get
            {
                return new RelayCommand(Buscar);
            }
        }

        public string Ubicacion { get; private set; }
        public string Pais { get; private set; }
        public string Region { get; private set; }
        public string UltimaActualizacion { get; private set; }
        public string Temperatura { get; private set; }
        public string Clima { get; private set; }
        #endregion

        #region Metodos
        private async void Buscar()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(ObtenerURL());
            var response = await cliente.GetAsync(cliente.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            var weatherModel = Weather.FromJson(jsonResult);
            FijarValores(weatherModel);
        }

        private void FijarValores(Weather weatherModel)
        {
            Ubicacion = weatherModel.Query.Results.Channel.Location.City;
            Pais = weatherModel.Query.Results.Channel.Location.Country;
            Region = weatherModel.Query.Results.Channel.Location.Region;
            UltimaActualizacion = weatherModel.Query.Results.Channel.Item.Condition.Date;
            Temperatura = weatherModel.Query.Results.Channel.Item.Condition.Temp;
            Clima = weatherModel.Query.Results.Channel.Item.Condition.Text
            var img\Link = $"http://l.yimg.com/a/i/us/we/52/{}.gif"
        }

        private string ObtenerURL()
        {
            string serviceURL = $"https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22{ResultTerm}%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            return serviceURL;
        }
        #endregion



    }

    public class NotificableModelView
    {
    }
}
