namespace BurgerTerminal
{
    public class Order
    {
        private IStatus status;

        public IStatus getStatus(){
            return this.status;
        }
        
        public setStatus(IStatus status){
            this.status = status;
        }

        public goNext(){
            status.goNext(this);
        }

        public void SetMemento(Memento memento){
            this.status = memento.getStatus();
        }

        public Memento createMemento(){
            return new Memento(this.status);
        }
    }
}