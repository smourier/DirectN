using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2cd90691-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Resource
    {
        [PreserveSig]
        void GetFactory(out ID2D1Factory factory);
    }
}
