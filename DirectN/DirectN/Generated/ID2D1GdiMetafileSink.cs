// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(673,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// User-implementable interface for introspecting on a metafile.
    /// </summary>
    [Guid("82237326-8111-4f7c-bcf4-b5c1175564fe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafileSink
    {
        [PreserveSig]
        HRESULT ProcessRecord(uint recordType, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object recordData, uint recordDataSize);
    }
}
