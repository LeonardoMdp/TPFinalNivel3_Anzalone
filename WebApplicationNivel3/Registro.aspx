<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebApplicationNivel3.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .validacion{
            color:red;
            font-size:12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Alta De Usuario</h1>
    <div class="container row col-5">
        <asp:Label Text="Email" CssClass="form-label" runat="server" />
        <asp:TextBox id="txbEmail" TextMode="Email" CssClass="form-control" required runat="server" />     
        <asp:RegularExpressionValidator ErrorMessage="Debe Ingresar Formato De E-Mail" CssClass="validacion" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" ControlToValidate="txbEmail" runat="server" />
        <asp:Label Text="Contraseña" CssClass="form-label" runat="server" />
        <asp:TextBox id="txbcontraseña" CssClass="form-control" TextMode="Password" required runat="server" />  
    </div>
    <div class="mt-4">
        <asp:Button Text="Registrarce" CssClass="btn btn-danger" id="btnRegistrarce" OnClick="btnRegistrarce_Click" runat="server" />
        <%--<asp:Button Text="Cancelar" CssClass="btn btn-danger" id="btnCancelar" OnClick="btnCancelar_Click" runat="server" />--%>
    </div>
</asp:Content>
