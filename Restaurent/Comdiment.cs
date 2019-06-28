namespace BurgerTerminal
{
    internal class Comdiment : IExtra
    {
        private PortionSize size;

        public Comdiment(PortionSize size)
        {
            this.size = size;
        }
    }
}