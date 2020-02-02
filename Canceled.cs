using static System.Console;

public class Canceled : IState {
    private static Canceled instance = new Canceled();

    private Canceled() { }

    public static Canceled GetInstance {
        get { return instance; }
    }

    void IState.ChangePrice(Order order)
    {
        throw new System.NotImplementedException();
    }

    void IState.ChangeQuantity(Order order)
    {
        throw new System.NotImplementedException();
    }

    void IState.RejectOrder(Order order)
    {
        throw new System.NotImplementedException();
    }

    void IState.SendNewOrder(Order order)
    {
        throw new System.NotImplementedException();
    }

    // public void New(Order order) {
    //     WriteLine("!");
    //     order.State = New.GetInstance;
    // }

    // public void GotFireFlower(Mario mario) {
    //     WriteLine("Got FireFlower!");
    //     mario.State = FireMario.GetInstance; 
    //     mario.GotCoins(200);
    // }

    // public void GotFeather(Mario mario) {
    //     WriteLine("Got Feather!");
    //     mario.State = CapeMario.GetInstance;
    //     mario.GotCoins(300);
    // }

    // public void MetMonster(Mario mario) {
    //     WriteLine("Met Monster!");
    //     mario.State = SmallMario.GetInstance;
    //     mario.LostLife();
    // }
}