// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1044,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface encapsulating a GDI/GDI+ metafile.
    /// </summary>
    [Guid("2e69f9e8-dd3f-4bf9-95ba-c04f49d788df"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafile1
    {
        [PreserveSig]
        HRESULT GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        HRESULT GetSourceBounds(/* _Out_ */ out D2D_RECT_F bounds);
    }
}
