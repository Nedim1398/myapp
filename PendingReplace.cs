using static System.Console;
using System;
public class PendingReplace : IState {
    private static PendingReplace instance = new PendingReplace();

    private PendingReplace() { }

    public static PendingReplace GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StateNew(Order order){
        WriteLine("Order replaced!");
        order.State = New.GetInstance;
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
        WriteLine("Invalid state.");
    }
    public void StatePendingCancel(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePendingReplace(Order order){
        WriteLine("State unchanged.");
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