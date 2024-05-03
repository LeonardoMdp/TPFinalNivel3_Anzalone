<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplicationNivel3.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="carouselExampleAutoplaying" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211217&authkey=%21AIxcjqJ8BaB_euQ&width=1800&height=209" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211218&authkey=%21AIT2zwaXsPlrXmE&width=2560&height=682" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://www.latercera.com/resizer/LlIFIlNj-lHBgL62b7WsNVr_UQY=/900x600/smart/arc-anglerfish-arc2-prod-copesa.s3.amazonaws.com/public/BMF7RTCUQBG3LGNET5VSU4MNPM.jpg" class="d-block w-50" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
    <hr />
    <footer>
        <div class="card">
            <div class="card-header">
                Featured
            </div>
            <div class="card-body">
                <h5 class="card-title">Special title treatment</h5>
                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="#" class="btn btn-primary">Go somewhere</a>
            </div>
        </div>
    </footer>
</asp:Content>
