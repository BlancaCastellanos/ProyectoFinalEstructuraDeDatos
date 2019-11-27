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
            PeliculasySeries.Add(new PS("Pelicula6", 2014, "Terror", "Sinopsis6", "6", "Comentario6", "Director6"));

            lstPeliculasySeries.ItemsSource = PeliculasySeries;


            //HIDDEN - IMAGENES
            e1.Visibility = Visibility.Hidden;
            e2.Visibility = Visibility.Hidden;
            e3.Visibility = Visibility.Hidden;
            e4.Visibility = Visibility.Hidden;
            e5.Visibility = Visibility.Hidden;

            //HIDDEN - VISIBLE BOTONES
            btnactualizar.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;
            btncancelar.Visibility = Visibility.Hidden;
            btnguardarnuevoprim.Visibility = Visibility.Hidden;
            btnguardarnuevodos.Visibility = Visibility.Hidden;


            //HIDDEN - VISIBLE OTROS ELEMENTOS
            radiodbtnPelicula.Visibility = Visibility.Hidden;
            radiodbtnSerie.Visibility = Visibility.Hidden;
            labelTipo.Visibility = Visibility.Hidden;
            labelerror.Visibility = Visibility.Hidden;

        }




        //AGREGAR UN ELEMENTO NUEVO A NUESTRO FORMULARIO
        private void btnAgregarElemento_Click(object sender, RoutedEventArgs e)
        {
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
            btncancelar.Visibility = Visibility.Visible;
            btneliminar.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;
            btnactualizar.Visibility = Visibility.Hidden;
            
            //OTROS ELEMENTOS
            labelTipo.Visibility = Visibility.Hidden;
            radiodbtnSerie.Visibility = Visibility.Visible;
            radiodbtnPelicula.Visibility = Visibility.Visible;
            txtblockordenar.Visibility = Visibility.Hidden;
        }




                            //INTENTO PRACTICA
                            /*{
                                InitializeComponent();
                                PeliculasySeries.Add("r");
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




        //PROFE PARA ORDENAR PIQUELE VARIAS VECES, GRACIAS.
        //DE LA A-Z
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



        //DE LA Z-A
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



        //ORDENAR POR AÑO (MENOR A MAYOR)
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



        //ORDENAR POR AÑO (MAYOR A MENOR)
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

            btnAgregarElemento.Visibility = Visibility.Hidden;

            //CONDICION MAYOR
            if (lstPeliculasySeries.SelectedIndex != -1)
            {
                //GRIDS
                grdDatos.Children.Clear();
                grdDatos.Children.Add(new VerElemento());


                //BOTONES
                

                ((VerElemento)(grdDatos.Children[0])).txtbox_titulo.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Titulo;
                ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Sinopsis;
                ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Descripcion;
                ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Director;
                ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Productor;
                ((VerElemento)(grdDatos.Children[0])).combobox_genero.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Genero;
                ((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Rating;
                ((VerElemento)(grdDatos.Children[0])).txtbox_año.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Año.ToString();


                //BOTONES DE ORDENAMIENTO
                btnAño1.Visibility = Visibility.Hidden;
                btnAño2.Visibility = Visibility.Hidden;
                btnOrdAZ.Visibility = Visibility.Hidden;
                btnOrdZA.Visibility = Visibility.Hidden;

                //BOTONES
                btneditar.Visibility = Visibility.Visible;
                btncancelar.Visibility = Visibility.Hidden;
                btnactualizar.Visibility = Visibility.Hidden;
                btnguardarnuevoprim.Visibility = Visibility.Hidden;
                txtblockordenar.Visibility = Visibility.Hidden;





                //CONDICIONAL MENOR
                //CONDICIONAL DEL RATING - IMAGENES
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
        }


        //BOTONES EDICION
        //ELIMINAR
        private void btneliminar_Click(object sender, RoutedEventArgs e)
            {
                if (lstPeliculasySeries.SelectedIndex != -1)
                {
                    PeliculasySeries.RemoveAt(lstPeliculasySeries.SelectedIndex);
                }
            }

                            
                             /*
                            //INCLUIR
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
                            btnactualizar.Visibility = Visibility.Visible; */


            //RADIOBUTTON
            //PELICULA
        private void radiodbtnPelicula_Checked_1(object sender, RoutedEventArgs e)
          {   
              //GRID
              grdDatos.Children.Clear();
              grdDatos.Children.Add(new AgregarElemento());

                
              ((AgregarElemento)(grdDatos.Children[0])).combobox_temporadas.Visibility = Visibility.Hidden;
              ((AgregarElemento)(grdDatos.Children[0])).labeltemporadaa.Visibility = Visibility.Hidden;


              //BOTONES
              btnguardarnuevoprim.Visibility = Visibility.Visible;
              btnguardarnuevodos.Visibility = Visibility.Hidden;
                btneditar.Visibility = Visibility.Hidden;
        }



            //SERIE
        private void radiodbtnSerie_Checked(object sender, RoutedEventArgs e)
          {
             //GRIDS
             grdDatos.Children.Clear();
             grdDatos.Children.Add(new AgregarElemento());


             ((AgregarElemento)(grdDatos.Children[0])).combobox_temporadas.Visibility = Visibility.Visible;
             ((AgregarElemento)(grdDatos.Children[0])).labeltemporadaa.Visibility = Visibility.Visible;

             //BOTONES
             btnguardarnuevodos.Visibility = Visibility.Visible;
             btnguardarnuevoprim.Visibility = Visibility.Hidden;
                btneditar.Visibility = Visibility.Hidden;
        }



         //BOTON GUARDAR 2
         private void btnguardarnuevodos_Click(object sender, RoutedEventArgs e)
                {
                //CONDICION POR CUMPLIR
                //SI SI
                if (((AgregarElemento)(grdDatos.Children[0])).
                txtbox_titulo.Text == string.Empty || 
                ((AgregarElemento)(grdDatos.Children[0])).
                txtbox_año.Text == string.Empty || 
                ((AgregarElemento)(grdDatos.Children[0])).
                txtbox_descripcion.Text == string.Empty || 
                ((AgregarElemento)(grdDatos.Children[0])).
                txtbox_productor.Text == string.Empty || 
                ((AgregarElemento)(grdDatos.Children[0])).
                combobox_genero.Text == string.Empty || 
                ((AgregarElemento)(grdDatos.Children[0])).
                combobox_rating.Text == string.Empty)
                
                //MENSAJE DE ERROR
                {
                        labelerror.Visibility = Visibility.Visible;
                }

                //SI NO
                else
                {
                    int añonuevoraro = Convert.ToInt32(((AgregarElemento)(grdDatos.Children[0])).txtbox_año.Text);
                    PeliculasySeries.Add(new PS(((AgregarElemento)(grdDatos.Children[0])).
                    txtbox_titulo.Text, añonuevoraro, 
                    ((AgregarElemento)(grdDatos.Children[0])).
                    combobox_genero.Text, ((AgregarElemento)(grdDatos.Children[0])).
                    combobox_temporadas.Text, ((AgregarElemento)(grdDatos.Children[0])).
                    txtbox_productor.Text, ((AgregarElemento)(grdDatos.Children[0])).
                    txtbox_descripcion.Text, ((AgregarElemento)(grdDatos.Children[0])).
                    combobox_rating.Text));

                //OTROS ELEMENTOS
                    labelerror.Visibility = Visibility.Visible;
                    lstPeliculasySeries.Items.Refresh();
                }

            }


        //BOTON EDITAR
        private void btneditar_Click(object sender, RoutedEventArgs e)
        {
            //GRID
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new VerElemento());

            //AGREGAR
            ((VerElemento)(grdDatos.Children[0])).txtbox_titulo.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Titulo;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Sinopsis;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Descripcion;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Director;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Productor;
            ((VerElemento)(grdDatos.Children[0])).combobox_genero.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Genero;
            ((VerElemento)(grdDatos.Children[0])).txtbox_rating.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Rating;
            ((VerElemento)(grdDatos.Children[0])).txtbox_año.Text = PeliculasySeries[lstPeliculasySeries.SelectedIndex].Año.ToString();

            ((VerElemento)(grdDatos.Children[0])).txtbox_titulo.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_sinopsis.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_director.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).combobox_genero.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_rating.IsEnabled = true;
            ((VerElemento)(grdDatos.Children[0])).txtbox_año.IsEnabled = true;

            //BOTONES
            btnactualizar.Visibility = Visibility.Visible;
            btncancelar.Visibility = Visibility.Visible;
            btnguardarnuevoprim.Visibility = Visibility.Hidden;
            btneditar.Visibility = Visibility.Hidden;
        }



        //BOTON ACTUALIZAR
        private void btnactualizar_Click(object sender, RoutedEventArgs e)
        {
            //MIS VARIABLES (*CHECAR BIEN*)
            var inten = ((VerElemento)(grdDatos.Children[0]));
            var variable = PeliculasySeries[lstPeliculasySeries.SelectedIndex];
            var añoooo = variable.Año.ToString();
            var añofin = Convert.ToInt32(((VerElemento)(grdDatos.Children[0])).txtbox_año.Text);

            PeliculasySeries[lstPeliculasySeries.SelectedIndex].Año = añofin;

            //MAS VARIABLES
            variable.Titulo = inten.txtbox_titulo.Text;
            variable.Sinopsis = inten.txtbox_sinopsis.Text;
            variable.Rating = inten.txtbox_rating.Text;
            variable.Productor = inten.txtbox_director.Text;
            variable.Descripcion = inten.txtbox_sinopsis.Text;

            //REFRESH
            lstPeliculasySeries.Items.Refresh();


            //GRID
            grdDatos.Children.Clear();


            //IMAGENES
            e1.Visibility = Visibility.Hidden;
            e2.Visibility = Visibility.Hidden;
            e3.Visibility = Visibility.Hidden;
            e4.Visibility = Visibility.Hidden;
            e5.Visibility = Visibility.Hidden;


            //BOTONES DE ORDENAMIENTO
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
            txtblockordenar.Visibility = Visibility.Hidden;
        }


        //BOTON CANCELAR
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


            //BOTONES DE ORDENAMIENTO
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
            btnguardarnuevoprim.Visibility = Visibility.Hidden;
        }


        //SERIES
        //BOTON GUARDAR - EL PRIMERO (ACOMODAR MEJOR)
        private void btnguardarnuevoprim_Click(object sender, RoutedEventArgs e)
        {
            //CONDICIONAL
            // SI SI
            if (((AgregarElemento)(grdDatos.Children[0])).txtbox_titulo.Text == string.Empty ||
                ((AgregarElemento)(grdDatos.Children[0])).txtbox_año.Text == string.Empty ||
                ((AgregarElemento)(grdDatos.Children[0])).txtbox_descripcion.Text == string.Empty ||
                ((AgregarElemento)(grdDatos.Children[0])).txtbox_productor.Text == string.Empty ||
                ((AgregarElemento)(grdDatos.Children[0])).combobox_genero.Text == string.Empty ||
                ((AgregarElemento)(grdDatos.Children[0])).combobox_rating.Text == string.Empty)
            
            //MENSAJE DE ERROR
            {
                labelerror.Visibility = Visibility.Visible;
            }

            // SI NO
            else
            {   
                //MIS VARIABLES NUEVAS
                var añoprimero = ((AgregarElemento)(grdDatos.Children[0])).txtbox_año.Text;
                int añof = int.Parse(añoprimero);
                string temporadass = "No se aplica en este caso";

                PeliculasySeries.Add(new PS(((AgregarElemento)(grdDatos.Children[0])).
                txtbox_titulo.Text, añof, ((AgregarElemento)(grdDatos.Children[0])).
                combobox_genero.Text, temporadass, ((AgregarElemento)(grdDatos.Children[0])).
                txtbox_productor.Text, ((AgregarElemento)(grdDatos.Children[0])).
                txtbox_descripcion.Text, ((AgregarElemento)(grdDatos.Children[0])).
                combobox_rating.Text));

                //OTROS ELEMENTOS
                lstPeliculasySeries.Items.Refresh();
                labelerror.Visibility = Visibility.Hidden;
            }
        }
    }
}




