using static System.Console;

public class Canceled : IState {
    private static Canceled instance = new Canceled();

    private Canceled() { }

    public static Canceled GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        
    }
    public void StateNew(Order order){

    }
    public void StatePartiallyFilled(Order order){

    }
    public void StateFilled(Order order){

    }
    public void StateDoneForDay(Order order){

    }
    public void StatePendingCancel(Order order){

    }
    public void StatePendingReplace(Order order){

    }
    public void StateCanceled(Order order){
        WriteLine("State unchanged.");
    }
    public void StateRejected(Order order){

    }
    public void StateStopped(Order order){

    }
}