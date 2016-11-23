<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="TutorCognitivoDS2.vista.Consultas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consultas</title>

    <!--Configuraciones de la página-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!--Archivos .js responsive-->
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
    <script src="interfaz.js"></script>

    <!--Archivos .css responsive-->
    <link rel="stylesheet" href="assets/css/main.css" />
    <!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->

    <script type="text/javascript">
        
    </script>
</head>
<body onload="mostrar(0);">
    <form id="formMenuAdmin" runat="server">
        <!--Contenedor principal-->
        <div id="page-wrapper">

            <!--Menú principal-->
            <nav id="nav">
                <ul>
                    <li><a href="MainAdmin.aspx">Menu principal</a></li>
                    <li><a href="AdministrarDatos.aspx">Administrar Datos</a></li>
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
                                    <div class="4u 12u(mobile)">
                                        <h3>Seleccione la consulta</h3>
                                    </div>
                                    <div class="4u 12u(mobile)">
                                        <select onchange="mostrar(this.value);">
                                            <option value="0" selected="selected">--Seleccione--</option>
                                            <option value="1">Bitacora entre dos fechas</option>
                                            <option value="2">Tutor con mas aportes</option>
                                            <option value="3">Tutor por fecha de vencimiento</option>
                                        </select>
                                    </div>
                                </div>

                                <div class="row" id="capa0">&nbsp;</div>

                                <div class="row" id="capa1">
                                    <div class="2u 12u(mobile)">
                                        <h3>Fecha Inicio:</h3>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <asp:TextBox ID="txtInicioBitacora" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <h3>Fecha Final:</h3>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <asp:TextBox ID="txtFinalBitacora" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <asp:Button ID="btnConsultarBitacora" CssClass="button big" runat="server" Text="Consultar" OnClick="btnConsultarBitacora_Click" />
                                    </div>
                                </div>

                                <div class="row" id="capa2">
                                    <div class="10u 12u(mobile)">
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <asp:Button ID="btnConsultarTutorAporte" CssClass="button big" runat="server" Text="Consultar" OnClick="btnConsultarTutorAporte_Click" />
                                    </div>
                                </div>

                                <div class="row" id="capa3">
                                    <div class="2u 12u(mobile)">
                                        <h3>Fecha Inicio:</h3>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                       <asp:TextBox ID="txtInicioTutor" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <h3>Fecha Final:</h3>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <asp:TextBox ID="txtFinalTutor" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <div class="2u 12u(mobile)">
                                    </div>
                                    <div class="2u 12u(mobile)">
                                        <asp:Button ID="btnConsultarTutorFecha" CssClass="button big" runat="server" Text="Consultar" OnClick="btnConsultarTutorFecha_Click" />
                                    </div>
                                </div>

                                <div>
                                    <!--Seccion del nombre y correo-->
                                    <div class="row">
                                        <!--Nombre-->
                                        <div class="12u 12u(mobile)">
                                            <asp:GridView ID="GridConsultas" runat="server" Width="95%"></asp:GridView>
                                        </div>
                                    </div>
                                </div>
                            </section>
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
