using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlNado.Utilities;

namespace DirectN.Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Debugger.IsAttached)
            {
                SafeMain(args);
                return;
            }

            try
            {
                SafeMain(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void SafeMain(string[] args)
        {
            using (var factory = Functions.CreateDXGIFactory5())
            {
                foreach (var adapter in factory.EnumAdapters<IDXGIAdapter4>())
                {
                    Console.WriteLine(adapter.GetDesc().Description);
                    DumpStruct(0, adapter.GetDesc3());
                    foreach (var output in adapter.EnumOutputs<IDXGIOutput6>())
                    {
                        output.DuplicateOutput(adapter);
                        //DumpStruct(1, output.GetDesc1());
                        //DumpStruct(1, output.GetGammaControl());
                        //DumpStruct(1, output.GetGammaControlCapabilities());
                        //DumpStruct(1, output.GetFrameStatistics());
                        output.Dispose();
                    }
                    adapter.Dispose();
                }
            }
        }

        static void DumpStruct(int indent, object obj)
        {
            Console.WriteLine(new StructTableString(obj) { Indent = indent }.WriteObject());
        }
    }
}
