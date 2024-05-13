<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MisFavoritos.aspx.cs" Inherits="WebApplicationNivel3.MisFavoritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Mis Favoritos</h3>
    <div class="row row-cols-1 row-cols-md-2 row-cols-lg-4 g-4">

        <asp:Repeater ID="RepetidorFavoritos" OnItemCommand="RepetidorFavoritos_ItemCommand" runat="server">
            <ItemTemplate>
                <div class="card" style="width: 10rem;">
                    <img src='<%#Eval("Imagen")%>' class="card-img-top" alt="...">
                    <div class="card-body text-center">
                        <asp:Button runat="server" CommandName="EliminarFavorito" CommandArgument='<%# Eval("Id") %>'  Text="Eliminar" CssClass="btn btn-dark btn-sm" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
