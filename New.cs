using System;
using static System.Console;

public class New : IState {
    private static New instance = new New();

    private New() { }

    public static New GetInstance {
        get { return instance; }
    }

    public void SendNewOrder(Order order) {
        WriteLine("MiniTradeMind does not support multiple orders yet, come back tomorrow.");
    }
    public void RejectOrder(Order order) {
        WriteLine("Order rejected!");
        order.State = Rejected.GetInstance;
    }

    public void ChangeQuantity(Order order) {
        WriteLine("Invalid quantity sent!");
    }

    public void ChangeQuantity(Order order, int qty) {
        order.Quantity = qty;
    }

    public void ChangePrice(Order order) {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        order.Price = price;
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Executed quantity!");

        

        order.State = PartiallyFilled.GetInstance;

        
        /*Random rnd = new Random();
        int randomQuantity = rnd.Next(1,order.Quantity);
        
        order.Quantity -= randomQuantity;
        order.ExecutedQuantity += randomQuantity;*/
        

    }
    public void StopOrder(Order order) {
        order.State = Stopped.GetInstance;
    }
    public void CancelOrder(Order order) {
        order.State = PendingCancel.GetInstance;
    }
    public void ReplaceOrder(Order order) {
        order.State = PendingReplace.GetInstance;
    }
}