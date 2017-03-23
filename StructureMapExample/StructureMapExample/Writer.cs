using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapExample
{
    public interface WriterInterface
    {
        void write(String text);
    }

    public class Writer: WriterInterface
    {
        public void write(String text)
        {
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
