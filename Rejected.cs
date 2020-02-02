using static System.Console;

public class Rejected : IState {
    private static Rejected instance = new Rejected();

    private Rejected() { }

    public static Rejected GetInstance {
        get { return instance; }
    }

    void IState.ChangePrice(Order order)
    {
        throw new System.NotImplementedException();
    }

    void IState.ChangeQuantity(Order order)
    {
        throw new System.NotImplementedException();
    }

    void IState.RejectOrder(Order order)
    {
        WriteLine("Order already rejected. Please create a new one.");
    }

    void IState.SendNewOrder(Order order)
    {
        WriteLine("Order has been reset, please input new parameters.");
        order.ChangeQuantity(order, 0);
        order.State = CreatingOrder.GetInstance;
    }
}