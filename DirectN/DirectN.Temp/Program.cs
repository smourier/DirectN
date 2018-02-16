using System;
using System.Collections.Generic;
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
            using (var factory = ComObject.From(Api.CreateDXGIFactory5()))
            {
                foreach (var adapter in factory.EnumAdapters<IDXGIAdapter4>())
                {
                    Console.WriteLine(adapter.GetDesc().Description);
                    DumpStruct(0, adapter.GetDesc3());
                    foreach (var output in adapter.EnumOutputs<IDXGIOutput6>())
                    {
                        DumpStruct(1, output.GetDesc1());
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
