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
using System.Collections.ObjectModel;

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PS> PeliculasySeries = new ObservableCollection<PS>();

        public MainWindow()

        {
            InitializeComponent();
            PeliculasySeries.Add(new PS("Pelicula1", 1956, "Suspenso", "Sinopsis1", "1", "Comentario1", "Director1"));
            PeliculasySeries.Add(new PS("Pelicula2", 2012, "Comedia", "Sinopsis2", "2", "Comentario2", "Director2"));
            PeliculasySeries.Add(new PS("Pelicula3", 1999, "Terror", "Sinopsis3", "3", "Comentario3", "Director3"));
            PeliculasySeries.Add(new PS("Pelicula4", 1998, "Infantil", "Sinopsis4", "4", "Comentario4", "Director4"));
            PeliculasySeries.Add(new PS("Pelicula5", 2004, "Comedia", "Sinopsis5", "5", "Comentario5", "Director5"));


            lstPeliculasySeries.ItemsSource = PeliculasySeries;

            //HIDDEN
            e1.Visibility = Visibility.Hidden;
            e2.Visibility = Visibility.Hidden;
            e3.Visibility = Visibility.Hidden;
            e4.Visibility = Visibility.Hidden;
            e5.Visibility = Visibility.Hidden;
            btnactualizar.Visibility = Visibility.Hidden;

        }

        private void btnAgregarElemento_Click(object sender, RoutedEventArgs e)
        {

            //GRIDS
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new AgregarElemento());


            //BOTONES ORDENAR POR AÑO Y DE LA A -Z Y Z-A
            btnOrdAZ.Visibility = Visibility.Hidden;
            btnOrdZA.Visibility = Visibility.Hidden;
            btnAño1.Visibility = Visibility.Hidden;
            btnAño2.Visibility = Visibility.Hidden;

            //FOTOS
            e1.Visibility = Visibility.Hidden;
            e2.Visibility = Visibility.Hidden;
            e3.Visibility = Visibility.Hidden;
            e4.Visibility = Visibility.Hidden;
            e5.Visibility = Visibility.Hidden;

            //BOTONES
            btncancelar.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;
            btnactualizar.Visibility = Visibility.Hidden;

        }




        //INTENTO
        /*{
            InitializeComponent();
            PeliculasySeries.Add("rojo");
            PeliculasySeries.Add("azul");
            PeliculasySeries.Add("amarillo");
            PeliculasySeries.Add("naranja");
            PeliculasySeries.Add("verde");


            lstPeliculasySeries.ItemsSource = PeliculasySeries;

        }

        private void btnAgregarElemento_Click(object sender, RoutedEventArgs e)
        {
            /*PeliculasySeries.Add(txtColores.Text);
            txtColor.Text = "";*/





        //PROFE PARA ORDENAR PIQUELE VARIAS VECESSSS
        private void btnOrdAZ_Click(object sender, RoutedEventArgs e)
        {
            bool swap;


            do
            {
                swap = false;
                for (int index = 0; index < (PeliculasySeries.Count - 1); index++)
                {
                    if (string.Compare(PeliculasySeries[index].Titulo, PeliculasySeries[index + 1].Titulo) > 0)
                    {
                        var temp = PeliculasySeries[index];
                        PeliculasySeries[index] = PeliculasySeries[index + 1];
                        PeliculasySeries[index + 1] = temp;
                        swap = true;
                    }

                }
            } while (swap == true);
        }

        private void btnOrdZA_Click(object sender, RoutedEventArgs e)
        {
            bool swap;


            do
            {
                swap = false;
                for (int index = 0; index < (PeliculasySeries.Count - 1); index++)
                {
                    if (string.Compare(PeliculasySeries[index].Titulo, PeliculasySeries[index + 1].Titulo) < 0)
                    {
                        var temp = PeliculasySeries[index];
                        PeliculasySeries[index] = PeliculasySeries[index + 1];
                        PeliculasySeries[index + 1] = temp;
                        swap = true;
                    }

                }
            } while (swap == true);
        }

        private void btnAño1_Click(object sender, RoutedEventArgs e)
        {
            {
                int gap, i;
                gap = PeliculasySeries.Count / 2;


                while (gap > 0)
                {

                    for (i = 0; i < PeliculasySeries.Count; i++)
                    {
                        if (gap + i < PeliculasySeries.Count && PeliculasySeries[i].Año > PeliculasySeries[gap + i].Año)
                        {

                            var temp = PeliculasySeries[i];
                            PeliculasySeries[i] = PeliculasySeries[gap + i];
                            PeliculasySeries[gap + i] = temp;
                        }
                    }

                    gap--;
                }

            }
        }

        private void btnAño2_Click(object sender, RoutedEventArgs e)
        {
            {
                int gap, i;
                gap = PeliculasySeries.Count / 2;


                while (gap > 0)
                {

                    for (i = 0; i < PeliculasySeries.Count; i++)
                    {
                        if (gap + i < PeliculasySeries.Count && PeliculasySeries[i].Año < PeliculasySeries[gap + i].Año)
                        {

                            var temp = PeliculasySeries[i];
                            PeliculasySeries[i] = PeliculasySeries[gap + i];
                            PeliculasySeries[gap + i] = temp;
                        }
                    }

                    gap--;
                }

            }
        }


        private void lstPeliculasySeries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new VerElemento());
    
            //BOTONES
            btneliminar.Visibility = Visibility.Visible;
            btneditar.Visibility = Visibility.Visible;

            ((VerElemento)(grdDatos.Children[0])).txtbox_titulo.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Titulo;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Sinopsis;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Descripcion;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Director;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Productor;
            ((VerElemento)(grdDatos.Children[0])).txtbox_genero.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Genero;
            ((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Rating;
            ((VerElemento)(grdDatos.Children[0])).txtbox_año.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Año.ToString();


            //BOTONES HIDDEN
            btnAño1.Visibility = Visibility.Hidden;
            btnAño2.Visibility = Visibility.Hidden;
            btnOrdAZ.Visibility = Visibility.Hidden;
            btnOrdZA.Visibility = Visibility.Hidden;

            btncancelar.Visibility = Visibility.Visible;
            btnactualizar.Visibility = Visibility.Visible;




            //CONDICIONAL DEL RATING
            if (((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text == "1")
            {
                e1.Visibility = Visibility.Visible;
                e2.Visibility = Visibility.Hidden;
                e3.Visibility = Visibility.Hidden;
                e4.Visibility = Visibility.Hidden;
                e5.Visibility = Visibility.Hidden;
            }
            if (((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text == "2")
            {
                e2.Visibility = Visibility.Visible;
                e1.Visibility = Visibility.Hidden;
                e3.Visibility = Visibility.Hidden;
                e4.Visibility = Visibility.Hidden;
                e5.Visibility = Visibility.Hidden;
            }
            if (((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text == "3")
            {
                e3.Visibility = Visibility.Visible;
                e2.Visibility = Visibility.Hidden;
                e1.Visibility = Visibility.Hidden;
                e4.Visibility = Visibility.Hidden;
                e5.Visibility = Visibility.Hidden;
            }
            if (((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text == "4")
            {
                e4.Visibility = Visibility.Visible;
                e2.Visibility = Visibility.Hidden;
                e3.Visibility = Visibility.Hidden;
                e1.Visibility = Visibility.Hidden;
                e5.Visibility = Visibility.Hidden;
            }
            if (((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text == "5")
            {
                e5.Visibility = Visibility.Visible;
                e2.Visibility = Visibility.Hidden;
                e3.Visibility = Visibility.Hidden;
                e4.Visibility = Visibility.Hidden;
                e1.Visibility = Visibility.Hidden;
            }
        }







    //BOTONES
    private void btneliminar_Click(object sender, RoutedEventArgs e)
        {
        if (lstPeliculasySeries.SelectedIndex != -1)
            {
              PeliculasySeries.RemoveAt(lstPeliculasySeries.SelectedIndex);
            }
            
            //GRID
            grdDatos.Children.Clear();


            //IMAGENES DE ESTRELLAS
            e1.Visibility = Visibility.Hidden;
            e2.Visibility = Visibility.Hidden;
            e3.Visibility = Visibility.Hidden;
            e4.Visibility = Visibility.Hidden;
            e5.Visibility = Visibility.Hidden;


            ////BOTONES ORDENAR POR AÑO Y DE LA A -Z Y Z-A
            btnOrdAZ.Visibility = Visibility.Visible;
            btnOrdZA.Visibility = Visibility.Visible;
            btnAño1.Visibility = Visibility.Visible;
            btnAño2.Visibility = Visibility.Visible;


            //OTROS BOTONES
            btncancelar.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;
            btnactualizar.Visibility = Visibility.Visible;
        }




        private void btneditar_Click(object sender, RoutedEventArgs e)
        {

            //VerElemento
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new VerElemento());
            ((VerElemento)(grdDatos.Children[0])).txtbox_titulo.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Titulo;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Sinopsis;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Descripcion;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Director;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Productor;
            ((VerElemento)(grdDatos.Children[0])).txtbox_genero.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Genero;
            ((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Rating;
            ((VerElemento)(grdDatos.Children[0])).txtbox_año.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Año.ToString();

            ((VerElemento)(grdDatos.Children[0])).txtbox_titulo.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_genero.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_rating.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_año.IsEnabled = true;

            btnactualizar.Visibility = Visibility.Visible;
            ((VerElemento)(grdDatos.Children[0])).txtbox_rating.Visibility = Visibility.Hidden;
        }



        private void btnactualizar_Click(object sender, RoutedEventArgs e)
        {
            var usuario = ((VerElemento)(grdDatos.Children[0]));
            var clase = PeliculasySeries[lstPeliculasySeries.SelectedIndex];
            var año = clase.Año.ToString();
            var año2 = Convert.ToInt32(((VerElemento)(grdDatos.Children[0])).txtbox_año.Text);
            PeliculasySeries[lstPeliculasySeries.SelectedIndex].Año = año2;
            clase.Titulo = usuario.txtbox_titulo.Text;
            clase.Sinopsis = usuario.txtbox_sinopsis.Text;
            clase.Rating = usuario.txtbox_rating.Text;
            clase.Productor = usuario.txtbox_director.Text;
            clase.Descripcion = usuario.txtbox_sinopsis.Text;

            lstPeliculasySeries.Items.Refresh();

            //GRID
            grdDatos.Children.Clear();
            
            
            //IMAGENES
            e1.Visibility = Visibility.Hidden;
            e2.Visibility = Visibility.Hidden;
            e3.Visibility = Visibility.Hidden;
            e4.Visibility = Visibility.Hidden;
            e5.Visibility = Visibility.Hidden;
            
            
            //BOTONES 
            btnOrdAZ.Visibility = Visibility.Visible;
            btnOrdZA.Visibility = Visibility.Visible;
            btnAño1.Visibility = Visibility.Visible;
            btnAño2.Visibility = Visibility.Visible;
            

            //BOTONES EXTRA
            btncancelar.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;
            btnactualizar.Visibility = Visibility.Visible;
            btnAgregarElemento.Visibility = Visibility.Visible;
        }



        private void guardar_Click(object sender, RoutedEventArgs e)
            {

                var usuario = ((AgregarSeries)(grdDatos.Children[0]));
                var clase = PeliculasySeries[lstPeliculasySeries.SelectedIndex];

                clase.Titulo = usuario.txtbox_titulo.Text;
                clase.Sinopsis = usuario.txtbox_descripcion.Text;
                clase.Rating = usuario.txtbox_rating.Text;
                clase.Productor = usuario.txtbox_productor.Text;
                clase.Descripcion = usuario.txtbox_descripcion.Text;


            lstPeliculasySeries.Items.Refresh();
            }



        private void btncancelar_Click(object sender, RoutedEventArgs e)
        {
            //GRID
            grdDatos.Children.Clear();


            //IMAGENES
            e1.Visibility = Visibility.Hidden;
            e2.Visibility = Visibility.Hidden;
            e3.Visibility = Visibility.Hidden;
            e4.Visibility = Visibility.Hidden;
            e5.Visibility = Visibility.Hidden;


            //BOTONES
            btnAño1.Visibility = Visibility.Visible;
            btnAño2.Visibility = Visibility.Visible;
            btnOrdAZ.Visibility = Visibility.Visible;
            btnOrdZA.Visibility = Visibility.Visible;


            //BOTONES EXTRA
            btnAgregarElemento.Visibility = Visibility.Visible;
            btncancelar.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;
            btnactualizar.Visibility = Visibility.Visible;
            // guardar.Visibility = Visibility.Hidden;

        }
    }
}

