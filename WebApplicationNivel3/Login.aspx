<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplicationNivel3.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-6">
                <asp:Label Text="Usuario" runat="server" CssClass="form-label"/>
                <asp:TextBox runat="server" REQUIRED id="txbUsuario"  CssClass="form-control"/>
                <asp:Label Text="Pass" CssClass="form-label" runat="server" />
                <asp:TextBox runat="server" required id="txbPass" TextMode="Password" CssClass="form-control" />
                <asp:Button Text="Ingresar" id="btnIngresar" OnClick="btnIngresar_Click" CssClass="btn btn-danger mt-3"  runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
