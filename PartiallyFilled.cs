using System;
using static System.Console;

public class PartiallyFilled : IState {
    private static PartiallyFilled instance = new PartiallyFilled();

    private PartiallyFilled() { }

    public static PartiallyFilled GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StateNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePartiallyFilled(Order order){
        WriteLine("State unchanged.");
    }
    public void StateFilled(Order order){
        WriteLine("Order fully filled.");
        order.State = Filled.GetInstance;
    }
    public void StateDoneForDay(Order order){
        WriteLine("Order done for day.");
        order.State = DoneForDay.GetInstance;
    }
    public void StatePendingCancel(Order order){
        WriteLine("Order pending cancellation...");
        order.State = PendingCancel.GetInstance;
    }
    public void StatePendingReplace(Order order){
        WriteLine("Order pending replacement...");
        order.State = PendingReplace.GetInstance;
    }
    public void StateCanceled(Order order){
        WriteLine("Order has been cancelled.");
        order.State = Canceled.GetInstance;
    }
    public void StateRejected(Order order){
        WriteLine("Invalid state.");
    }
    public void StateStopped(Order order){
        WriteLine("Invalid state.");
    }
}