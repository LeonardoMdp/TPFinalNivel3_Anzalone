<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="remerasInternacionales.aspx.cs" Inherits="WebApplicationNivel3.CatalogoDeProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-cols-1 row-cols-md-2 row-cols-lg-4 g-4">

        <asp:Repeater ID="Repetidor" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                        <img src='<%#Eval("Imagen")%>' class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title bg-danger bg-gradient text-center text-white fw-bolder"><%#Eval("nombre")%></h5>
                            <p class="card-text bg-danger bg-gradient text-center text-white">$<%#Eval("precio")%></p>
                            <a href="Detalle.aspx?id=<%#Eval("id")%>">Detalle</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
