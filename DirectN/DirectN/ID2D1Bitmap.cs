using System;
using System.Runtime.InteropServices;
using D2D1_SIZE_F = DirectN.D2D_SIZE_F;
using D2D1_SIZE_U = DirectN.D2D_SIZE_U;
using D2D1_POINT_2U = DirectN.D2D_POINT_2U;
using D2D1_RECT_U = DirectN.D2D_RECT_U;

namespace DirectN
{
    [Guid("a2296057-ea42-4099-983b-539fb6505426"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Bitmap : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Image

        // ID2D1Bitmap
        [PreserveSig]
        D2D1_SIZE_F GetSize();

        [PreserveSig]
        D2D1_SIZE_U GetPixelSize();

        [PreserveSig]
        D2D1_PIXEL_FORMAT GetPixelFormat();

        [PreserveSig]
        void GetDpi(out float dpiX, out float dpiY);

        [PreserveSig]
        HRESULT CopyFromBitmap(ref D2D1_POINT_2U destPoint, ID2D1Bitmap bitmap, ref D2D1_RECT_U srcRect);

        [PreserveSig]
        HRESULT CopyFromRenderTarget(ref D2D1_POINT_2U destPoint, ID2D1RenderTarget renderTarget, ref D2D1_RECT_U srcRect);

        [PreserveSig]
        HRESULT CopyFromMemory(ref D2D1_RECT_U dstRect, IntPtr esrcData, int pitch);
    }
}
