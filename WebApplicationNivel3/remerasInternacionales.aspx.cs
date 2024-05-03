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
    public partial class CatalogoDeProductos : System.Web.UI.Page
    {
        public List<Articulo> ListaDeArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Session["Usuario"] !=null)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                ListaDeArticulos = negocio.ListarConSP();

                if (!IsPostBack)
                {
                    Repetidor.DataSource = ListaDeArticulos;
                    Repetidor.DataBind();
                }
            }
            else
            {
                Session.Add("Error", "Debes Logearte Para acceder a Esta Categoria");
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}