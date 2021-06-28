// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_2.h(62,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Encapsulates a device- and transform-dependent representation of a filled or stroked geometry.
    /// </summary>
    [ComImport, Guid("a16907d7-bc02-4801-99e8-8cf7f485f774"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GeometryRealization : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1GeometryRealization
    }
}
