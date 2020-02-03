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
        if(order.Quantity > 0 && order.Price > 0)
        {
            WriteLine("Order pending!");
            order.State = PendingNew.GetInstance;
        }
        else
        {
            WriteLine("Internal rejection. Price or Quantity not set properly.");
            order.RejectOrder(order);
        }
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
}