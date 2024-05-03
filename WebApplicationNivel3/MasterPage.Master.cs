using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace WebApplicationNivel3
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Usuario"] != null)
            {
                Usuario usuario = (Usuario)Session["Usuario"];
                ImagenAvatar.ImageUrl = "~/Imagenes/" + usuario.ImagendePerfil;
                
            }
            else
            {
                ImagenAvatar.ImageUrl = "https://coe.arizona.edu/sites/default/files/styles/uaqs_card_image/public/people%20placeholder.png?itok=HJGYlLdF";
            }
        }   

        protected void btnregistrarce_Click(object sender, EventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Inicio.aspx");
        }
    }
}