// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A base object which can be inserted into a transform graph.
    /// </summary>
    [ComImport, Guid("b2efe1e7-729f-4102-949f-505fa21bf666"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1TransformNode
    {
        [PreserveSig]
        uint GetInputCount();
    }
}
