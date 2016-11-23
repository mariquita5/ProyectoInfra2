using System;

namespace TutorCognitivoDS2.TutorCognitivo.dto
{
    public class DTOConfirmacion
    {
        private String contraseña1;
        private String contraseña2;

        public string Contraseña2
        {
            get { return contraseña2; }
            set { contraseña2 = value; }
        }

        public string Contraseña1
        {
            get { return contraseña1; }
            set { contraseña1 = value; }
        }

        public DTOConfirmacion(String pContraseña1, String pContraseña2)
        {
            contraseña1 = pContraseña1;
            contraseña2 = pContraseña2;
        }
    }
}