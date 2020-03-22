using static System.Console;
using System;
public class Stopped : IState {
    private static Stopped instance = new Stopped();

    private Stopped() { }

    public static Stopped GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StateNew(Order order){
        WriteLine("Invalid state.");
    }
    public void StatePartiallyFilled(Order order){
        WriteLine("Order started again, partially executed.");
        order.State = PartiallyFilled.GetInstance;
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
        WriteLine("Invalid state.");
    }
    public void StateStopped(Order order){
        WriteLine("State unchanged.");
    }
}