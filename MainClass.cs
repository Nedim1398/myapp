using static System.Console;

class MainClass {
    static void Main(string[] args) {
        int instruction = 0;
        Order order = new Order();
        WriteLine(order);

        while(true)
        {
            WriteLine("Awaiting instruction: 0 - change quantity | 1 - send new order | 2 - reject order");
            instruction = int.Parse(ReadLine());
            switch(instruction)
            {
                case 0:
                    WriteLine("Input new quantity:");
                    int qty = int.Parse(ReadLine());
                    order.ChangeQuantity(order, qty);
                    break;
                case 1:
                    order.SendNewOrder(order);
                    break;
                case 2:
                    order.RejectOrder(order);
                    break;
                default:
                    WriteLine("Awaiting instruction...");
                    break;
            }
            WriteLine(order);
        }
    }
}