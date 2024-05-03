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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btnRegistrarce_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate();
                if (!Page.IsValid || string.IsNullOrEmpty(txbcontraseña.Text) || string.IsNullOrEmpty(txbEmail.Text))
                {
                    string script = "alert('Debe completar todos los campos.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                    return;
                }
               

                Usuario user = new Usuario();
                UsuarioNegocio usuarionegocio = new UsuarioNegocio();
                EmailService emailService = new EmailService();



                user.Email = txbEmail.Text;
                user.Pass = txbcontraseña.Text;

                user.Id = usuarionegocio.insertarNuevo(user);


                Session.Add("Usuario", user);
                emailService.armarCorreo(user.Email, "Bienvenido A Curlyrocker", "Gracias Por Registrarte");
                emailService.enviarEmail();
                Response.Redirect("Inicio.aspx",false);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}