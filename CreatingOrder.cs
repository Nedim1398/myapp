using static System.Console;

public class CreatingOrder : IState {
    private static CreatingOrder instance = new CreatingOrder();

    private CreatingOrder() { }

    public static CreatingOrder GetInstance {
        get { return instance; }
    }
    public void SendNewOrder(Order order)
    {
        order.State = PendingNew.GetInstance;
    }

    public void RejectOrder(Order order)
    {
        WriteLine("Order not sent, cannot reject.");
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