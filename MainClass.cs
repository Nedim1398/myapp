using static System.Console;
using System.Text.RegularExpressions;
using System.Reflection;

public class MainClass {

    public static void Main(string[] args) {
        string instruction = "";
        Order order = new Order();
        string[] lines = System.IO.File.ReadAllLines(@"FIXLog.txt");

        WriteLine("-----------------------------Execution Report---------------------------------");
        WriteLine(order);
        WriteLine("------------------------------------------------------------------------------\n");
        
        for(int i = 0; i < lines.Length; ++i)
        {
        
        string fixState = Regex.Match(lines[i],@"(?<=State: ).+?(?=\|)").ToString();
        var fixQty = int.Parse(Regex.Match(lines[i],@"(?<=Quantity: ).+?(?=\|)").ToString());
        var fixExecQty = int.Parse(Regex.Match(lines[i],@"(?<=Executed Quantity: ).+?(?=\|)").ToString());
        var fixPrice = int.Parse(Regex.Match(lines[i],@"(?<=Price: ).+?(?=\|)").ToString());

        
        System.Console.WriteLine("State: " + fixState);
        System.Console.WriteLine("Quantity: " + fixQty);
        System.Console.WriteLine("Executed Quantity: " + fixExecQty);
        System.Console.WriteLine("Price: " + fixPrice + " <========= read from file\n");

        order.Quantity = fixQty;
        order.ExecutedQuantity = fixExecQty;
        order.Price = fixPrice;
        instruction = fixState; // TO BE IMPLEMENTED: Set the state of the order using the first line of FIXLog.txt \\ order.state = fixState;

            switch(instruction)
            {
                case "PendingNew ":
                    order.StatePendingNew(order);
                    break;
                case "New ":
                    order.StateNew(order);
                    break;
                case "PartiallyFilled ":
                    order.StatePartiallyFilled(order);
                    break;
                case "Filled ":
                    order.StateFilled(order);
                    break;
                case "DoneForDay ":
                    order.StateDoneForDay(order);
                    break;
                case "PendingCancel ":
                    order.StatePendingCancel(order);
                    break;
                case "PendingReplace ":
                    order.StatePendingReplace(order);
                    break;
                case "Canceled ":
                    order.StateCanceled(order);
                    break;
                case "Rejected ":
                    order.StateRejected(order);
                    break;
                case "Stopped ":
                    order.StateStopped(order);
                    break;
                default:
                    WriteLine("Invalid workflow.");
                    break;
            }

        WriteLine("-----------------------------Execution Report---------------------------------");
        WriteLine(order);
        WriteLine("------------------------------------------------------------------------------\n");
            
        ReadLine();
        }
    }
}