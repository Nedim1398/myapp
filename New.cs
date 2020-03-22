using System;
using static System.Console;

public class New : IState {
    private static New instance = new New();

    private New() { }

    public static New GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StateNew(Order order){
        WriteLine("State unchanged.");
    }
    public void StatePartiallyFilled(Order order){
        WriteLine("Order partially executed.");
        order.State = PartiallyFilled.GetInstance;
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
        WriteLine("Invalid state.");
    }
    public void StateRejected(Order order){
        WriteLine("Order rejected.");
        order.State = Rejected.GetInstance;
    }
    public void StateStopped(Order order){
        WriteLine("Order stopped.");
        order.State = Stopped.GetInstance;
    }
}