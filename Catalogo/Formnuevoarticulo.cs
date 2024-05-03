using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;


namespace Catalogo
{
    
    public partial class Formnuevoarticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog Archivo = null;
        public Formnuevoarticulo()
        {
            InitializeComponent();
        }

        public Formnuevoarticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {

                if (string.IsNullOrWhiteSpace(txbCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txbNombre.Text) ||
                    string.IsNullOrWhiteSpace(txbPrecio.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios *.");
                    return; 
                }

              
                decimal precio;
                if (!decimal.TryParse(txbPrecio.Text, out precio))
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                    return; 
                }

                if (articulo == null)
                    articulo = new Articulo();


                articulo.CodArt = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;

                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.Marca = (Talle)cmbMarca.SelectedItem;
                articulo.Categoria = (Cat)cmbCategoria.SelectedItem;
                articulo.Imagen = txbUrlimagen.Text;





                if (articulo.id != 0)
                {

                    negocio.Modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else 
                {

                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }

                if (Archivo != null && !txbUrlimagen.Text.ToUpper().Contains("HTTP:"))
                {
                    
                    {
                        string destinationPath = Path.Combine(ConfigurationManager.AppSettings["Image-Folder"], Archivo.SafeFileName);

                        
                        if (!File.Exists(destinationPath))
                        {
                            File.Copy(Archivo.FileName, destinationPath);
                        }
                        else
                        {
                            MessageBox.Show("La imagen ya existe en el destino.");
                            
                            return; 
                        }
                    }


                }
               
                    Close();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }

           

        }

       

        private void Formnuevoarticulo_Load(object sender, EventArgs e)
        {
                 MarcaNegocio marcanegocio = new MarcaNegocio();
                 CategoriaNegocio catenegocio = new CategoriaNegocio();

            try
            {

                cmbMarca.DataSource = marcanegocio.ListadodeMarcas();
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "Descripcion";
                cmbCategoria.DataSource = catenegocio.ListadodeCategiras();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txbNombre.Text = articulo.Nombre;
                    txbCodigo.Text = articulo.CodArt.ToString();
                    txbDescripcion.Text = articulo.Descripcion;
                    txbPrecio.Text = articulo.Precio.ToString();
                    txbUrlimagen.Text = articulo.Imagen;
                    cargarimagen(articulo.Imagen);
                    cmbMarca.SelectedValue = articulo.Marca.Id;
                    cmbCategoria.SelectedValue = articulo.Categoria.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txbUrlimagen_Leave(object sender, EventArgs e)
        {
            cargarimagen(txbUrlimagen.Text);
        }

        private void cargarimagen(string imagen)
        {

            try
            {
                pcbarticulo.Load(imagen);
            }
            catch (Exception)
            {

                pcbarticulo.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            Archivo = new OpenFileDialog();
            Archivo.Filter = "jpg|*.jpg; |png|*.png";

            if (Archivo.ShowDialog() == DialogResult.OK)
            {
                txbUrlimagen.Text = Archivo.FileName;
                cargarimagen(Archivo.FileName);

               
            }
        }
    }
}
