using static System.Console;
using System;
public class PendingReplace : IState {
    private static PendingReplace instance = new PendingReplace();

    private PendingReplace() { }

    public static PendingReplace GetInstance {
        get { return instance; }
    }

    public void SendNewOrder(Order order)
    {
        WriteLine("Order will be replaced, please input new parameters.");
        
        WriteLine("Input new quantity:");
            var isNumeric = int.TryParse(ReadLine(),out int qty);
            if(isNumeric && qty > 0) order.Quantity = qty;
            else order.ChangeQuantity(order);
        WriteLine("Input new price:");
            isNumeric = int.TryParse(ReadLine(),out int price);
            if(isNumeric) order.Price = price;
            else order.ChangePrice(order);
        
        order.ExecutedQuantity = 0;
        if(order.Quantity == qty && order.Price == price) order.State = New.GetInstance;
    }

    public void RejectOrder(Order order)
    {
        WriteLine("Order pending replacement, cannot reject.");
    }

    public void ChangeQuantity(Order order)
    {
        WriteLine("Invalid quantity sent!");
    }

    public void ChangeQuantity(Order order, int qty) {
        WriteLine("Order pending replacement, cannot amend.");
    }

        public void ChangePrice(Order order)
    {
        WriteLine("Invalid price sent!");
    }
    public void ChangePrice(Order order, int price) {
        WriteLine("Order pending replacement, cannot amend.");
    }
    public void ExecuteQuantity(Order order) {
        WriteLine("Executed quantity!");
        Random rnd = new Random();
        int randomQuantity = rnd.Next(1,order.Quantity);
        
        order.Quantity -= randomQuantity;
        order.ExecutedQuantity += randomQuantity;
        order.State = PartiallyFilled.GetInstance;
    }
    public void StopOrder(Order order) {
        WriteLine("Cannot stop order in current state.");
    }
    public void CancelOrder(Order order) {
        order.State = Canceled.GetInstance;
    }
    public void ReplaceOrder(Order order) {
        order.State = PendingReplace.GetInstance;
    }
}