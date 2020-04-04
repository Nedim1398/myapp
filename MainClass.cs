using static System.Console;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Linq;

public class MainClass {

    public static void Main(string[] args) {
        string instruction = "";
        Order order = new Order();

        WriteLine("-----------------------------Execution Report---------------------------------");
        WriteLine(order);
        WriteLine("------------------------------------------------------------------------------\n");
        
        var path = @"FIXLog.txt";
        var wh = new AutoResetEvent(false);
        var fsw = new FileSystemWatcher(".");
        
        fsw.Filter = "*.txt";
        fsw.EnableRaisingEvents = true;
        fsw.Changed += (o,e) => wh.Set();

        var lineCount = 0;
        var lines = "";
        
        while(!string.Equals(instruction,"LOGOUT "))
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            
            try
            {
                using (var sr = new StreamReader(fs))
                {
                    for (int i = 0; i < lineCount; i++)
                    {
                        sr.ReadLine();
                    }
                    lines = sr.ReadLine();
                }
            }
            catch (IOException e)
            {
                WriteLine("There was an error reading the file:");
                WriteLine(e.Message);
            }
        
            if (lines != null){
             //Do fix message validation

                lineCount++;

                string fixState = Regex.Match(lines,@"(?<=State: ).+?(?=\|)").ToString();
                var fixQty = int.Parse(Regex.Match(lines,@"(?<=Quantity: ).+?(?=\|)").ToString());
                var fixExecQty = int.Parse(Regex.Match(lines,@"(?<=Executed Quantity: ).+?(?=\|)").ToString());
                var fixPrice = 0;

                bool priceCheck;
                priceCheck = int.TryParse(Regex.Match(lines,@"(?<=Price: ).+?(?=\|)").ToString(),out fixPrice);

                if(!priceCheck){
                    WriteLine("Price not in correct format, setting to 0.");
                    fixPrice = 0;
                }

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

            }

            else {
                wh.WaitOne(1000);
                }
        }
        wh.Close();
    }
}