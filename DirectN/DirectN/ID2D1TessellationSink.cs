using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2cd906c1-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1TessellationSink
    {
        [PreserveSig]
        void AddTriangles(D2D1_TRIANGLE[] triangles, int trianglesCount);

        [PreserveSig]
        HRESULT Close();
    }
}
