// generated from <Windows SDK Path>\um\d2d1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fd0ecb6b-91e6-411e-8655-395e760f91b4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink
    {
        // ID2D1GdiMetafileSink
        [PreserveSig]
        new HRESULT ProcessRecord(uint recordType, /* optional(void) */ IntPtr recordData, uint recordDataSize);
        
        // ID2D1GdiMetafileSink1
    }
}
