using System;

namespace dto
{
    public class DTOBitacora
    {
        private DateTime fechaHora;
        private String accion;
        private String contraseña;

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }

        public string Accion
        {
            get { return accion; }
            set { accion = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public DTOBitacora(DateTime pFechaHora, String pAccion, String pContraseña)
        {
            fechaHora = pFechaHora;
            accion = pAccion;
            contraseña = pContraseña;
        }


    }
}