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
    /// Lógica de interacción para EditarElemento.xaml
    /// </summary>
    public partial class EditarElemento : UserControl
    {
        public EditarElemento()
        {
            InitializeComponent();

            txtbox_tituloeditar.IsEnabled = false;
            txtbox_directoreditar.IsEnabled = false;
            txtbox_tituloeditar.IsEnabled = false;
            combobox_generoeditar.IsEnabled = false;
            txtbox_sinopsiseditar.IsEnabled = false;
            txtbox_añoeditar.IsEnabled = false;
            combobox_ratingeditar.IsEnabled = false;
            combobox_generoeditar.IsEnabled = false;
            combobox_ratingeditar.IsEnabled = false;
        }
    }
}
