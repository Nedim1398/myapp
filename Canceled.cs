using static System.Console;

public class Canceled : IState {
    private static Canceled instance = new Canceled();

    private Canceled() { }

    public static Canceled GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StateNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePartiallyFilled(Order order){
        WriteLine("Invalid state.");
    }
    public void StateFilled(Order order){
        WriteLine("Invalid state.");
    }
    public void StateDoneForDay(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePendingCancel(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePendingReplace(Order order){
        WriteLine("Invalid state.");
    }
    public void StateCanceled(Order order){
        WriteLine("State unchanged.");
    }
    public void StateRejected(Order order){
        WriteLine("Invalid state.");
    }
    public void StateStopped(Order order){
        WriteLine("Invalid state.");
    }
}