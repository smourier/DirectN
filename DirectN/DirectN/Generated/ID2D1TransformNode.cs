// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(584,1)
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
