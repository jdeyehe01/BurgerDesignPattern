namespace BurgerTerminal
{
    public class Memento
    {
        private IStatus status;

        public Memento(IStatus status){
            this.status = status;
        }

        public IStatus getStatus(){
            return this.status;
        }
    }
}