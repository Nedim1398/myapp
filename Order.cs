using static System.Console;

public class Order
{
    public int Quantity { get; set; }
    public int ExecutedQuantity { get; set; }
    public int Price { get; set; }
    private IState state;

    public IState State {
        set { state = value; }
    }

    public Order() {
        Quantity = 0;
        ExecutedQuantity = 0;
        Price = 0;
        state = PendingNew.GetInstance;
    }

    public void SendNewOrder(Order order) {
        state.SendNewOrder(this);
    }

    public void RejectOrder(Order order) {
        state.RejectOrder(this);
    }

    public void ChangeQuantity(Order order) {
        state.ChangeQuantity(this);
    }
    public void ChangeQuantity(Order order, int qty) {
        state.ChangeQuantity(this, qty);
    }

    public void ChangePrice(Order order) {
        state.ChangePrice(this);
    }
    public void ChangePrice(Order order, int price) {
        state.ChangePrice(this, price);
    }

    public void ExecuteQuantity(Order order) {
        state.ExecuteQuantity(this);
    }
    public void StopOrder(Order order) {
        state.StopOrder(this);
    }
    public void CancelOrder(Order order) {
        state.CancelOrder(this);
    }
    public void ReplaceOrder(Order order) {
        state.ReplaceOrder(this);
    }
    public override string ToString() {
        return $"State: {state} | Quantity: {Quantity} | Executed Quantity: {ExecutedQuantity} | Price: {Price} |";
    }
}