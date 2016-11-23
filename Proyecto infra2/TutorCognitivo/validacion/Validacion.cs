using dto;
using System;
using TutorCognitivoDS2.TutorCognitivo.dto;

namespace validacion
{
    public class Validacion
    {
        private static string validarContrasena(String contrase�a1, String contrase�a2)
        {
            if (!string.Equals(contrase�a1, contrase�a2))
                return "Las contrasenas no coinciden";
            return string.Empty;
        }

        private static string validarDigitosContrasena(String contrase�a)
        {
            if (contrase�a.Length < 8)
                return "Contrasena debe tener al menos 8 caracteres";
            return string.Empty;
        }

        private static string validarCorreoValido(String correo)
        {
            if (correo.IndexOf("@") == -1)
                return "No corresponde a un correo";

            else if (correo.IndexOf(".com") == -1 && correo.IndexOf(".es") == -1)
                return "No corresponde a un correo";

            return string.Empty;
        }

        private static Boolean validarCamposRegistro(DTOUsuario pUsuario)
        {
            Boolean flag = true;
            if (pUsuario.Nombre.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Apellido1.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Apellido2.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Correo.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Carrera.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Contrase�a1.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Contrase�a2.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            else
            {
                return flag;
            }
        }

        public static string validarFechaInicioMenorFinal(DateTime pFechaInicio, DateTime pFechaFinal)
        {
            if (pFechaInicio > pFechaFinal)
                return "Fecha inicio no puede ser mayor a fecha final";
            return string.Empty;            
        }
        public static string validarFechaInicioFinalMenorHoy(DateTime pFechaInicio, DateTime pFechaFinal)
        {
            if ((pFechaInicio > DateTime.Now) || (pFechaFinal > DateTime.Now))
                return "Fechas no pueden ser mayor a la fecha actual";
            return string.Empty;
        }

        public static String validarRegistro(DTOUsuario pUsuario)
        {
            if (!validarCamposRegistro(pUsuario))
                return "No pueden haber datos vac�os";
            else
            {
                String Consulta = String.Empty;

                Consulta += validarContrasena(pUsuario.Contrase�a1, pUsuario.Contrase�a2);
                if (Consulta != String.Empty)
                    return Consulta;

               // Consulta += validarCorreoExistente(pUsuario.Correo);
                if (Consulta != String.Empty)
                    return Consulta;

                Consulta += validarDigitosContrasena(pUsuario.Contrase�a1);
                if (Consulta != String.Empty)
                    return Consulta;

                Consulta += validarCorreoValido(pUsuario.Correo);
                if (Consulta != String.Empty)
                    return Consulta;
            }

            return String.Empty;
        }

        /*****************************************/

        public static String validarConfirmacion(DTOConfirmacion pConfirmacion)
        {
            if (!validarCamposConfirmacion(pConfirmacion))
                return "No pueden haber datos vac�os";
            else
            {
                String Consulta = String.Empty;

                Consulta += validarContrasena(pConfirmacion.Contrase�a1, pConfirmacion.Contrase�a2);
                if (Consulta != String.Empty)
                    return Consulta;

                Consulta += validarDigitosContrasena(pConfirmacion.Contrase�a1);
                if (Consulta != String.Empty)
                    return Consulta;
            }

            return String.Empty;
        }

        public static String validarSesion(DTOInicioSesion pSesion)
        {
            if (!validarCamposSesion(pSesion))
                return "No pueden haber datos vac�os";
            else
            {
                String Consulta = String.Empty;

                Consulta += validarCorreoValido(pSesion.Correo);
                if (Consulta != String.Empty)
                    return Consulta;
            }

            return String.Empty;
        }





        private static Boolean validarCamposConfirmacion(DTOConfirmacion pConfirmacion)
        {
            Boolean flag = true;

            if (pConfirmacion.Contrase�a1.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pConfirmacion.Contrase�a2.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            else
            {
                return flag;
            }
        }

        private static Boolean validarCamposSesion(DTOInicioSesion pSesion)
        {
            Boolean flag = true;
            if (pSesion.Correo.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pSesion.Contrase�a.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            else
            {
                return flag;
            }
        }

        public static void validarCorreoExistente(String pCorrreo)
        {

        }
}
}