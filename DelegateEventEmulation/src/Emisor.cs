namespace Delegados3
{
    public delegate void Handler(string message);
    class Emisor {

        private string nombre;
        private Handler handler;

        public Emisor(string nombre)
        {
            this.nombre = nombre;
        }

        public void Suscribir(Handler eventHandler){
            this.handler += eventHandler;
        }

        public void Desuscribir(Handler eventHandler){
            this.handler -= eventHandler;
        }

        public void Difundir(string noticia){
            handler($"Canal {this.nombre} : ULTIMO MOMENTO!!! {noticia}");
        }
    }
}