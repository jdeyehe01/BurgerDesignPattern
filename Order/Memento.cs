namespace BurgerTerminal
{
    public class Memento
    {
        private Status status;

        public Memento(Status status){
            this.status = status;
        }

        public Status getStatus(){
            return this.status;
        }
    }
}