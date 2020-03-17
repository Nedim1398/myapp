using static System.Console;

public class Filled : IState {
    private static Filled instance = new Filled();

    private Filled() { }

    public static Filled GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        
    }
    public void StateNew(Order order){

    }
    public void StatePartiallyFilled(Order order){

    }
    public void StateFilled(Order order){
        WriteLine("State unchanged.");
    }
    public void StateDoneForDay(Order order){

    }
    public void StatePendingCancel(Order order){

    }
    public void StatePendingReplace(Order order){

    }
    public void StateCanceled(Order order){

    }
    public void StateRejected(Order order){

    }
    public void StateStopped(Order order){

    }
}