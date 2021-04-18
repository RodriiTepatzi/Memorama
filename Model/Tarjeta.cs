using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Memorama
{
    class Tarjeta
    {

        public List<string> tarjetas = new List<string>
           {"Tarjeta_1",
            "Tarjeta_2",
            "Tarjeta_3",
            "Tarjeta_4",
            "Tarjeta_5",
            "Tarjeta_6",
            "Tarjeta_7",
            "Tarjeta_8",
            "Tarjeta_9",
            "Tarjeta_10"};

        public List<string> tarjetas_hidden = new List<string>
           {"Tarjeta_1_Hidden",
            "Tarjeta_2_Hidden",
            "Tarjeta_3_Hidden",
            "Tarjeta_4_Hidden",
            "Tarjeta_5_Hidden",
            "Tarjeta_6_Hidden",
            "Tarjeta_7_Hidden",
            "Tarjeta_8_Hidden",
            "Tarjeta_9_Hidden",
            "Tarjeta_10_Hidden"};



        ItemFinder ItemFinder = new ItemFinder();
        Image TarjetaData;
        BitmapImage IMG_Source;

        public void CargarTarjetas(List<string> img, int total)
        {

            for (int i = 0; i < total; i++)
            {
                IMG_Source = new BitmapImage();
                IMG_Source.BeginInit();
                IMG_Source.UriSource = new Uri(img[i], UriKind.Relative);
                
                TarjetaData = new Image();
                TarjetaData.Source = IMG_Source;
                
            }
        }

        public List<string> GetTarjetaHidden(int max)
        {
            List<string> toReturn = new List<string>();
            for (int i = 0; i < max; i++)
            {
                toReturn.Add(tarjetas_hidden[i]);
            }

            return toReturn;
        }
        public List<string> GetTarjeta(int max)
        {
            List<string> toReturn = new List<string>();
            for (int i = 0; i < max; i++)
            {
                toReturn.Add(tarjetas[i]);
            }

            return toReturn;
        }

    }
}
