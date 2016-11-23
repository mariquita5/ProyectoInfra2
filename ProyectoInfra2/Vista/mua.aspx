<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mua.aspx.cs" Inherits="ProyectoInfra2.Vista.mua" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MUA Correo INFRATEC</title>
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
    <form id="form1" runat="server">
     <!--Contenedor principal-->
        <div id="page-wrapper">

            <!--Encabezado-->
            <header id="header">

                <!--Nombre del proyecto-->
                <div class="logo container">
                    <div>
                        <h1><a id="logo">Correo INFRATEC</a></h1>
                    </div>
                </div>
            </header>

            <!--Menú principal-->
            <nav id="nav">
                <ul>
                    <li><a href="">Correos Recibidos</a></li>
                    <li><a href="">Correos Enviados</a></li>
                    <li><a href="inicio.aspx">Salir</a></li>
                </ul>
            </nav>

            <!--Cuerpo-->
            <div id="main-wrapper">

                <!--Contenedor-->
                <div id="main" class="container">

                    <div class="row 200%">
                        <div class="12u">

                            <!-- Features -->
                            <section class="box features">
                                <h2 class="major"><span> Bienvenid@</span></h2>
                                <div>

                                    <!--Seccion del nombre y correo-->
                                    <div class="row">

                                        <!--Correo 1-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Para CC</h3>
                                            <asp:TextBox ID="txtNombre" placeholder="correo electronico" runat="server" CssClass="input inputText"></asp:TextBox>
                                        </div>

                                        <!--Correo 2-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Para CCo</h3>
                                            <asp:TextBox ID="txtApellido1" placeholder="correo electronico" runat="server" CssClass="input inputText"></asp:TextBox>
                                        </div>

                                        <!--Asunto-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Asunto</h3>
                                            <asp:TextBox ID="txtApellido2" placeholder="asunto" runat="server" CssClass="input inputText"></asp:TextBox>
                                        </div>

                                    <div class="row">
                                        <div class="12u" style="text-align: center">
                                            <asp:Label ID="lblError" runat="server"></asp:Label>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="12u" style="text-align: center">
                                            <asp:Button ID="btnEnviar" CssClass="button big" runat="server" Text="Enviar" CausesValidation="true"/>
                                        </div>
                                    </div>
                                </div>
                            </section>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Footer -->
            <footer id="footer" class="container">
                <!-- Copyright -->
                <div id="copyright">
                    <ul class="menu">
                        Creado por <b>Grupo 5</b> / II semestre / <b>Noviembre 2016</b>
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
