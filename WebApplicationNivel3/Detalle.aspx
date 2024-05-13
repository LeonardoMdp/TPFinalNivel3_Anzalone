<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebApplicationNivel3.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .titulo1 {
            color: red;
            font-size: 25px;
            font-style: italic
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-5 ">
            <asp:Image ID="imgDetalle" Width="100%" runat="server" />
        </div>


        <div class="col-5">
            <div class="titulo1">
                <asp:Label Text="Descripcion: " runat="server" />
            </div>
            <div>
                <asp:Label Text="" ID="labelDetalle" CssClass="form-label" runat="server" />
                <asp:Button Text="Agregar A Favoritos" ID="btnAgregaraFavoritos" OnClick="btnAgregaraFavoritos_Click" CssClass="btn btn-danger float-end align-content-center" runat="server" />
            </div>
            <hr />
            <div>
                <asp:Image ImageUrl="https://d2r9epyceweg5n.cloudfront.net/stores/402/355/rte/1.png" Width="100%" CssClass="align-content-end" runat="server" />
            </div>
            <hr />
        </div>
    </div>

    </div>
</asp:Content>
