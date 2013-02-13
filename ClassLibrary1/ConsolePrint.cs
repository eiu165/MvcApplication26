using System;

namespace ClassLibrary1
{
    public class ConsolePrint : IPrintable
    {
        public string PrintSomething(string toPrint)
        {
            Console.WriteLine(toPrint);
            return toPrint;
        }
    }
}