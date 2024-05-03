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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();

            try
            {
                usuario = new Usuario(txbUsuario.Text, txbPass.Text, false);

                if (Validacion.ValidarTextoVacio(txbUsuario) || Validacion.ValidarTextoVacio(txbPass))
                {
                    Session.Add("Error", "Error debes completar Los Campos");
                    Response.Redirect("Error.aspx");
                }

                if (negocio.Loguear(usuario))
                {
                    Session.Add("Usuario", usuario);
                    Response.Redirect("Inicio.aspx", false);
                }
                else
                {
                    Session.Add("Error", "Datos Incorrectos");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (System.Threading.ThreadAbortException ex) { }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }



        }
    }
}