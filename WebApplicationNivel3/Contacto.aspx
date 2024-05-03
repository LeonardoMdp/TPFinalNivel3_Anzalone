<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="WebApplicationNivel3.EnvioDeEmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-5">
            <asp:Label Text="E-mail" CssClass="form-label" runat="server" />
            <asp:TextBox ID="txbEmail" CssClass="form-control" TextMode="Email" runat="server" />
            <asp:Label Text="Asunto" CssClass="form-label" runat="server" />
            <asp:TextBox id="txbAsunto" CssClass="form-control" runat="server" /> 
            <asp:Label Text="Mensaje" CssClass="form-label" runat="server" />
            <asp:TextBox id="txbMensaje" CssClass="form-control" TextMode="MultiLine" runat="server" /> 
            <asp:Button Text="Enviar" ID="btnEnviar" OnClick="btnEnviar_Click" CssClass="btn btn-danger mt-3" runat="server" />
        </div>
    </div>
</asp:Content>
