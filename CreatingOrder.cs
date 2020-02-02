using static System.Console;

public class CreatingOrder : IState {
    private static CreatingOrder instance = new CreatingOrder();

    private CreatingOrder() { }

    public static CreatingOrder GetInstance {
        get { return instance; }
    }
    public void SendNewOrder(Order order)
    {
        WriteLine("Connecting to market...");
        WriteLine("Order pending!");
        order.State = PendingNew.GetInstance;
    }

    public void RejectOrder(Order order)
    {
        WriteLine("Internal rejection");
        order.State = Rejected.GetInstance;
    }

    public void ChangeQuantity(Order order) {
        WriteLine("No quantity sent!");
    }
    public void ChangeQuantity(Order order, int qty) {
        //WriteLine($"Quantity is now: {qty} shares!");
        order.ChangeQuantity(order, qty);
    }

    public void ChangePrice(Order order)
    {
        throw new System.NotImplementedException();
    }
}