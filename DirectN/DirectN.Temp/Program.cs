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
            using (var factory = ComObject.From(Api.CreateDXGIFactory<IDXGIFactory2>()))
            {
                Console.WriteLine(factory);
                int i = 0;
                do
                {
                    if (factory.Object.EnumAdapters(i++, out IDXGIAdapter adapter).IsError)
                        break;

                    Console.WriteLine(adapter);
                }
                while (true);
            }
        }
    }
}
