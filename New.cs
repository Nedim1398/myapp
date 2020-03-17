using System;
using static System.Console;

public class New : IState {
    private static New instance = new New();

    private New() { }

    public static New GetInstance {
        get { return instance; }
    }

    public void StatePendingNew(Order order){
        
    }
    public void StateNew(Order order){
        WriteLine("State unchanged.");
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

    }
    public void StateCanceled(Order order){

    }
    public void StateRejected(Order order){

    }
    public void StateStopped(Order order){

    }
}