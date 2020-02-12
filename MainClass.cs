using static System.Console;

class MainClass {
    static void Main(string[] args) {
        int instruction = 0;
        Order order = new Order();
        WriteLine("-----------------------------Execution Report---------------------------------");
        WriteLine(order);
        WriteLine("------------------------------------------------------------------------------\n");
        while(true)
        {
            WriteLine("Instruction: 0 - reject | 1 - send order (PendingNew/New) | 2 - change QTY | 3 - change Px | 4 - partially execute | 5 - stop | 6 - cancel | 7 - replace");
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
                    order.StopOrder(order);
                    break;
                case 6:
                    order.CancelOrder(order);
                    break;
                case 7:
                    order.ReplaceOrder(order);
                    break;
                default:
                    WriteLine("Invalid instruction.");
                    break;
            }
            WriteLine("-----------------------------Execution Report---------------------------------");
            WriteLine(order);
            WriteLine("------------------------------------------------------------------------------\n");
        }
    }
}