// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// User-implementable interface for introspecting on a metafile.
    /// </summary>
    [ComImport, Guid("82237326-8111-4f7c-bcf4-b5c1175564fe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafileSink
    {
        [PreserveSig]
        HRESULT ProcessRecord(uint recordType, /* optional(void) */ IntPtr recordData, uint recordDataSize);
    }
}
