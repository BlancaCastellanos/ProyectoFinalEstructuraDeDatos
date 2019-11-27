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

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para VerElemento.xaml
    /// </summary>
    public partial class VerElemento : UserControl
    {
        public VerElemento()
        {
            InitializeComponent();
            txtbox_año.IsEnabled = false;
            txtbox_genero.IsEnabled = false;
            txtbox_director.IsEnabled = false;
            txtbox_rating.IsEnabled = false;
            txtbox_sinopsis.IsEnabled = false;
            txtbox_titulo.IsEnabled = false;
        }

    }
}
