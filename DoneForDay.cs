using static System.Console;

public class DoneForDay : IState {
    private static DoneForDay instance = new DoneForDay();

    private DoneForDay() { }

    public static DoneForDay GetInstance {
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
        WriteLine("State unchanged.");
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