using static System.Console;

public class PendingNew : IState {
    private static PendingNew instance = new PendingNew();

    private PendingNew() { }

    public static PendingNew GetInstance {
        get { return instance; }
    }
    public void SendNewOrder(Order order)
    {
        if(order.Quantity.Equals(101))order.RejectOrder(order);
        else
        {
        WriteLine("Order sent!");
        order.State = New.GetInstance;
        }
    }

    public void RejectOrder(Order order)
    {
        WriteLine("Quantity does not respect lot size!");
        order.State = Rejected.GetInstance;
    }

    void IState.ChangeQuantity(Order order)
    {
        throw new System.NotImplementedException();
    }

    void IState.ChangePrice(Order order)
    {
        throw new System.NotImplementedException();
    }
}