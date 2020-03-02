using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace ThreadStats
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Primary Thread stats *****\n");

            // Obtain and name the current thread.
            Thread primaryThread = CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            // Show details of hosting AppDomain/Context.
            WriteLine($"Name of current AppDomain: {GetDomain().FriendlyName}");
            WriteLine($"ID of current Context: {CurrentContext.ContextID}");

            // Print out some stats about this thread.
            WriteLine($"Thread Name: {primaryThread.Name}");
            WriteLine($"Has thread started?: {primaryThread.IsAlive}");
            WriteLine($"Priority Level: {primaryThread.Priority}");
            WriteLine($"Thread State: {primaryThread.ThreadState}");
            ReadLine();
        }
    }
}
