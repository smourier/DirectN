// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(1105,1)
using System;
using System.Runtime.InteropServices;
using D2D1_POINT_2U = DirectN.D2D_POINT_2U;
using D2D1_RECT_U = DirectN.D2D_RECT_U;
using D2D1_SIZE_F = DirectN.D2D_SIZE_F;
using D2D1_SIZE_U = DirectN.D2D_SIZE_U;

namespace DirectN
{
    /// <summary>
    /// Root bitmap resource, linearly scaled on a draw call.
    /// </summary>
    [Guid("a2296057-ea42-4099-983b-539fb6505426"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Bitmap : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1Bitmap
        [PreserveSig]
        D2D1_SIZE_F GetSize();
        
        [PreserveSig]
        D2D1_SIZE_U GetPixelSize();
        
        [PreserveSig]
        D2D1_PIXEL_FORMAT GetPixelFormat();
        
        [PreserveSig]
        void GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        HRESULT CopyFromBitmap(/* optional(D2D1_POINT_2U) */ IntPtr destPoint, /* _In_ */ ID2D1Bitmap bitmap, /* optional(D2D1_RECT_U) */ IntPtr srcRect);
        
        [PreserveSig]
        HRESULT CopyFromRenderTarget(/* optional(D2D1_POINT_2U) */ IntPtr destPoint, /* _In_ */ ID2D1RenderTarget renderTarget, /* optional(D2D1_RECT_U) */ IntPtr srcRect);
        
        [PreserveSig]
        HRESULT CopyFromMemory(/* optional(D2D1_RECT_U) */ IntPtr dstRect, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object srcData, uint pitch);
    }
}
