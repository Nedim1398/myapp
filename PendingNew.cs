using static System.Console;

public class PendingNew : IState {
    private static PendingNew instance = new PendingNew();

    private PendingNew() { }

    public static PendingNew GetInstance {
        get { return instance; }
    }
    public void SendNewOrder(Order order)
    {
        if(order.Quantity > 0) // Market check
        {
            WriteLine("Order sent!");
            order.State = New.GetInstance;
        }
        else
        {
            order.RejectOrder(order);
        }
    }

    public void RejectOrder(Order order)
    {
        WriteLine("Quantity does not respect lot size! | Market Rejection"); // Market rejection
        order.State = Rejected.GetInstance;
    }

    public void ChangeQuantity(Order order) {
        WriteLine("Invalid quantity sent!");
    }
    public void ChangeQuantity(Order order, int qty) {
        order.Quantity = qty;
    }

    public void ChangePrice(Order order)
    {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        order.Price = price;
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Order not on market!");
    }
    public void StopOrder(Order order) {
        WriteLine("Cannot stop order in current state.");
    }
    public void CancelOrder(Order order) {
        WriteLine("Cannot cancel order in current state.");
    }
    public void ReplaceOrder(Order order) {
        WriteLine("Cannot replace order in current state.");
    }
}