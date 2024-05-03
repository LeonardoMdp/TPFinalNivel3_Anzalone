using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace WebApplicationNivel3
{
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : ""; 

            Articulo seleccionado = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista = negocio.Listar(id);
            seleccionado = lista[0];

            imgDetalle.ImageUrl = seleccionado.Imagen;
            labelDetalle.Text = seleccionado.Descripcion;
        }
    }
}