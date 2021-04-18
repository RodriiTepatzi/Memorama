using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memorama
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Seleccion : Page
    {
        ItemFinder _ItemFinder = new ItemFinder();

        Frame Displayer;

        public Seleccion()
        {
            InitializeComponent();
            Displayer = _ItemFinder.FindChild<Frame>(Application.Current.MainWindow, "frameDisplayer");
        }

        private void Regresar_Sel_Btn_Click(object sender, RoutedEventArgs e)
        {
            Displayer.Source = new Uri("/Memorama;component/Paneles/Menu.xaml", UriKind.Relative);
        }

        private void Facil_Sel_Btn_Click(object sender, RoutedEventArgs e)
        {
            Displayer.Source = new Uri("/Memorama;component/Tableros/Facil_1.xaml", UriKind.Relative);
        }
    }
}
