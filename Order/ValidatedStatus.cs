namespace BurgerTerminal.Order
{
    public class ValidatedStatus : IStatus
    {
        public void goNext(Order order){
            DeliveredStatus status = new DeliveredStatus();
            order.setStatus(status);
        }
    }
}