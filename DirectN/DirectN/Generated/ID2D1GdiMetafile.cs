// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(690,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface encapsulating a GDI/GDI+ metafile.
    /// </summary>
    [ComImport, Guid("2f543dc3-cfc1-4211-864f-cfd91c6f3395"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafile : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1GdiMetafile
        [PreserveSig]
        HRESULT Stream(/* _In_ */ ID2D1GdiMetafileSink sink);
        
        [PreserveSig]
        HRESULT GetBounds(/* _Out_ */ out D2D_RECT_F bounds);
    }
}
