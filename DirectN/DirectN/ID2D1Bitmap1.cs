using System;
using System.Runtime.InteropServices;
using D2D1_SIZE_F = DirectN.D2D_SIZE_F;
using D2D1_SIZE_U = DirectN.D2D_SIZE_U;
using D2D1_POINT_2U = DirectN.D2D_POINT_2U;
using D2D1_RECT_U = DirectN.D2D_RECT_U;

namespace DirectN
{
    [Guid("a898a84c-3873-4588-b08b-ebbf978df041"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Bitmap1 : ID2D1Bitmap
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Image

        // ID2D1Bitmap
        [PreserveSig]
        new D2D1_SIZE_F GetSize();

        [PreserveSig]
        new D2D1_SIZE_U GetPixelSize();

        [PreserveSig]
        new D2D1_PIXEL_FORMAT GetPixelFormat();

        [PreserveSig]
        new void GetDpi(out float dpiX, out float dpiY);

        [PreserveSig]
        new HRESULT CopyFromBitmap(ref D2D1_POINT_2U destPoint, ID2D1Bitmap bitmap, ref D2D1_RECT_U srcRect);

        [PreserveSig]
        new HRESULT CopyFromRenderTarget(ref D2D1_POINT_2U destPoint, ID2D1RenderTarget renderTarget, ref D2D1_RECT_U srcRect);

        [PreserveSig]
        new HRESULT CopyFromMemory(ref D2D1_RECT_U dstRect, IntPtr esrcData, int pitch);

        // ID2D1Bitmap1
        [PreserveSig]
        void GetColorContext(out ID2D1ColorContext colorContext);

        [PreserveSig]
        D2D1_BITMAP_OPTIONS GetOptions();

        [PreserveSig]
        HRESULT GetSurface(out IDXGISurface dxgiSurface);

        [PreserveSig]
        HRESULT Map(D2D1_MAP_OPTIONS options, out D2D1_MAPPED_RECT mappedRect);

        [PreserveSig]
        HRESULT Unmap();
    }
}
