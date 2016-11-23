namespace logicaDeNegocios
{
    public abstract class Bitacora
    {
        private Registro bitacora;

        public abstract void actualizar();

        public abstract void escribirArchivo();

        public abstract void crearArchivo();

    }
}