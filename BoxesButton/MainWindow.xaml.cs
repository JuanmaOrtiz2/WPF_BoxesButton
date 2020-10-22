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

namespace BoxesButton
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

        //Boton que saca del ComboBox el valor seleccionado
        private void BtnUsar_Click(object sender, RoutedEventArgs e)
        {
            if(R.IsSelected)
            {
                Rojo.Visibility = Visibility.Visible;
            }
            if (Az.IsSelected)
            {
                Azul.Visibility = Visibility.Visible;
            }
            if (Am.IsSelected)
            {
                Amarillo.Visibility = Visibility.Visible;
            }
        }

        // Botón que elimina del checkbox el valor o valores seleccionados
        private void BtnNoUsar_Click(object sender, RoutedEventArgs e)
        {
            if(Rojo.IsChecked == true)
            {
                Rojo.Visibility = Visibility.Hidden;
                crojo.Visibility = Visibility.Hidden;
                Rojo.IsChecked = false;
            }
            if (Azul.IsChecked == true)
            {
                Azul.Visibility = Visibility.Hidden;
                cazul.Visibility = Visibility.Hidden;
                Azul.IsChecked = false;
            }
            if (Amarillo.IsChecked == true)
            {
                Amarillo.Visibility = Visibility.Hidden;
                camarillo.Visibility = Visibility.Hidden;
                Amarillo.IsChecked = false;
            }
        }


        //Cuando alguno de los tres colores es marcado en el checkbox, se utiliza su color.
        private void Rojo_Click(object sender, RoutedEventArgs e)
        {
            if (Rojo.IsChecked == true) crojo.Visibility = Visibility.Visible;
            else crojo.Visibility = Visibility.Hidden;
        }

        private void Azul_Click(object sender, RoutedEventArgs e)
        {
            if (Azul.IsChecked == true) cazul.Visibility = Visibility.Visible;
            else cazul.Visibility = Visibility.Hidden;
        }

        private void Amarillo_Click(object sender, RoutedEventArgs e)
        {
            if (Amarillo.IsChecked == true) camarillo.Visibility = Visibility.Visible;
            else camarillo.Visibility = Visibility.Hidden;
        }

        //Evento que se desencadena al elegir una de las opciones y pulsar el botón
        private void BtnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if (f.IsChecked == true) ifo.Visibility = Visibility.Visible;
            else ifo.Visibility = Visibility.Hidden;
            if (m.IsChecked == true) ima.Visibility = Visibility.Visible;
            else ima.Visibility = Visibility.Hidden;
            if (c.IsChecked == true) ica.Visibility = Visibility.Visible;
            else ica.Visibility = Visibility.Hidden;
        }
    }
}
