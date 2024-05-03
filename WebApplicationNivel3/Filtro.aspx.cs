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
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> ListaDeArticulos { get; set; }
        public bool filtroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null && ((Dominio.Usuario)Session["usuario"]).TipoUsuario == Dominio.TipoUsuario.admin)
            {
                filtroAvanzado = ckbfiltravanzado.Checked;
                ArticuloNegocio negocio = new ArticuloNegocio();
                Session.Add("ListaSession", negocio.ListarConSP());
                dgwArticulos.DataSource = Session["ListaSession"];
                dgwArticulos.DataBind();

            }
            else
            {
                Session.Add("Error", "No Tienes Permiso De Administrador");
                Response.Redirect("Error.aspx");
            }
        }

        protected void dgwArticulos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgwArticulos.PageIndex = e.NewPageIndex;
            dgwArticulos.DataBind();
        }

        protected void dgwArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgwArticulos.SelectedDataKey.Value.ToString();
            Response.Redirect("formularioDeArticulos.aspx?id=" + id);
        }

        protected void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = (List<Articulo>)Session["ListaSession"];
            List<Articulo> listafiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txbBuscar.Text.ToUpper()));

            dgwArticulos.DataSource = listafiltrada;
            dgwArticulos.DataBind();
        }

        protected void ckbfiltravanzadoo_CheckedChanged(object sender, EventArgs e)
        {
            filtroAvanzado = ckbfiltravanzado.Checked;            
            txbBuscar.Enabled = !filtroAvanzado;
        }

        protected void ddlCampoavanzado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterioAvanzado.Items.Clear();


            if (ddlCampoavanzado.SelectedItem != null && (ddlCampoavanzado.SelectedItem.ToString() == "Codigo De Articulo"))
            {
                ddlCriterioAvanzado.Items.Add("Igual a...");
            }
            else if (ddlCampoavanzado.SelectedItem != null && ddlCampoavanzado.SelectedItem.ToString() == "Nombre")
            {
                ddlCriterioAvanzado.Items.Add("Empieza con...");
                ddlCriterioAvanzado.Items.Add("Termina con...");
                ddlCriterioAvanzado.Items.Add("Contiene...");
            }
            else
            {
                ddlCriterioAvanzado.Items.Add("Igual a...");
                ddlCriterioAvanzado.Items.Add("Menor a...");
                ddlCriterioAvanzado.Items.Add("Mayor a...");
            }
        }


        protected void btnBuscaravanzado_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();

                if (ddlCampoavanzado.SelectedItem != null && ddlCriterioAvanzado.SelectedItem != null && ddlEstadoAvanzado.SelectedItem != null)
                {
                    dgwArticulos.DataSource = negocio.Filtrar(ddlCampoavanzado.SelectedItem.ToString(), ddlCriterioAvanzado.SelectedItem.ToString(), txbfiltroAvanzado.Text, ddlEstadoAvanzado.SelectedItem.ToString());
                    dgwArticulos.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
                throw;
            }
        }
    }
}