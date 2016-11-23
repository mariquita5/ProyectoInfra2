<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainFinal.aspx.cs" Inherits="TutorCognitivoDS2.vista.MainFinal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Principal</title>

    <!--Configuraciones de la página-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!--Archivos .js responsive-->
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
    <script src="interfaz.js"></script>

    <!--Archivos .css responsive-->
    <link rel="stylesheet" href="assets/css/main.css" />
    <!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>
<body>
    <form id="formMenuFinal" runat="server">
        <!--Contenedor principal-->
        <div id="page-wrapper">

            <!--Encabezado-->
            <header id="header">

                <!--Nombre del proyecto-->
                <div class="logo container">
                    <div>
                        <h1><a id="logo">Tutor Cognitivo</a></h1>
                        <p>por ChuckyBueno</p>
                    </div>
                </div>
            </header>

            <!--Menú principal-->
            <nav id="nav">
                <ul>
                    <li onclick="return confirmarCierre();"><a>Cerrar Sesión</a></li>
                </ul>
            </nav>

            <!--Cuerpo-->
            <div id="main-wrapper">
            </div>

            <!-- Footer -->
            <footer id="footer" class="container">
                <!-- Copyright -->
                <div id="copyright">
                    <ul class="menu">
                        Creado por <b>ChuckyBueno</b> / II semestre / <b>Noviembre 2016</b>
                    </ul>
                </div>
            </footer>
        </div>

        <!-- Scripts -->
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/js/jquery.dropotron.min.js"></script>
        <script src="assets/js/skel.min.js"></script>
        <script src="assets/js/skel-viewport.min.js"></script>
        <script src="assets/js/util.js"></script>
        <!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
        <script src="assets/js/main.js"></script>
    </form>
</body>
</html>
