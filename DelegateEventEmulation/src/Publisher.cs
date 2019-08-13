namespace Delegados3
{
    public delegate void Del(string message);
    class Publisher {

        Del handler;
        public void Subscribe(Del eventHandler){
            this.handler += eventHandler;
        }

        public void UnSubscribe(Del eventHandler){
            this.handler -= eventHandler;
        }

        public void Run(){

            for(int i=0; i < 10; i++){
                handler($"event {i} !!!");
                System.Threading.Thread.Sleep(2000);
            }
            
        }
    }
}