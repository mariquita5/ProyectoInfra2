using System;

namespace logicaDeNegocios
{
    public class Categoria
    {
        private String nombre;

        public Categoria(String pNombre)
        {
            this.nombre = pNombre;
        }

        public void setCategoria(String pNombre)
        {
            this.nombre = pNombre;
        }

        public String getCategoria()
        {
            return nombre;
        }

    }
}