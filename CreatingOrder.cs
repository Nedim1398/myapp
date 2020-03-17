using static System.Console;

public class CreatingOrder : IState {
    private static CreatingOrder instance = new CreatingOrder();

    private CreatingOrder() { }

    public static CreatingOrder GetInstance {
        get { return instance; }
    }
    public void StatePendingNew(Order order){
        order.State = PendingNew.GetInstance;
    }
    public void StateNew(Order order){
        order.State = New.GetInstance;
    }
    public void StatePartiallyFilled(Order order){
        order.State = PartiallyFilled.GetInstance;
    }
    public void StateFilled(Order order){
        order.State = Filled.GetInstance;
    }
    public void StateDoneForDay(Order order){
        order.State = DoneForDay.GetInstance;
    }
    public void StatePendingCancel(Order order){
        order.State = PendingCancel.GetInstance;
    }
    public void StatePendingReplace(Order order){
        order.State = PendingReplace.GetInstance;
    }
    public void StateCanceled(Order order){
        order.State = Canceled.GetInstance;
    }
    public void StateRejected(Order order){
        order.State = Rejected.GetInstance;
    }
    public void StateStopped(Order order){
        order.State = Stopped.GetInstance;
    }
}