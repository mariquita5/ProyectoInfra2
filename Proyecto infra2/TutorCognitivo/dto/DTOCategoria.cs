using System;

namespace dto
{
    public class DTOCategoria
    {
        private String nombre;

        public DTOCategoria(String pNombre)
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