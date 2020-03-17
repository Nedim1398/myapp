using static System.Console;
using System;
public class PendingCancel : IState {
    private static PendingCancel instance = new PendingCancel();

    private PendingCancel() { }

    public static PendingCancel GetInstance {
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

    }
    public void StatePendingCancel(Order order){
        WriteLine("State unchanged.");
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