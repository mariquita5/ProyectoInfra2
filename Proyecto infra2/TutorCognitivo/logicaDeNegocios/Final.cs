using dto;
using System;

namespace logicaDeNegocios
{
    public class Final : Usuario
    {
        private Final(DTOUsuario pUsuario) 
        {
            Nombre = pUsuario.Nombre;
            Apellido1 = pUsuario.Apellido1;
            Apellido2 = pUsuario.Apellido2;
            Correo = pUsuario.Correo;
            Contraseña = pUsuario.Contraseña1;
            Carrera = pUsuario.Carrera;
        }

        public override string toString()
        {
            String datos;
            datos = "Nombre"+ Nombre;
            datos += "Apellido1" + Apellido1;
            datos += "Apellido2" + Apellido2;
            datos += "Correo"+ Correo;
            datos += "carrera"+ Carrera;
            return datos;
        }
    }
}