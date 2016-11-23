
using dto;
using System;
using System.Reflection;

namespace logicaDeNegocios
{
    public class FabricaUsuario
    {
        private String PAQUETE = "frameworkNet.logicaDeNegocio.";
        private Object usuario;

        public void crearUsuario(String pTipoUsuario, DTOUsuario pUsuario)
        {
            Type tipoUsuario = Type.GetType(pTipoUsuario);

            object objeto = Activator.CreateInstance(tipoUsuario);
            object[] parametros = new object[] { pUsuario, DateTime.Now };
            tipoUsuario.InvokeMember("registrarUsuario", BindingFlags.InvokeMethod,
                                               null, objeto, parametros);

        }

        public void crearUsuario(String pTipoUsuario, DTOUsuario pUsuario, DateTime pVencimiento)
        {
        }

    }
}