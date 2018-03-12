using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2cd906c2-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Mesh : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Mesh
        [PreserveSig]
        HRESULT Open(out ID2D1TessellationSink tessellationSink);
    }
}
