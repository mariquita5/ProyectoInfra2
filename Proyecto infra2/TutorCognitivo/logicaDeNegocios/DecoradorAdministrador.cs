using dto;
using System.Collections.Generic;

namespace logicaDeNegocios
{
    public class DecoradorAdministrador : Administrador
    {
        private Administrador administrador;

        public DecoradorAdministrador(DTOUsuario pUsuario)
            : base(pUsuario)
        {
            administrador = new Administrador(pUsuario);
        }

       
        public void registrarCategoria( DTOCategoria categoria)
        { 
            Categoria categoria2 = new Categoria(categoria.Nombre);

        }

       
    }
}