using System;

namespace logicaDeNegocios
{
    public class RegistroBitacora : Registro
    {
        public RegistroBitacora()
        {
        }

        public void actualizarFecha(DateTime pFecha)
        {
            Fecha = pFecha;

        }
        public void actualizarAccion(String accion)
        {
            Accion = accion;
        }


        

        
    }
}