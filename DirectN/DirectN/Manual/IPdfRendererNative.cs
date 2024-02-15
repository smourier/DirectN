using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7d9dcd91-d277-4947-8527-07a0daeda94a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPdfRendererNative
    {
        [PreserveSig]
        HRESULT RenderPageToSurface(IntPtr pdfPage, IDXGISurface pSurface, tagPOINT offset, IntPtr pRenderParams);

        [PreserveSig]
        HRESULT RenderPageToDeviceContext(IntPtr pdfPage, ID2D1DeviceContext pD2DDeviceContext, IntPtr pRenderParams);
    }
}
