// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(783,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A container for 3D lookup table data that can be passed to the LookupTable3D effect.
    /// </summary>
    [ComImport, Guid("53dd9855-a3b0-4d5b-82e1-26e25c5e5797"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1LookupTable3D : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1LookupTable3D
    }
}
