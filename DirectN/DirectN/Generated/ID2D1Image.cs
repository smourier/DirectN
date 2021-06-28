// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(1097,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a producer of pixels that can fill an arbitrary 2D plane.
    /// </summary>
    [ComImport, Guid("65019f75-8da2-497c-b32c-dfa34e48ede6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Image : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
    }
}
