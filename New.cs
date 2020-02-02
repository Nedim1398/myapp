using static System.Console;

public class New : IState {
    private static New instance = new New();

    private New() { }

    public static New GetInstance {
        get { return instance; }
    }

    public void RejectOrder(Order order) {
        WriteLine("Order rejected!");
        order.State = Rejected.GetInstance;
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
        throw new System.NotImplementedException();
    }

    void IState.SendNewOrder(Order order)
    {
        throw new System.NotImplementedException();
    }
}