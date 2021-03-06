﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="ProyectoInfra2.Vista.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio Administrador</title>

    <!--Configuraciones de la página-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!--Archivos .js responsive-->
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->

    <!--Archivos .css responsive-->
    <link rel="stylesheet" href="assets/css/main.css" />
    <!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>
<body>
    <form id="formLogin" runat="server" >
            <!--Cuerpo -->
            <div id="banner-wrapper">
                <section id="banner">
                    <!--titulo-->
                    <h2><a id="logo">Administrador MTA Hmailserver</a></h2>

                    <!--Correo-->
                    <div class="login">


                        <div class="row">
                            <div class="4u" style="text-align: center"></div>
                            <div class="4u" style="text-align: center">
                                <!--Contraseña-->
                                <h4>Contraseña</h4>
                                <p style="text-align: center">
                                    <asp:TextBox ID="txtcontraseña" placeholder="Contraseña"  TextMode="Password" runat="server"  Width="400px"></asp:TextBox>
                                </p>
         
                            </div>
                            <div class="4u" style="text-align: center"></div>
                        </div>


                    <div class="row">
                        <div class="12u" style="text-align: center">
                            <asp:Label ID="lblError" runat="server"></asp:Label>
                        </div>
                    </div>

                    <!--Botones de inicio-->
                    <asp:Button ID="btnFacebook" CssClass="button buttonFacebook" runat="server" Text="Administrador Hmailserver" CausesValidation="true" OnClick="Button3_Click"  />
                </section>
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

