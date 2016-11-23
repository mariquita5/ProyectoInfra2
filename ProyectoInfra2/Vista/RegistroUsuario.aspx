<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="TutorCognitivoDS2.vista.RegistroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>

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
    <form id="formRegistro" runat="server">
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
                    <li onclick="return confirmarSalida();"><a>Volver</a></li>
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
                                <h2 class="major"><span>Registro de usuarios</span></h2>
                                <div>

                                    <!--Seccion del nombre y correo-->
                                    <div class="row">

                                        <!--Nombre-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Nombre</h3>
                                            <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server" CssClass="input inputText"></asp:TextBox>
                                        </div>

                                        <!--Apell1do 1-->
                                        <div class="4u 12u(mobile)">
                                            <h3>1° Apellido</h3>
                                            <asp:TextBox ID="txtApellido1" placeholder="1° Apellido" runat="server" CssClass="input inputText"></asp:TextBox>
                                        </div>

                                        <!--Apellido 2-->
                                        <div class="4u 12u(mobile)">
                                            <h3>2° Apellido</h3>
                                            <asp:TextBox ID="txtApellido2" placeholder="2° Apellido" runat="server" CssClass="input inputText"></asp:TextBox>
                                        </div>

                                        <!--Correo-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Correo electrónico</h3>
                                            <asp:TextBox ID="txtCorreo" placeholder="ejemplo@dominio.com" TextMode="Email" runat="server" CssClass="input inputEmail"></asp:TextBox>
                                        </div>

                                        <!--Contraseña-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Contraseña</h3>
                                            <asp:TextBox ID="txtContraseña1" placeholder="Digite la contraseña" runat="server" TextMode="Password" CssClass="input inputPassword"></asp:TextBox>
                                        </div>

                                        <!--Confirmar Contraseña-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Confirmar Contraseña</h3>
                                            <asp:TextBox ID="txtContraseña2" placeholder="Confirme su contraseña" runat="server" TextMode="Password" CssClass="input inputPassword"></asp:TextBox>
                                        </div>

                                        <!--Carrera-->
                                        <div class="4u 12u(mobile)">
                                            <h3>Carrera</h3>
                                            <asp:DropDownList ID="ddlCarrera" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="12u" style="text-align: center">
                                            <asp:Label ID="lblError" runat="server"></asp:Label>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="12u" style="text-align: center">
                                            <asp:Button ID="btnAceptar" CssClass="button big" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" OnClientClick="return true;" />
                                            <asp:Button ID="btnCancelar" CssClass="button alt big" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="true" />
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
