using static System.Console;
using System;
public class Stopped : IState {
    private static Stopped instance = new Stopped();

    private Stopped() { }

    public static Stopped GetInstance {
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
        WriteLine("Order stopped, cannot reject.");
    }

    public void ChangeQuantity(Order order)
    {
        WriteLine("Invalid quantity sent!");
    }

    public void ChangeQuantity(Order order, int qty) {
        WriteLine("Order stopped, cannot amend.");
    }

        public void ChangePrice(Order order)
    {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        WriteLine("Order stopped, cannot amend.");
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Executed some quantity, order has been started again!");
        Random rnd = new Random();
        int randomQuantity = rnd.Next(1,order.Quantity)-1;
        order.Quantity -= randomQuantity;
        order.ExecutedQuantity += randomQuantity;
        order.State = PartiallyFilled.GetInstance;
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