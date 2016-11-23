using dto;
using System;

namespace logicaDeNegocios
{
    public class Administrador : Usuario
    {
        public Administrador(DTOUsuario pUsuario) 
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
            datos = "Nombre";
            datos += "Apellido1";
            datos += "Apellido2";
            datos += "Correo";
            datos += "Fecha vencimiento contrato";
            return datos;
            
        }
    }
}