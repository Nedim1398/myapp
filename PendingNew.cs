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
        WriteLine("Invalid state.");
    }
    public void StateRejected(Order order){
        WriteLine("Order rejected.");
        order.State = Rejected.GetInstance;
    }
    public void StateStopped(Order order){
        WriteLine("Invalid state.");
    }
    
}