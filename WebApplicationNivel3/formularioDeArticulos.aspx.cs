using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebApplicationNivel3
{
    public partial class formularioDeArticulos : System.Web.UI.Page
    {

        public bool confirmaEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null && ((Dominio.Usuario)Session["usuario"]).TipoUsuario == Dominio.TipoUsuario.admin)
            {
                txbId.Enabled = false;
                confirmaEliminacion = false;
                btnEliminar.Visible = false;
                try
                {
                    if (!IsPostBack)
                    {

                        MarcaNegocio marcanegocio = new MarcaNegocio();
                        CategoriaNegocio categorianegocio = new CategoriaNegocio();
                        List<Talle> Listadetalles = new List<Talle>();
                        List<Cat> ListaDeCategorias = new List<Cat>();
                        Listadetalles = marcanegocio.ListadodeTalles();
                        ListaDeCategorias = categorianegocio.ListadodeCategorias();
                        ddlTalle.DataSource = Listadetalles;
                        ddlTalle.DataValueField = "id";
                        ddlTalle.DataTextField = "Descripcion";
                        ddlTalle.DataBind();
                        ddlcategoria.DataSource = categorianegocio.ListadodeCategorias();
                        ddlcategoria.DataValueField = "id";
                        ddlcategoria.DataTextField = "Descripcion";
                        ddlcategoria.DataBind();

                    }

                    string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                    if (id != "" && !IsPostBack)
                    {
                        btnEliminar.Visible = true;
                        btnAgregar.Text = "Modificar";
                        ArticuloNegocio negocio = new ArticuloNegocio();
                        List<Articulo> Lista = negocio.Listar(id);
                        Articulo seleccionado = Lista[0];

                        txbId.Text = id;
                        txbCodigoDeArticulo.Text = seleccionado.CodArt;
                        txbPrecio.Text = seleccionado.Precio.ToString();
                        txbdescripcion.Text = seleccionado.Descripcion;
                        txbNombre.Text = seleccionado.Nombre;
                        txbUrlImagen.Text = seleccionado.Imagen;

                        ddlTalle.SelectedValue = seleccionado.Marca.Id.ToString();
                        ddlcategoria.SelectedValue = seleccionado.Categoria.Id.ToString();
                        txbUrlImagen_TextChanged(sender, e);

                    }
                    else
                    {
                        btnActivar.Visible = false;
                        btneliminarLogico.Visible = false;

                    }

                }
                catch (Exception ex)
                {

                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");
                }


            }
            else
            {
                Session.Add("Error", "No Tienes Permiso De Administrador");
                Response.Redirect("Error.aspx");
            }
        }
        protected void Agregar_Click(object sender, EventArgs e)
        {
            try
            {


                Articulo nuevo = new Articulo();

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                nuevo.CodArt = txbCodigoDeArticulo.Text;

                if (!string.IsNullOrEmpty(txbNombre.Text))
                {
                    nuevo.Nombre = txbNombre.Text;
                }
                else
                {
                    string script = "alert('Debe completar El Nombre.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                    return;
                }
                nuevo.Descripcion = txbdescripcion.Text;
                nuevo.Imagen = txbUrlImagen.Text;

                if (!string.IsNullOrEmpty(txbPrecio.Text))
                {
                    nuevo.Precio = decimal.Parse(txbPrecio.Text);
                }
                else
                {
                    string script = "alert('Debe completar El Precio.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                    return;
                }

                nuevo.Categoria = new Cat();
                nuevo.Categoria.Id = int.Parse(ddlcategoria.SelectedValue);
                nuevo.Marca = new Talle();
                nuevo.Marca.Id = int.Parse(ddlTalle.SelectedValue);

                if (Request.QueryString["id"] != null)
                {
                    nuevo.id = int.Parse(txbId.Text);
                    articuloNegocio.ModificarconSp(nuevo);
                    Response.Redirect("Filtro.aspx", false);
                }
                else
                    articuloNegocio.agregar(nuevo);
                Response.Redirect("Filtro.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }

        }

        protected void txbUrlImagen_TextChanged(object sender, EventArgs e)
        {
            imgArticulo.ImageUrl = txbUrlImagen.Text;
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmaEliminacion = true;
        }

        protected void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            if (ckbConfirmarEliminacio.Checked)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.Eliminar(int.Parse(txbId.Text));
                Response.Redirect("Filtro.aspx", false);
            }
        }



        protected void btneliminarLogico_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.eliminarLogico(int.Parse(txbId.Text));
                Response.Redirect("Filtro.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnActivar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.activarLogico(int.Parse(txbId.Text));
            Response.Redirect("Filtro.aspx", false);
        }
    }
}