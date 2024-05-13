using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Negocio;
using Dominio;

namespace WebApplicationNivel3
{
    public partial class MisFavoritos : System.Web.UI.Page
    {


        List<Articulo> listaDeFavoritos = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FavoritosNegocio negocio = new FavoritosNegocio();
                listaDeFavoritos = negocio.ListarFavoritos(((Usuario)Session["Usuario"]).Id);
                RepetidorFavoritos.DataSource = listaDeFavoritos;
                RepetidorFavoritos.DataBind();
            }
        }

        public void RepetidorFavoritos_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EliminarFavorito")
                {

                    int idFavorito = Convert.ToInt32(e.CommandArgument);
                    FavoritosNegocio negocio = new FavoritosNegocio();
                    int IdUsuario = ((Usuario)Session["Usuario"]).Id;
                    negocio.eliminarfavorito(idFavorito, IdUsuario);
                    Response.Redirect("MisFavoritos.aspx", false);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




    }
}