// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(690,1)
using System;
using System.Runtime.InteropServices;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    /// <summary>
    /// Interface encapsulating a GDI/GDI+ metafile.
    /// </summary>
    [Guid("2f543dc3-cfc1-4211-864f-cfd91c6f3395"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafile
    {
        [PreserveSig]
        HRESULT Stream(/* _In_ */ ID2D1GdiMetafileSink sink);
        
        [PreserveSig]
        HRESULT GetBounds(/* _Out_ */ out D2D1_RECT_F bounds);
    }
}
