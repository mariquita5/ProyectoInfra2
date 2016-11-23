<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministrarDatos.aspx.cs" Inherits="TutorCognitivoDS2.vista.AdministrarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrar Datos</title>

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
    <form id="formMenuAdmin" runat="server">
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
                    <li><a href="MainAdmin.aspx">Menu principal</a></li>
                    <li><a href="Consultas.aspx">Consultas</a></li>
                    <li onclick="return confirmarCierre();"><a>Cerrar Sesión</a></li>
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
                                <div class="row">
                                    <div class="3u 3u(mobile)" style="text-align: center">
                                        <h3>Administrar cursos</h3>
                                    </div>
                                    <div class="3u 3u(mobile)" style="text-align: center">
                                        <h3>Administrar Categorias</h3>
                                    </div>
                                    <div class="6u 3u(mobile)" style="text-align: center">
                                        <h3>Administrar Tutores</h3>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="3u 3u(mobile)">
                                        Nombre del curso
                                        <asp:TextBox ID="txtNombreCurso" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="3u 3u(mobile)">
                                        Nombre de la categoria
                                        <asp:TextBox ID="txtNombreCategoria" runat="server"></asp:TextBox>
                                        Curso
                                        <asp:DropDownList ID="ddlCurso" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="3u 3u(mobile)">
                                        Nombre
                                        <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server" CssClass="input inputText"></asp:TextBox>
                                        1° Apellido
                                        <asp:TextBox ID="txtApellido1" placeholder="1° Apellido" runat="server" CssClass="input inputText"></asp:TextBox>
                                        2° Apellido
                                        <asp:TextBox ID="txtApellido2" placeholder="2° Apellido" runat="server" CssClass="input inputText"></asp:TextBox>

                                    </div>
                                    <div class="3u 3u(mobile)">
                                        Correo electrónico
                                        <asp:TextBox ID="txtCorreo" placeholder="ejemplo@dominio.com" TextMode="Email" runat="server" CssClass="input inputEmail"></asp:TextBox>
                                        Carrera
                                        <asp:DropDownList ID="ddlCarrera" runat="server"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="3u 3u(mobile)" style="text-align: center">
                                        <asp:Button ID="btnCurso" runat="server" Text="Aceptar"></asp:Button>
                                    </div>
                                    <div class="3u 3u(mobile)" style="text-align: center">
                                        <asp:Button ID="btnCategoria" runat="server" Text="Aceptar"></asp:Button>
                                    </div>
                                    <div class="6u 3u(mobile)" style="text-align: center">
                                        <asp:Button ID="btnTutor" runat="server" Text="Aceptar"></asp:Button>
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
