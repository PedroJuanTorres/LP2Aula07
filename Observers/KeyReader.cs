using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class KeyReader : AbstractStringSubject
    {
        public void ReadKeys()
        {
            ConsoleKey key;

            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Escape)
            {
                Item = key.ToString();
            }
        }
    }
}