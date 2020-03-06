using static System.Console;

public class Filled : IState {
    private static Filled instance = new Filled();

    private Filled() { }

    public static Filled GetInstance {
        get { return instance; }
    }

    public void SendNewOrder(Order order)
    {
        order.Quantity = 0;
        order.ExecutedQuantity = 0;
        order.Price = 0;
        WriteLine("Order has been reset.");
        order.State = CreatingOrder.GetInstance;
    }
    public void RejectOrder(Order order) {
        WriteLine("Order cannot be rejected!");
    }

    public void ChangePrice(Order order)
    {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        WriteLine("Order already fully executed, send a new one or increase the quantity.");
    }

    public void ChangeQuantity(Order order) {
        WriteLine("Invalid quantity sent!");
    }

    public void ChangeQuantity(Order order, int qty) {
        order.Quantity = qty;
        order.State = PartiallyFilled.GetInstance;
        //if (qty > order.Quantity)
        //else WriteLine($"Quantity has to be bigger than {order.Quantity}!");          Should there be some limitation here?
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Order fully executed, send a new one or increase the quantity.");
    }
    public void StopOrder(Order order) {
        WriteLine("Cannot stop order in current state.");
    }
    public void CancelOrder(Order order) {
        WriteLine("Cannot cancel order in current state.");
    }
    public void ReplaceOrder(Order order) {
        order.State = PendingReplace.GetInstance;
    }
}