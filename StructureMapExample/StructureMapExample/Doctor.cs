using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapExample
{
    public class Doctor
    {
        public ILogger logger;
        public WriterInterface writer;
        public Doctor(ILogger l, WriterInterface w)
        {
            logger = l;
            writer = w;
        }

        public void Log()
        {
            logger.Log("Doctor logging");
        }

        public void Write()
        {
            writer.write("Doctor writing");
        }
    }
}
