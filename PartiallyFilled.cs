using System;
using static System.Console;

public class PartiallyFilled : IState {
    private static PartiallyFilled instance = new PartiallyFilled();

    private PartiallyFilled() { }

    public static PartiallyFilled GetInstance {
        get { return instance; }
    }

    public void SendNewOrder(Order order)
    {
        WriteLine("MiniTradeMind does not support multiple orders yet, come back tomorrow.");
    }
    public void RejectOrder(Order order) {
        WriteLine("Cannot reject order in current state.");
    }

    public void ChangePrice(Order order)
    {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        order.Price = price;
    }

    public void ChangeQuantity(Order order) {
        WriteLine("Invalid quantity sent!");
    }

    public void ChangeQuantity(Order order, int qty) {
        order.Quantity = qty;
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Executed quantity!");
        Random rnd = new Random();
        int randomQuantity = rnd.Next(1,order.Quantity);
        order.Quantity -= randomQuantity;
        order.ExecutedQuantity += randomQuantity;

        if(order.Quantity == 0)
        {
        order.State = Filled.GetInstance;
        }
    }
    public void StopOrder(Order order) {
        WriteLine("Cannot stop order in current state.");
    }
    public void CancelOrder(Order order) {
        order.State = PendingCancel.GetInstance;
    }
    public void ReplaceOrder(Order order) {
        order.State = PendingReplace.GetInstance;
    }
}