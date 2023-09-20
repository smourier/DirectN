// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Populates an ID2D1Mesh object with triangles.
    /// </summary>
    [ComImport, Guid("2cd906c1-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1TessellationSink
    {
        [PreserveSig]
        void AddTriangles(/* _In_reads_(trianglesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_TRIANGLE[] triangles, int trianglesCount);
        
        [PreserveSig]
        HRESULT Close();
    }
}
