public interface IState {

    //void SendNewOrder(Order order);
    //void RejectOrder(Order order);
    //void ChangeQuantity(Order order);
    //void ChangeQuantity(Order order, int qty);
    //void ChangePrice(Order order);
    //void ChangePrice(Order order, int price);
    //void ExecuteQuantity(Order order);
    //void StopOrder(Order order);
    //void CancelOrder(Order order);
    //void ReplaceOrder(Order order);
    void StatePendingNew(Order order);
    void StateNew(Order order);
    void StatePartiallyFilled(Order order);
    void StateFilled(Order order);
    void StateDoneForDay(Order order);
    void StatePendingCancel(Order order);
    void StatePendingReplace(Order order);
    void StateCanceled(Order order);
    void StateRejected(Order order);
    void StateStopped(Order order);

};