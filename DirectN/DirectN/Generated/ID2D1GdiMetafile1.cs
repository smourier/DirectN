// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(1044,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface encapsulating a GDI/GDI+ metafile.
    /// </summary>
    [ComImport, Guid("2e69f9e8-dd3f-4bf9-95ba-c04f49d788df"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiMetafile1 : ID2D1GdiMetafile
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1GdiMetafile
        [PreserveSig]
        new HRESULT Stream(/* _In_ */ ID2D1GdiMetafileSink sink);
        
        [PreserveSig]
        new HRESULT GetBounds(/* _Out_ */ out D2D_RECT_F bounds);
        
        // ID2D1GdiMetafile1
        [PreserveSig]
        HRESULT GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        HRESULT GetSourceBounds(/* _Out_ */ out D2D_RECT_F bounds);
    }
}
