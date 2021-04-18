using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Memorama
{
    /// <summary>
    /// Lógica de interacción para Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {

        DispatcherTimer TimerThread = new DispatcherTimer();

        public Splash()
        {

            InitializeComponent();

            TimerThread.Interval = new TimeSpan(50000);
            TimerThread.Tick += Timer_Tick;
            TimerThread.IsEnabled = true;
            TimerThread.Start();
            


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Loader.Width += 6;

            if (Loader.Width == Bar.Width)
            {
                TimerThread.Stop();
                Thread.CurrentThread.Abort();
            }
        }
    }
}
