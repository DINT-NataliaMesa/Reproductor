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

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Trailer1RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.Source = new Uri(@"F:\2019-2020\DIN\Proyectos\Tema 2\trailer1.mp4");

        }

        private void Trailer2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.Source = new Uri(@"F:\2019-2020\DIN\Proyectos\Tema 2\trailer2.mp4");
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.Stop();
        }

        private void SilencioCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.IsMuted = true;
        }

        private void SilencioCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.IsMuted = false;
        }

        
    }
}
