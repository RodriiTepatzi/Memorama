using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorama
{
    class Imagenes
    {

        private static List<string> IMG_NOMBRES = new List<string>
           {"../img/img1.jpg", 
            "../img/img2.jpg",
            "../img/img3.jpg", 
            "../img/img4.jpg",
            "../img/img5.jpg",
            "../img/img6.jpg",
            "../img/img7.jpg",
            "../img/img8.jpg",
            "../img/img9.jpg",
            "../img/img10.jpg",
            "../img/img11.jpg",
            "../img/img12.jpg",
            "../img/img13.jpg",
            "../img/img14.jpg",
            "../img/img15.jpg",
            "../img/img16.jpg",
            "../img/img17.jpg",
            "../img/img18.jpg",
            "../img/img19.jpg",
            "../img/img20.jpg",
            "../img/img21.jpg",
            "../img/img22.jpg",
            "../img/img23.jpg",
            "../img/img24.jpg",
            "../img/img25.jpg",
            "../img/img26.jpg",
            "../img/img27.jpg",
            "../img/img28.jpg",
            "../img/img29.jpg",
            "../img/img30.jpg",
            "../img/img31.jpg",
            "../img/img32.jpg",
            "../img/img33.jpg"};


        public Uri ObtenerImagen(int i)
        {
            return new Uri(IMG_NOMBRES[i], UriKind.Relative);
        }

        public int TotalImagenes()
        {
            return IMG_NOMBRES.Count();
        }
    }
}
