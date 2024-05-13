<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplicationNivel3.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="carouselExampleAutoplaying" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211217&authkey=%21AIxcjqJ8BaB_euQ&width=1800&height=209" width="auto" height="209" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211218&authkey=%21AIT2zwaXsPlrXmE&width=2560&height=682" width="auto" height="209" class="d-block w-100" alt="...">
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
    <div class="row ">
        <div class="col-6 d-flex justify-content-center align-items-center">
            <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211248&authkey=%21AKbhJEhH4h_SJb4&width=1000&height=1500" width="250" height="400" />
        </div>
        <div class="col-6 align-content-center">
            <b><i>"Explora nuestra selección premium de pantalones de jeans engomados, remeras y joggins para niños. Encuentra calidad, comodidad y estilo en cada prenda. ¡Viste a tus pequeños con lo mejor en moda infantil!"</i></b>
        </div>
    </div>
    <div class="row">
        <div class="col-6 align-content-center">
            <b><i>"Explora nuestra exclusiva colección de peluches para niños, donde la ternura y la calidad se unen para crear compañeros de juego inolvidables. Desde adorables animales hasta personajes fantásticos, cada peluche está diseñado para brindar horas de diversión y confort a tus pequeños. Encuentra el compañero perfecto para hacer sonreír a tu niño y hacer que cada momento sea mágico."</i></b>
        </div>
        <div class="col-6 d-flex justify-content-center align-items-center">
            <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211250&authkey=%21AMP0TmysiUEXzP0&height=256" width="auto" height="400" />
        </div>
    </div>
    <div class="row">
        <div class="col-6 d-flex justify-content-center align-items-center">
            <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211249&authkey=%21AIK_j4tiMrG6MQM&width=966&height=1449" width="auto" height="400" />
        </div>
        <div class="col-6 align-content-center">
            <b><i>"Descubre nuestra excepcional colección de indumentaria infantil, donde la calidad y el estilo se fusionan para vestir a tus pequeños con lo mejor. Desde elegantes conjuntos hasta prendas cómodas y duraderas, cada pieza está diseñada pensando en la comodidad y el encanto de los más pequeños. Encuentra la moda perfecta para cada ocasión y haz que tus niños destaquen con confianza y alegría en cada paso."</i></b>
        </div>
    </div>
    <hr />
    <footer class="js-hide-footer-while-scrolling display-when-content-ready mt-3 position-relative" data-store="footer" style="display: block;">
        <div class="container-fluid px-md-5 pb-5 pb-md-0">
            <div class="row justify-content-center pt-5 pt-md-4 py-3 px-md-6 px-0">
                <div class="col-12 text-center">
                    <div class="footer-logo custom-seal">
                        <img src="https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211252&authkey=%21AKdw5-z7H3clGUM&width=1001&height=343" width="auto" height="100" alt="Logo Curlurocker Shop">
                    </div>
                </div>
            </div>
            <div class="row element-footer mb-3 justify-content-center py-3 px-md-6 px-3">
                <div class="col-12 col-md-12 mb-4 text-center p-md-0 py-3 py-md-0">
                    <div class="d-block d-md-flex row footer-menu flex-wrap justify-content-center bg-black">
                        <div class="px-3 footer-menu-item mt-1">
                            <a class="footer-menu-link" href="">Preguntas Frecuentes</a>
                        </div>
                        <div class="px-3 footer-menu-item mt-1">
                            <a class="footer-menu-link" href="">Condiciones de envío</a>
                        </div>
                        <div class="px-3 footer-menu-item mt-1">
                            <a class="footer-menu-link" href="">Cambio y Devolución</a>
                        </div>
                        <div class="px-3 footer-menu-item mt-1">
                            <a class="footer-menu-link" href="">¿Cómo Comprar?</a>
                        </div>
                        <div class="px-3 footer-menu-item mt-1">
                            <a class="footer-menu-link" href="h">Términos y Condiciones</a>
                        </div>
                        <div class="px-3 footer-menu-item mt-1">
                            <a class="footer-menu-link" href="">Stores</a>
                        </div>
                        <div class="px-3 footer-menu-item mt-1">
                            <a class="footer-menu-link" href="">Contacto</a>
                        </div>
                    </div>
                </div>
            </div>

            <div class="w-100 my-2"></div>

        </div>
        <div class="row element-footer font-small font-weight-light px-md-6 px-0">
            <div class="col-md-4 text-center text-md-left">
                © Copyright CurlyRocker Shop - 2024
            </div>
            <div class="col-md-4 powered-by my-2 my-md-0 text-center">
                <div class="powered-by-logo">
                </div>

            </div>
            <div class="col-md-4 text-center text-md-right">
                Todos los derechos reservados.
            </div>
        </div>

        <div class="row element-footer font-small font-weight-light">
            <div class="col text-center">
                <div class="claim-link">
                    Defensa de las y los consumidores. Para reclamos
                        <a class="font-weight-normal" href="https://www.argentina.gob.ar/produccion/defensadelconsumidor/formulario" target="_blank">ingrese aquí</a>
                </div>
            </div>
        </div>
        </div>
    </footer>
</asp:Content>
