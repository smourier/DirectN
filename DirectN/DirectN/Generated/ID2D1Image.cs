// generated from <Windows SDK Path>\um\d2d1.h
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
