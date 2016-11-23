using System;

namespace dto
{
    public class DTOInicioSesion
    {
        private String correo;
        private String contraseña;
        private int tipo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public DTOInicioSesion(String pCorreo, String pContraseña, int pTipo)
        {
            correo = pCorreo;
            contraseña = pContraseña;
            tipo = pTipo;
        }
    }
}