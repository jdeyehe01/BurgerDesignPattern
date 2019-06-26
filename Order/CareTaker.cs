namespace BurgerTerminal
{
    public class CareTaker
    {
        private List<Memento> mementoList = new ArrayList<Memento>();

        public void add(Memento memento){
            mementoList.add(memento);
        }

        public void get(int index){
            return mementoList.get(index);
        }
    }
}