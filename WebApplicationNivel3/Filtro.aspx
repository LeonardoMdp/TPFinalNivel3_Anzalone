<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Filtro.aspx.cs" Inherits="WebApplicationNivel3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-4">
            <asp:Label Text="Buscar" runat="server" />
            <asp:TextBox runat="server" CssClass="form-control" AutoPostBack="true" ID="txbBuscar" OnTextChanged="txbBuscar_TextChanged" />
        </div>
        <div class="col ali mt-auto">
            <asp:CheckBox ID="ckbfiltravanzado" CssClass="form-check" AutoPostBack="true" Text=" Filtro Avanzado" runat="server" OnCheckedChanged="ckbfiltravanzadoo_CheckedChanged" />
        </div>
    </div>

    <hr />
    <%-- <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="udpavanzado" runat="server">
        <ContentTemplate>--%>
    <%if (filtroAvanzado)
        { %>

    <div class="row">
        <div class="col-3">
            <asp:Label Text="Campo" runat="server" />
            <asp:DropDownList runat="server" ID="ddlCampoavanzado" AutoPostBack="true" OnSelectedIndexChanged="ddlCampoavanzado_SelectedIndexChanged" CssClass="form-control">
                <asp:ListItem Text="Codigo De Articulo" />
                <asp:ListItem Text="Nombre" />
                <asp:ListItem Text="Precio" />
            </asp:DropDownList>
        </div>
        <div class="col-3">
            <asp:Label Text="Criterio" runat="server" />
            <asp:DropDownList ID="ddlCriterioAvanzado" CssClass="form-control" AutoPostBack="true" runat="server">
                <asp:ListItem Text="Igual a..." />
            </asp:DropDownList>
        </div>
        <div class="col-3">
            <asp:Label Text="Filtro" runat="server" />
            <asp:TextBox ID="txbfiltroAvanzado" CssClass="form-control" runat="server" />

        </div>
        <div class="col-3">
            <asp:Label Text="Estado" runat="server" />
            <asp:DropDownList runat="server" ID="ddlEstadoAvanzado" AutoPostBack="true" CssClass="form-control">
                <asp:ListItem Text="Activado" />
                <asp:ListItem Text="Desactivado" />
                <asp:ListItem Text="Todo" />
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-auto mt-3">
            <asp:Button Text="Buscar" ID="btnBuscaravanzado" OnClick="btnBuscaravanzado_Click" CssClass="btn btn-danger" runat="server" />
        </div>
    </div>
    <% } %>
    <%--      </ContentTemplate>
    </asp:UpdatePanel>--%>

    <asp:GridView ID="dgwArticulos" runat="server" DataKeyNames="id" AutoGenerateColumns="false" CssClass="table table-danger mt-3"
        AllowPaging="true" PageSize="8"
        OnPageIndexChanging="dgwArticulos_PageIndexChanging"
        OnSelectedIndexChanged="dgwArticulos_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Codigo de Articulo" DataField="CodArt" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
            <asp:CheckBoxField HeaderText="Activo" DataField="activo" />
            <asp:CommandField HeaderText="Editar" ShowSelectButton="true" SelectText="Seleccionar" />
        </Columns>
    </asp:GridView>

    <a href="formularioDeArticulos.aspx" class="btn btn-danger mt-3">Agregar</a>





    <%--  <div class="row row-cols-1 row-cols-md-2 row-cols-lg-4 g-4">--%>


    <%--        <%
            foreach (Dominio.Articulo item in ListaDeArticulos)
            {
        %>
        <div class="col">
            <div class="card">
                <img src="<%:item.Imagen%>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title bg-danger text-center text-white"><%:item.Nombre%></h5>
                    <p class="card-text bg-danger text-center text-white">$<%:item.Precio%></p>
                    <a href="Detalle.aspx?id=<%:item.id %>">Detalle</a>

                </div>
            </div>
        </div>

        <% } %>--%>

    <%--  <asp:Repeater ID="Repetidor" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                        <img src='<%#Eval("Imagen")%>' class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title bg-danger text-center text-white"><%#Eval("nombre")%></h5>
                            <p class="card-text bg-danger text-center text-white">$<%#Eval("precio")%></p>
                            <a href="Detalle.aspx?id=<%#Eval("id")%>">Detalle</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>

        </asp:Repeater>--%>
</asp:Content>
