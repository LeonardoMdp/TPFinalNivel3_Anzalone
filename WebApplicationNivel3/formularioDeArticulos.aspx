<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="formularioDeArticulos.aspx.cs" Inherits="WebApplicationNivel3.formularioDeArticulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-6">
                <asp:Label Text="ID" ID="lblId" CssClass="form-label" runat="server" />
                <asp:TextBox runat="server" ID="txbId" CssClass="form-control" />
                <asp:Label Text="Codigo De Articulo" ID="lblCodArt" CssClass="form-label" runat="server" />
                <asp:TextBox runat="server" ID="txbCodigoDeArticulo" CssClass="form-control" />
                <asp:Label Text="Nombre" ID="lblNombre"  runat="server" CssClass="form-label" />
                <asp:TextBox ID="txbNombre" runat="server"  CssClass="form-control"></asp:TextBox>
                <asp:Label Text="Talle" ID="lblTalle" CssClass="form-label" runat="server" />
                <asp:DropDownList ID="ddlTalle" CssClass="form-select" runat="server"></asp:DropDownList>
                <asp:Label Text="Categoria" ID="lblCategoria" CssClass="form-label" runat="server" />
                <asp:DropDownList ID="ddlcategoria" CssClass="form-select" runat="server"></asp:DropDownList>
                <asp:Button Text="Agregar" ID="btnAgregar" OnClick="Agregar_Click" CssClass="btn btn-danger mt-3"  runat="server" />
                <asp:Button Text="Eliminar" ID="btnEliminar" CssClass="btn btn-danger mt-3" OnClick="btnEliminar_Click" runat="server" />
                <asp:Button Text="Cancelar" OnClick="Cancelar_Click" CssClass="btn btn-danger mt-3" runat="server" />
                <div class="row-cols-6">
                    <asp:Button Text="Desactivar" ID="btneliminarLogico" OnClick="btneliminarLogico_Click" CssClass="btn btn-warning mt-3" runat="server" />
                    <asp:Button Text="Activar " ID="btnActivar" OnClick="btnActivar_Click" runat="server" CssClass="btn btn-warning mt-3" />
                </div>
                <hr class="row-cols-6" />

                <%if (confirmaEliminacion)
                    {%>

                <div class="form-check">
                    <asp:CheckBox ID="ckbConfirmarEliminacio" runat="server" />
                    <label class="form-check-label" for="flexCheckDefault">
                        Confirmar
                    </label>
                </div>
                <asp:Button Text="Confirmar" ID="btnConfirmarEliminacion" OnClick="btnConfirmarEliminacion_Click" CssClass="btn btn-danger mt-3" runat="server" />


                <%  } %>
            </div>
            <div class="col-6">
                <div>
                    <asp:Label Text="Precio" ID="lblPrecio" CssClass="form-label"  runat="server" />
                    <asp:TextBox runat="server" ID="txbPrecio"  CssClass="form-control" />
                    <asp:Label Text="Descripcion" ID="lblDescripcion" runat="server" />
                    <asp:TextBox runat="server" ID="txbdescripcion" TextMode="MultiLine" CssClass="form-control" />
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="mb-3">
                            <asp:Label Text="Url Imagen" ID="lblurlImagen" CssClass="form-label" runat="server" />
                            <asp:TextBox runat="server" ID="txbUrlImagen" CssClass="form-control" AutoPostBack="true" OnTextChanged="txbUrlImagen_TextChanged" />
                            <hr />
                            <asp:Image ID="imgArticulo" ImageUrl="https://cdn2.iconfinder.com/data/icons/vivid/48/image-512.png" Width="40%" runat="server" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>

    </div>
</asp:Content>
