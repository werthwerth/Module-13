using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string readText = File.ReadAllText(@"./Text1.txt");
        var rows = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        List<string> Text = new List<string>();
        var stopWatch = Stopwatch.StartNew();
        foreach(string r in rows)
        {
            Text.Append(r);
        }
        Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        stopWatch.Reset();
        stopWatch.Restart();
        LinkedList<string> Text1 = new LinkedList<string>();
        foreach (string r in rows)
        {
            Text1.AddLast(r);
        }
        Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
    }
}