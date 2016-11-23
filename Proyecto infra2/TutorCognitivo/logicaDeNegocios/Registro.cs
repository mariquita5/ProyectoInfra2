using System;
using System.Collections.Generic;

namespace logicaDeNegocios
{
    public abstract class Registro
    {
        private DateTime fecha;
        private String accion;

        private List<Bitacora> bitacoras;

        public void RegistroBitacora(String tipoAccion, String accion)
        { 
            this.fecha= DateTime.Today;
            this.accion = tipoAccion;
            this.accion = accion;
            
        }

        public String  Accion
        {
            get { return accion; }
            set {accion = value; }
        }

        
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public List<Bitacora> Bitacora
        {
            get { return bitacoras ; }
            set { bitacoras = value; }
        }


        private void notificarATodos()
        {
            foreach (Bitacora bitacora in bitacoras)
            {
                bitacora.actualizar();
            }

        }

        private  void añadir(Bitacora bitacora)
        {
            bitacoras.Add(bitacora);

        }
}
}