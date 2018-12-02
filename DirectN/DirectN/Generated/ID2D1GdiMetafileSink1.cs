// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1068,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// User-implementable interface for introspecting on a metafile.
    /// </summary>
    [Guid("fd0ecb6b-91e6-411e-8655-395e760f91b4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink
    {
        // ID2D1GdiMetafileSink
        [PreserveSig]
        new HRESULT ProcessRecord(uint recordType, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object recordData, uint recordDataSize);
        
        // ID2D1GdiMetafileSink1
        [PreserveSig]
        HRESULT ProcessRecord(uint recordType, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object recordData, uint recordDataSize, uint flags);
    }
}
