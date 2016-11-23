using System;
using System.Collections;

namespace logicaDeNegocios
{
    public class Curso
    {
        private String codigo;
        private String nombre;
        private ArrayList categorias;

        public Curso(String  pCodigo, String pNombre)
        {
            this.codigo = pCodigo;
            this.nombre = pNombre;
        }

        public void setCodigo(String pCodigo)
        {
            this.codigo = pCodigo;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public void setNombre(String pNombre)
        {
            this.nombre = pNombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String toString()
        {
            String datos;
            datos = "codigo" + codigo;
            datos += "nombre" + nombre;
            return datos;
        }
    }
}