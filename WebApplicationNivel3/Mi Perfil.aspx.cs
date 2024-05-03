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
    public partial class Mi_Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(! IsPostBack)
            {
                if (Session["Usuario"] != null)
                {
                    Usuario usuario = (Usuario)Session["Usuario"];

                    txbEmail.ReadOnly = true;
                    txbNombre.Text = usuario.User;
                    txbEmail.Text = usuario.Email;
                    txbApellido.Text = usuario.Apellido;
                    txbFechaNacimiento.Text = usuario.FechaDeNacimiento.ToString("yyyy-MM-dd");
                    imagenPerfil.ImageUrl = "~/Imagenes/" + usuario.ImagendePerfil;
                }
            }

            

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Page.Validate();
                if (!Page.IsValid)
                    return;

                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario usuario = (Usuario)Session["Usuario"];

                if (txtImagen.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Imagenes/");
                    txtImagen.PostedFile.SaveAs(ruta + "perfil-" + usuario.Id + ".jpg");
                    usuario.ImagendePerfil = "perfil-" + usuario.Id + ".jpg";
                }

                usuario.User = txbNombre.Text;
                usuario.Apellido = txbApellido.Text;
                usuario.FechaDeNacimiento = DateTime.Parse(txbFechaNacimiento.Text);

                negocio.Actualizar(usuario);

                Image imagenPerfil = (Image)Master.FindControl("ImagenAvatar");
                imagenPerfil.ImageUrl = "~/Imagenes/" + usuario.ImagendePerfil;


            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}