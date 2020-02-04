using static System.Console;
using System;
public class PendingCancel : IState {
    private static PendingCancel instance = new PendingCancel();

    private PendingCancel() { }

    public static PendingCancel GetInstance {
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
        WriteLine("Order pending cancellation, cannot reject.");
    }

    public void ChangeQuantity(Order order)
    {
        WriteLine("Invalid quantity sent!");
    }

    public void ChangeQuantity(Order order, int qty) {
        WriteLine("Order pending cancellation, cannot amend.");
    }

        public void ChangePrice(Order order)
    {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        WriteLine("Order pending cancellation, cannot amend.");
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Executed quantity!");
        Random rnd = new Random();
        int randomQuantity = rnd.Next(1,order.Quantity);
        
        order.Quantity -= randomQuantity;
        order.ExecutedQuantity += randomQuantity;
    }
    public void StopOrder(Order order) {
        WriteLine("Cannot stop order in current state.");
    }
    public void CancelOrder(Order order) {
        order.State = Canceled.GetInstance;
    }
    public void ReplaceOrder(Order order) {
        WriteLine("Cannot replace order in current state.");
    }
}