using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectN.Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var factory = ComObject.From(Api.CreateDXGIFactory2()))
            {
                foreach (var adapter in factory.EnumAdapters<IDXGIAdapter1>())
                {
                    Console.WriteLine(adapter);
                    adapter.Dispose();
                }
            }
        }
    }
}
