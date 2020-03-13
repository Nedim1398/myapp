using static System.Console;

public class DoneForDay : IState {
    private static DoneForDay instance = new DoneForDay();

    private DoneForDay() { }

    public static DoneForDay GetInstance {
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
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Order done for day, send a new one or increase the quantity.");
    }
    
    public void RejectOrder(Order order) {
        WriteLine("Order cannot be rejected!");
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