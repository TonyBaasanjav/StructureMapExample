using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace StructureMapExample
{
    public interface ILogger
    {
        void Log(String text);
    }

    public class Logger : ILogger
    {
        public void Log(String text)
        {
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
