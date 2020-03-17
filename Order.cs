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
        state = CreatingOrder.GetInstance;
    }

    public void StatePendingNew(Order order){
        state.StatePendingNew(this);
    }
    public void StateNew(Order order){
        state.StateNew(this);
    }
    public void StatePartiallyFilled(Order order){
        state.StatePartiallyFilled(this);
    }
    public void StateFilled(Order order){
        state.StateFilled(this);
    }
    public void StateDoneForDay(Order order){
        state.StateDoneForDay(this);
    }
    public void StatePendingCancel(Order order){
        state.StatePendingCancel(this);
    }
    public void StatePendingReplace(Order order){
        state.StatePendingReplace(this);
    }
    public void StateCanceled(Order order){
        state.StateCanceled(this);
    }
    public void StateRejected(Order order){
        state.StateRejected(this);
    }
    public void StateStopped(Order order){
        state.StateStopped(this);
    }
    public override string ToString() {
        return $"State: {state} | Quantity: {Quantity} | Executed Quantity: {ExecutedQuantity} | Price: {Price} |";
    }
}