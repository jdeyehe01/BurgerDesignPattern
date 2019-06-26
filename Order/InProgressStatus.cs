namespace BurgerTerminal.Order
{
    public class InProgressStatus : IStatus
    {
        public void goNext(Order order){
            ValidatedStatus status = new ValidatedStatus();
            order.setStatus(status);
        }
    }
}