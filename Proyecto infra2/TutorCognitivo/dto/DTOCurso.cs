using System;

namespace dto
{
    public class DTOCurso
    {
        private String nombre;

        public DTOCurso(String pNombre)
        {
            nombre = pNombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}