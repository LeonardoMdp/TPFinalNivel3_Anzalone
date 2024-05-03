<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Mi Perfil.aspx.cs" Inherits="WebApplicationNivel3.Mi_Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .validacion {
            color: red;
            font-size: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h3>Mi Perfil</h3>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <asp:Label Text="Email" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txbEmail" CssClass="form-control" runat="server" />
                <asp:RegularExpressionValidator ErrorMessage="Debe Ingresar Formato de E-Mail" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" ControlToValidate="txbEmail" runat="server" />
            </div>
            <div>
                <div class="mb-3">
                    <asp:Label Text="Nombre" CssClass="form-label" runat="server" />
                    <asp:TextBox ID="txbNombre" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Debe Ingresar Un Nombre" CssClass="validacion" ControlToValidate="txbNombre" runat="server" />
                </div>
            </div>
            <div>
                <div class="mb-3">
                    <asp:Label Text="Apellido" CssClass="form-label" runat="server" />
                    <asp:TextBox ID="txbApellido" CssClass="form-control" runat="server" />
                </div>
            </div>

            <div class="mb-3">
                <asp:Label Text="fecha de Nacimiento" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txbFechaNacimiento" TextMode="Date" CssClass="form-control" runat="server" />
            </div>
        </div>
        <div class="col-md-4">
            <div class="mb-3">
                <asp:Label Text="Imagen de Perfil" CssClass="form-label" runat="server" />
                <input type="file" id="txtImagen" runat="server" class="form-control" />
            </div>
            <asp:Image ID="imagenPerfil" ImageUrl="https://as2.ftcdn.net/v2/jpg/05/17/53/57/1000_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg" CssClass="img-fluid mb-3" runat="server" />
        </div>
        <div class="row">
            <div class="col-md-4">
                <asp:Button Text="Guardar" ID="btnGuardar" OnClick="btnGuardar_Click" CssClass="btn btn-danger mt-3" runat="server" />
                <%--  <asp:Button Text="Regeresar" ID="btnRegresar" OnClick="btnRegresar_Click" CssClass="btn btn-danger mt-3" runat="server" />--%>
            </div>
        </div>
    </div>

</asp:Content>
