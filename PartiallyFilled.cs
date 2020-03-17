using System;
using static System.Console;

public class PartiallyFilled : IState {
    private static PartiallyFilled instance = new PartiallyFilled();

    private PartiallyFilled() { }

    public static PartiallyFilled GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        
    }
    public void StateNew(Order order){

    }
    public void StatePartiallyFilled(Order order){
        WriteLine("State unchanged.");
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

    }
    public void StateStopped(Order order){

    }
}