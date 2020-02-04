using static System.Console;

public class Rejected : IState {
    private static Rejected instance = new Rejected();

    private Rejected() { }

    public static Rejected GetInstance {
        get { return instance; }
    }

    public void SendNewOrder(Order order)
    {
        WriteLine("Order has been reset, please input new parameters.");
        order.Quantity = 0;
        order.ExecutedQuantity = 0;
        order.Price = 0;
        order.State = CreatingOrder.GetInstance;
    }

    public void RejectOrder(Order order)
    {
        WriteLine("Order already rejected. Please create a new one.");
    }

    public void ChangeQuantity(Order order)
    {
        WriteLine("Invalid quantity sent!");
    }

    public void ChangeQuantity(Order order, int qty) {
        WriteLine("Order already rejected. Please create a new one.");
    }

        public void ChangePrice(Order order)
    {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        WriteLine("Order already rejected. Please create a new one.");
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