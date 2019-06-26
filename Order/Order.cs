namespace BurgerTerminal
{
    public class Order
    {
        private Status status;

        public Status getStatus(){
            return this.status;
        }
        
        public setStatus(Status status){
            this.status = status;
        }

        public void SetMemento(Memento memento){
            this.status = memento.getStatus();
        }

        public Memento createMemento(){
            return new Memento(this.status);
        }
    }
}