using dto;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace logicaDeNegocios
{
    public class FabricaBitacora
    {
        public String PAQUETE = "modelo.logicaDeNegocio.";

        public void crearBitacora(String pTipoBitacora, List <DTOBitacora> pBitacora)
        {
            Type tipoUsuario = Type.GetType(pTipoBitacora);

            object objeto = Activator.CreateInstance(tipoUsuario);
            object[] parametros = new object[] { pBitacora, DateTime.Now };
            tipoUsuario.InvokeMember("registrarUsuario", BindingFlags.InvokeMethod,
                                               null, objeto, parametros);
        }
    }
}