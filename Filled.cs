using static System.Console;

public class Filled : IState {
    private static Filled instance = new Filled();

    private Filled() { }

    public static Filled GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StateNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePartiallyFilled(Order order){
        WriteLine("Order partially executed.");
        order.State = PartiallyFilled.GetInstance;
    }
    public void StateFilled(Order order){
        WriteLine("State unchanged.");
    }
    public void StateDoneForDay(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePendingCancel(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePendingReplace(Order order){
        WriteLine("Order pending replacement...");
        order.State = PendingReplace.GetInstance;
    }
    public void StateCanceled(Order order){
        WriteLine("Invalid state.");
    }
    public void StateRejected(Order order){
        WriteLine("Invalid state.");
    }
    public void StateStopped(Order order){
        WriteLine("Invalid state.");
    }
}