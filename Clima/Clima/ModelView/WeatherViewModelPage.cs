using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Clima.ModelView
{
    public class WeatherViewModelPage : NotificableViewModel
    {
        #region Atributos
        private string ubicacion;
        private string pais;
        private string resultTerm;
        private string region;
        private string ultimaActualizacion;
        private string clima;
        private string temperatura;
        private ImageSource imagen;
        #endregion

        #region Propiedades
        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                SetValue(ref region, value);
            }
        }

        public string UltimaActualizacion
        {
            get
            {
                return UltimaActualizacion;
            }
            set
            {
                SetValue(ref ultimaActualizacion, value);
            }
        }

        public string Clima
        {
            get
            {
                return clima;
            }
            set
            {
                SetValue(ref clima, value);
            }
        }


        public string Temperatura
        {
            get
            {
                return Temperatura;
            }
            set
            {
                SetValue(ref temperatura, value);
            }
        }


        public string Ubicacion
        {
            get
            {
                return Ubicacion;
            }
            set
            {
                SetValue(ref ubicacion, value);
            }
        }

        public string Pais
        {
            get
            {
                return Pais;
            }
            set
            {
                SetValue(ref pais, value);
            }
        }

        public string ResulTerm
        {
            get
            {
                return resultTerm;
            }
            set
            {
                SetValue(ref resultTerm, value);

            }

        }

        public string ImageSource Imagen
        {
            get
            {
                return imagen;
            }
    set
            {
                SetValue(ref imagen, value);
}

#endregion




