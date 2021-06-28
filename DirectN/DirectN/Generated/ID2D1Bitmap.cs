// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(1105,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Root bitmap resource, linearly scaled on a draw call.
    /// </summary>
    [ComImport, Guid("a2296057-ea42-4099-983b-539fb6505426"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Bitmap : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1Bitmap
        [PreserveSig]
        void GetSize(out D2D_SIZE_F size);
        
        [PreserveSig]
        void GetPixelSize(out D2D_SIZE_U size);
        
        [PreserveSig]
        void GetPixelFormat(out D2D1_PIXEL_FORMAT size);
        
        [PreserveSig]
        void GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        HRESULT CopyFromBitmap(/* optional(D2D_POINT_2U) */ IntPtr destPoint, /* _In_ */ ID2D1Bitmap bitmap, /* optional(D2D_RECT_U) */ IntPtr srcRect);
        
        [PreserveSig]
        HRESULT CopyFromRenderTarget(/* optional(D2D_POINT_2U) */ IntPtr destPoint, /* _In_ */ ID2D1RenderTarget renderTarget, /* optional(D2D_RECT_U) */ IntPtr srcRect);
        
        [PreserveSig]
        HRESULT CopyFromMemory(/* optional(D2D_RECT_U) */ IntPtr dstRect, /* _In_ */ IntPtr srcData, uint pitch);
    }
}
