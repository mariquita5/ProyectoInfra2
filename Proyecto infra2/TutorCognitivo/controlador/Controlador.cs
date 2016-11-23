using dto;
using logicaDeDatos;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorCognitivoDS2.TutorCognitivo.controlador;
using logicaDeIntegracion;
using logicaDeNegocios;

namespace controlador
{
    public class Controlador

    {
        private Adaptador adaptador; 

        public List<String[]> obtenerListaCarreras()
        {
            DatoCarrera sCarrera = new DatoCarrera();
            List<String[]> lista = sCarrera.Consulta();

            return lista;
        }

        public void insertarUsuarioFinal(DTOUsuario pUsuario)
        {
            DatoUsuario sUsuario = new DatoUsuario();
            sUsuario.registrarUsuario(pUsuario);
        }

        /*****************************************/

        public bool verificarSesion(DTOInicioSesion pSesion)
        {
            VerificacionDeDatos sSesion = new VerificacionDeDatos();
            return sSesion.verificarInicioSesion(pSesion);
        }

        public void enviarCorreoCategoria()
        {
            Correo correo = new Correo("Categoria", "categorias", "majomadrig5@gmail.com");
            correo.enviarCorreo();

        }

       
        public void crearBitacora()
        {
            FabricaBitacora bitacora = new FabricaBitacora();
        

        }
        public void crearUsuario()
        {
            FabricaUsuario usuario = new FabricaUsuario();
        }


    }
}
