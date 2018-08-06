using System;

namespace Schukin.DataExchangeTC
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string line)
        {
            Console.WriteLine(line);
        }

        public void Write(string[] lines)
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
