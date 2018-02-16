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
                    Console.WriteLine(adapter.GetDesc().SharedSystemMemory);
                    DumpStruct(adapter.GetDesc());
                    adapter.Dispose();
                }
            }
        }

        static void DumpStruct(object obj)
        {
            Console.WriteLine(new StructTableString(obj).WriteObject());
        }
    }
}
