// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(1370,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a bitmap that can be used as a surface for an ID2D1DeviceContext or mapped into system memory, and can contain additional color context information.
    /// </summary>
    [ComImport, Guid("a898a84c-3873-4588-b08b-ebbf978df041"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Bitmap1 : ID2D1Bitmap
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1Bitmap
        [PreserveSig]
        new void GetSize(out D2D_SIZE_F size);
        
        [PreserveSig]
        new void GetPixelSize(out D2D_SIZE_U size);
        
        [PreserveSig]
        new void GetPixelFormat(out D2D1_PIXEL_FORMAT size);
        
        [PreserveSig]
        new void GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        new HRESULT CopyFromBitmap(/* optional(D2D_POINT_2U) */ IntPtr destPoint, /* _In_ */ ID2D1Bitmap bitmap, /* optional(D2D_RECT_U) */ IntPtr srcRect);
        
        [PreserveSig]
        new HRESULT CopyFromRenderTarget(/* optional(D2D_POINT_2U) */ IntPtr destPoint, /* _In_ */ ID2D1RenderTarget renderTarget, /* optional(D2D_RECT_U) */ IntPtr srcRect);
        
        [PreserveSig]
        new HRESULT CopyFromMemory(/* optional(D2D_RECT_U) */ IntPtr dstRect, /* _In_ */ IntPtr srcData, uint pitch);
        
        // ID2D1Bitmap1
        [PreserveSig]
        void GetColorContext(/* _Outptr_result_maybenull_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        D2D1_BITMAP_OPTIONS GetOptions();
        
        [PreserveSig]
        HRESULT GetSurface(/* _COM_Outptr_result_maybenull_ */ out IDXGISurface dxgiSurface);
        
        [PreserveSig]
        HRESULT Map(D2D1_MAP_OPTIONS options, /* _Out_ */ out D2D1_MAPPED_RECT mappedRect);
        
        [PreserveSig]
        HRESULT Unmap();
    }
}
