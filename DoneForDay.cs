using static System.Console;

public class DoneForDay : IState {
    private static DoneForDay instance = new DoneForDay();

    private DoneForDay() { }

    public static DoneForDay GetInstance {
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
        WriteLine("Invalid state.");
    }
    public void StateDoneForDay(Order order){
        WriteLine("State unchanged.");
    }
    public void StatePendingCancel(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePendingReplace(Order order){
        WriteLine("Invalid state.");
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