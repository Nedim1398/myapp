using static System.Console;
using System;
public class PendingReplace : IState {
    private static PendingReplace instance = new PendingReplace();

    private PendingReplace() { }

    public static PendingReplace GetInstance {
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

    }
    public void StatePendingReplace(Order order){
        WriteLine("State unchanged.");
    }
    public void StateCanceled(Order order){

    }
    public void StateRejected(Order order){

    }
    public void StateStopped(Order order){

    }
}