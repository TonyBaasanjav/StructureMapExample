using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace StructureMapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer app_container = Container.For<InstanceScanner>();
            Doctor dr = app_container.GetInstance<Doctor>();
            dr.Log();
            dr.Write();
        }
    }
}
