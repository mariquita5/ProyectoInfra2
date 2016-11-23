using dto;
using System;
using TutorCognitivoDS2.TutorCognitivo.dto;

namespace validacion
{
    public class Validacion
    {
        private static string validarContrasena(String contraseña1, String contraseña2)
        {
            if (!string.Equals(contraseña1, contraseña2))
                return "Las contrasenas no coinciden";
            return string.Empty;
        }

        private static string validarDigitosContrasena(String contraseña)
        {
            if (contraseña.Length < 8)
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
            if (pUsuario.Contraseña1.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Contraseña2.Equals(String.Empty))
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
                return "No pueden haber datos vacíos";
            else
            {
                String Consulta = String.Empty;

                Consulta += validarContrasena(pUsuario.Contraseña1, pUsuario.Contraseña2);
                if (Consulta != String.Empty)
                    return Consulta;

               // Consulta += validarCorreoExistente(pUsuario.Correo);
                if (Consulta != String.Empty)
                    return Consulta;

                Consulta += validarDigitosContrasena(pUsuario.Contraseña1);
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
                return "No pueden haber datos vacíos";
            else
            {
                String Consulta = String.Empty;

                Consulta += validarContrasena(pConfirmacion.Contraseña1, pConfirmacion.Contraseña2);
                if (Consulta != String.Empty)
                    return Consulta;

                Consulta += validarDigitosContrasena(pConfirmacion.Contraseña1);
                if (Consulta != String.Empty)
                    return Consulta;
            }

            return String.Empty;
        }

        public static String validarSesion(DTOInicioSesion pSesion)
        {
            if (!validarCamposSesion(pSesion))
                return "No pueden haber datos vacíos";
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

            if (pConfirmacion.Contraseña1.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pConfirmacion.Contraseña2.Equals(String.Empty))
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
            if (pSesion.Contraseña.Equals(String.Empty))
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