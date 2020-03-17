using static System.Console;

public class PendingNew : IState {
    private static PendingNew instance = new PendingNew();

    private PendingNew() { }

    public static PendingNew GetInstance {
        get { return instance; }
    }
    
    
    public void StatePendingNew(Order order){
        WriteLine("State unchanged.");
    }
    public void StateNew(Order order){
        WriteLine("Order sent!");
        order.State = New.GetInstance;
    }
    public void StatePartiallyFilled(Order order){
        WriteLine("Invalid state.");
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

    }
    public void StateRejected(Order order){
        WriteLine("Order rejected.");
        order.State = Rejected.GetInstance;
    }
    public void StateStopped(Order order){

    }
    
}