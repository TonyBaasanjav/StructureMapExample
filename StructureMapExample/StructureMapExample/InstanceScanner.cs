using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace StructureMapExample
{
    class InstanceScanner : Registry
    {
        public InstanceScanner()
        {
            Scan(_ =>
            {
                _.TheCallingAssembly();
                _.WithDefaultConventions();
            });
            For<WriterInterface>().Use<Writer>();
        }
    }
}
