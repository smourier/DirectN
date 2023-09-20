// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a set of vertices that form a list of triangles.
    /// </summary>
    [ComImport, Guid("2cd906c2-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Mesh : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Mesh
        [PreserveSig]
        HRESULT Open(/* _COM_Outptr_ */ out ID2D1TessellationSink tessellationSink);
    }
}
