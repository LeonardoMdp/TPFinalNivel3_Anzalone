using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Dominio;
using Negocio;



namespace Catalogo
{
    partial class FormArticulos : Form
    {
        private List<Articulo> ListaArticulos;
        public FormArticulos()
        {
            InitializeComponent();
        }



        private void FormArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cbxCampo.Items.Add("Codigo De Articulo");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoria");


        }

        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                ListaArticulos = negocio.Listar();
                dgvArticulos.DataSource = ListaArticulos;
                ocultarColumnas();
                cargarimagen(ListaArticulos[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["imagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
           if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarimagen(seleccionado.Imagen);
            }
        }

        private void cargarimagen(string imagen)
        {

            try
            {
                pcbAticulos.Load(imagen);
            }
            catch (Exception)
            {

                pcbAticulos.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Formnuevoarticulo nuevo = new Formnuevoarticulo();
            nuevo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo Seleccionado;
            Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            Formnuevoarticulo Modificar = new Formnuevoarticulo(Seleccionado);
            Modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo Seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que decea Eliminar Este Articulo ?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(Seleccionado.id);
                    cargar();

                }

            }
            catch (Exception)
            {

                throw;
            }



        }

        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Complete El Campo");
                    return true;
            }            
           
            if (cbxCriterio.SelectedIndex <0)
            {
                MessageBox.Show("Complete El Criterio");
                return true;
            }

           

            return false;
        }

      

        private void btnBuscar_Click(object sender, EventArgs e)

        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string Filtro = txbFiltro.Text;
                dgvArticulos.DataSource = negocio.Filtrar(campo, criterio, Filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> ListaFiltrada;
            string Filtro = txbBuscar.Text;



            if (Filtro != "")
            {
                ListaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToLower().Contains(Filtro.ToLower()) || x.CodArt.ToLower().Contains(Filtro.ToLower()) || x.Categoria.Descripcion.ToLower().Contains(Filtro.ToLower()) || x.Marca.Descripcion.ToLower().Contains(Filtro.ToLower()));

            }
            else
            {
                ListaFiltrada = ListaArticulos;
            }



            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = ListaFiltrada;
            ocultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();

            if ( opcion == "Codigo De Articulo")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Igual a: ");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza Con: ");
                cbxCriterio.Items.Add("Termina Con: ");
                cbxCriterio.Items.Add("Contiene: ");
            }
        }

        
    }   
    }
        
    

  