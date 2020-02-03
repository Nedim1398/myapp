using static System.Console;

class MainClass {
    static void Main(string[] args) {
        int instruction = 0;
        Order order = new Order();
        WriteLine(order);

        while(true)
        {
            WriteLine("Awaiting instruction: 0 - reject order | 1 - send order (PendingNew/New) | 2 - change quantity | 3 - change price | 4 - partially execute | 5 - request cancel | 6 - cancel");
            var isNumeric = int.TryParse(ReadLine(),out instruction);
            if(!isNumeric) instruction = 666;
            switch(instruction)
            {
                case 0:
                    order.RejectOrder(order);
                    break;
                case 1:
                    order.SendNewOrder(order);
                    break;
                case 2:
                    WriteLine("Input new quantity:");
                    isNumeric = int.TryParse(ReadLine(),out int qty);
                    if(isNumeric && qty > 0)order.ChangeQuantity(order, qty);
                    else order.ChangeQuantity(order);
                    break;
                case 3:
                    WriteLine("Input new price:");
                    isNumeric = int.TryParse(ReadLine(),out int price);
                    if(isNumeric)order.ChangePrice(order, price);
                    else order.ChangePrice(order);
                    break;
                case 4:
                    order.ExecuteQuantity(order);
                    break;
                case 5:
                    //order.State = PendingCancel.GetInstance;
                    break;
                default:
                    WriteLine("Invalid instruction.");
                    break;
            }
            WriteLine("-----------------------------Execution Report---------------------------------");
            WriteLine(order);
            WriteLine("------------------------------------------------------------------------------");
        }
    }
}