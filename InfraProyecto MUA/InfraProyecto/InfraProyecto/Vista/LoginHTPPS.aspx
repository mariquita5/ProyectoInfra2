﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginHTPPS.aspx.cs" Inherits="ProyectoInfra2.Vista.LoginHTPPS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Inicio https</title>
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
    <form id="formLoginHttp" runat="server" >
         <div id="page-wrapper">

            <!-- Nav -->
            <nav id="nav">
                <ul>
                    <li><a href="inicio.aspx">Salir</a></li>
                </ul>
            </nav>
            </div>
            <!--Cuerpo -->
            <div id="banner-wrapper">
                <section id="banner">
                    <!--titulo-->
                    <h2><a id="logo">Correo InfraTEC</a></h2>

                    <!--Correo-->
                    <div class="login">


                        <div class="row">
                            <div class="4u" style="text-align: center"></div>
                            <div class="4u" style="text-align: center">
                                <!--Correo usuario-->
                                <h3>Correo</h3>
                                <p style="text-align: center">
                                    <asp:TextBox ID="txtUsuario" placeholder="Correo electrónico" TextMode="Email" runat="server" CssClass="input inputEmail" Width="400px"></asp:TextBox>
                                </p>
                                <!--Contraseña-->
                                <h4>Contraseña</h4>
                                <p style="text-align: center">
                                    <asp:TextBox ID="txtcontraseña" placeholder="Contraseña"  runat="server"  Width="400px"></asp:TextBox>
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
                    <asp:Button ID="btnGoogle" CssClass="button buttonGoogle" runat="server" Text="Usuario MUA " CausesValidation="true" OnClick="Button1_Click"/>
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
