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
using ItemFinder = Memorama.ItemFinder;

namespace Memorama
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        ItemFinder _ItemFinder = new ItemFinder();

        public Menu()
        {
            InitializeComponent();
        }

        private void Action_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Action_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            Frame Displayer = _ItemFinder.FindChild<Frame>(Application.Current.MainWindow, "frameDisplayer");
            Displayer.Source = new Uri("/Paneles/Seleccion.xaml", UriKind.Relative);
        }
    }
}
