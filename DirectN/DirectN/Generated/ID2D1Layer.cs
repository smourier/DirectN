using System;
using System.Runtime.InteropServices;
using D2D1_SIZE_F = DirectN.D2D_SIZE_F;

namespace DirectN
{
    [Guid("2cd9069b-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Layer : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Layer
        [PreserveSig]
        D2D1_SIZE_F GetSize();
    }
}
