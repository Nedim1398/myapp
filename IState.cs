public interface IState {

    void SendNewOrder(Order order);
    void RejectOrder(Order order);
    void ChangeQuantity(Order order);
    void ChangeQuantity(Order order, int qty);
    void ChangePrice(Order order);
    void ChangePrice(Order order, int price);
    void ExecuteQuantity(Order order);
    void StopOrder(Order order);
    void CancelOrder(Order order);
    void ReplaceOrder(Order order);
    // void New(Order order);
    // void PartiallyFilled(Order order);
    // void Filled(Order order);
    // void DoneForDay(Order order);
    // void PendingCancel(Order order);
    // void PendingReplace(Order order);
    // void Canceled(Order order);
    // void Rejected(Order order);
    // void Stopped(Order order);

};