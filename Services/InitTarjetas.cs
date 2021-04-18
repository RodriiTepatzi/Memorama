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

        List <int> Usados = new List<int>;
        RandomNumber RandomNumber = new RandomNumber();
        Tarjeta ITarjeta = new Tarjeta();
        ItemFinder IFinder = new ItemFinder();
        

        public void InitTarjetasImg(string nivel, int stage)
        {
            List<string> _Tarjetas = new List<string>();

            if (nivel == "Facil")
            {
                if (stage == 1){
                    int max = 8;
                    _Tarjetas = ITarjeta.GetTarjetas(max);

                    for (int i = 0; i < max; i++)
                    {
                        Usados.Add(RandomNumber.getNumber(0, max));
                        
                        Image _Tarjeta = IFinder.FindChild<Image>(Application.Current.MainWindow, _Tarjetas[i]);
                        _Tarjeta.Source = ;
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
