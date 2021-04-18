using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Memorama.Services
{
    class InitTarjetas
    {

        List<int> IMG_Usados = new List<int>();
        List<int> TarjetaIDUsados = new List<int>();
        RandomNumber RandomNumber = new RandomNumber();
        Tarjeta ITarjeta = new Tarjeta();
        ItemFinder IFinder = new ItemFinder();
        Imagenes _Imagenes = new Imagenes();
        private int TotalImg = 0;

        public void InitTarjetasImg(string nivel, int stage)
        {
            TotalImg = _Imagenes.TotalImagenes();

            List<string> _Tarjetas = new List<string>();

            if (nivel == "Facil")
            {
                if (stage == 1){
                    int max = 8;
                    _Tarjetas = ITarjeta.GetTarjetasHidden(max);

                    for (int i = 0; i < max; i++)
                    {
                        int img_id = RandomNumber.getNumber(0, TotalImg);
                        if (!IMG_Usados.Contains(img_id))
                        {
                            Uri img_source = _Imagenes.ObtenerImagen(img_id);
                            int temp_tarjeta_1 = RandomNumber.getNumber(0,max);
                            int temp_tarjeta_2 = RandomNumber.getNumber(0, max);
                            TarjetaIDUsados.Add(temp_tarjeta_1);
                            TarjetaIDUsados.Add(temp_tarjeta_2);

                            if (temp_tarjeta_1 == temp_tarjeta_2)
                            {
                                i--;
                            }
                            else
                            {
                                Image _Tarjeta_1 = IFinder.FindChild<Image>(Application.Current.MainWindow, _Tarjetas[temp_tarjeta_1]);
                                Image _Tarjeta_2 = IFinder.FindChild<Image>(Application.Current.MainWindow, _Tarjetas[temp_tarjeta_2]);
                                /*_Tarjeta_1.Source = img_source;
                                _Tarjeta_2.Source = img_source;
                                */
                            }
                        }


                        
                    }
                }
                    
            }
            else if (nivel == "Medio")
            {


            }
            else if (nivel == "Dificil")
            {

            }

            
        }
    }
}
