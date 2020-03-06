using static System.Console;
using System.Text.RegularExpressions;

public class MainClass {

    public static void Main(string[] args) {
        string instruction = "";
        Order order = new Order();
        string[] lines = System.IO.File.ReadAllLines(@"FIXLog.txt");

        WriteLine("-----------------------------Execution Report---------------------------------");
        WriteLine(order);
        WriteLine("------------------------------------------------------------------------------\n");

        //System.Console.WriteLine("Contents of touch.txt = {0}", lines);
        //searchFile(lines[0],order);
        
        for(int i = 0; i < lines.Length; ++i)
        {
        
        string fixState = Regex.Match(lines[i],@"(?<=State: ).+?(?=\|)").ToString();
        var fixQty = int.Parse(Regex.Match(lines[i],@"(?<=Quantity: ).+?(?=\|)").ToString());
        var fixExecQty = int.Parse(Regex.Match(lines[i],@"(?<=Executed Quantity: ).+?(?=\|)").ToString());
        var fixPrice = int.Parse(Regex.Match(lines[i],@"(?<=Price: ).+?(?=\|)").ToString());

        //matchSubstring = fixState.ToString().Substring(7);
        System.Console.WriteLine("State: " + fixState);
        System.Console.WriteLine("Quantity: " + fixQty);
        System.Console.WriteLine("Executed Quantity: " + fixExecQty);
        System.Console.WriteLine("Price: " + fixPrice + " <========= read from file\n");


        // TO BE IMPLEMENTED: Set the value of the order using the first line of FIXLog.txt
        order.Quantity = fixQty;
        order.ExecutedQuantity = fixExecQty;
        order.Price = fixPrice;
        
        // IDEA: Implement the validation here that values only get sent further if they changed and make sense for the specific state.
        // Will take some time and a lot of methods unless the values can be made public.
        

        /* IDEA: Pre-validation of allowed states / values allowed to change for each state.
           Make two arrays of states which can / cannot change values and exit if invalid state change.

        string[] staticStates = new string [3];
        string[] fluidStates = new String[7]

        if(order.Quantity == fixQty && order.ExecutedQuantity == fixExecQty && order.Price == fixPrice && temp[])*/

        instruction = fixState;

            switch(instruction)
            {
                case "Rejected ":
                    order.RejectOrder(order);
                    break;
                case "PendingNew ":
                    order.SendNewOrder(order);
                    break;
                case "New ":
                    order.SendNewOrder(order);
                    break;
                case "PartiallyFilled ":
                    order.ExecuteQuantity(order);
                    break;
                case "Filled ":
                    order.ExecuteQuantity(order);
                    break;
                case "Stopped ":
                    order.StopOrder(order);
                    break;
                case "PendingCancel ":
                    order.CancelOrder(order);
                    break;
                case "Canceled ":
                    order.CancelOrder(order);
                    break;
                case "PendingReplace ":
                    order.ReplaceOrder(order);
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

        /*public static void searchFile(string text,Order order) {

        var expressions = new List<string>();// (@"State.+?(?=\|)",@"Quantity.+?(?=\|)",@"ExecutedQuantity.+?(?=\|)",@"Price.+?(?=\|)");
        expressions.Add(@"State.+?(?=\|)");
        expressions.Add(@"Quantity.+?(?=\|)");
        expressions.Add(@"ExecutedQuantity.+?(?=\|)");
        expressions.Add(@"Price.+?(?=\|)");
        
        var expr = expressions.ToArray();

        string matchSubstring;
        Match match = Regex.Match(text,@"State.+?(?=\|)");
        matchSubstring = match.ToString().Substring(7);
        
        match = Regex.Match(text,@"Quantity.+?(?=\|)");
        matchSubstring = match.ToString().Substring(10);
        order.ChangeQuantity(order, int.Parse(matchSubstring));
        
        match = Regex.Match(text,@"ExecutedQuantity.+?(?=\|)");
        matchSubstring = match.ToString().Substring(18);
        order.ChangeQuantity(order, int.Parse(matchSubstring));

        match = Regex.Match(text,@"Price.+?(?=\|)");
        matchSubstring = match.ToString().Substring(7);
        order.ChangeQuantity(order, int.Parse(matchSubstring));
    }*/
}