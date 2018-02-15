using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    public static class IDXGIFactoryExtensions
    {
        public static IEnumerable<ComObject<IDXGIAdapter>> EnumAdapters(this ComObject<IDXGIFactory> factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            int i = 0;
            do
            {
                if (factory.Object.EnumAdapters(i++, out IDXGIAdapter adapter).IsError)
                    yield break;

                yield return new ComObject<IDXGIAdapter>(adapter);
            }
            while (true);
        }
    }
}
