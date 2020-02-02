using static System.Console;

public class Order
{
    public int Quantity { get; private set; }
    public int Price { get; private set; }
    private IState state;

    public IState State {
        set { state = value; }
    }

    public Order() {
        Quantity = 101;
        Price = 10;

        state = CreatingOrder.GetInstance;
    }

    public void SendNewOrder(Order order) {
        state.SendNewOrder(this);
    }

    public void RejectOrder(Order order) {
        state.RejectOrder(this);
    }

    public void ChangeQuantity(Order order, int qty) {
        order.Quantity = qty;
    }

    public override string ToString() {
        return $"State: {state} | Quantity: {Quantity} | Price: {Price} \n";
    }
}