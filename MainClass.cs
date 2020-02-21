using static System.Console;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class MainClass {

    public static void searchFile(string text,Order order) {

        /*var expressions = new List<string>();// (@"State.+?(?=\|)",@"Quantity.+?(?=\|)",@"ExecutedQuantity.+?(?=\|)",@"Price.+?(?=\|)");
        expressions.Add(@"State.+?(?=\|)");
        expressions.Add(@"Quantity.+?(?=\|)");
        expressions.Add(@"ExecutedQuantity.+?(?=\|)");
        expressions.Add(@"Price.+?(?=\|)");
        
        var expr = expressions.ToArray();*/

        string matchSubstring;
        Match match = Regex.Match(text,@"State.+?(?=\|)");
        matchSubstring = match.ToString().Substring(7);
        
        /*match = Regex.Match(text,@"Quantity.+?(?=\|)");
        matchSubstring = match.ToString().Substring(10);
        order.ChangeQuantity(order, int.Parse(matchSubstring));
        
        match = Regex.Match(text,@"ExecutedQuantity.+?(?=\|)");
        matchSubstring = match.ToString().Substring(18);
        order.ChangeQuantity(order, int.Parse(matchSubstring));

        match = Regex.Match(text,@"Price.+?(?=\|)");
        matchSubstring = match.ToString().Substring(7);
        order.ChangeQuantity(order, int.Parse(matchSubstring));*/
    }

    public static void Main(string[] args) {
        string instruction = "";
        Order order = new Order();
        string[] lines = System.IO.File.ReadAllLines(@"test.txt");
        
        //System.Console.WriteLine("Contents of touch.txt = {0}", lines);
        //searchFile(lines[0],order);
        string matchSubstring;
        Match match = Regex.Match(lines[0],@"State.+?(?=\|)");
        matchSubstring = match.ToString().Substring(7);
        System.Console.WriteLine(matchSubstring + " <========= read from file");
        WriteLine("-----------------------------Execution Report---------------------------------");
        WriteLine(order);
        WriteLine("------------------------------------------------------------------------------\n");
        while(true)
        {
            //WriteLine("Instruction: 0 - reject | 1 - send order (PendingNew/New) | 2 - change QTY | 3 - change Px | 4 - partially execute | 5 - stop | 6 - cancel | 7 - replace");
            instruction = matchSubstring;
            //if(!isNumeric) instruction = 666;
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
                case "Stopped ":
                    order.StopOrder(order);
                    break;
                case "PendingCancel ":
                    order.CancelOrder(order);
                    break;
                case "PendingReplace ":
                    order.ReplaceOrder(order);
                    break;
                default:
                    WriteLine("Invalid instruction.");
                    break;
            }
            WriteLine("-----------------------------Execution Report---------------------------------");
            WriteLine(order);
            WriteLine("------------------------------------------------------------------------------\n");
            
            ReadLine();
        }
    }
}