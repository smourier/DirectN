using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICImageEncoder
    {
        [PreserveSig]
        HRESULT WriteFrame(ID2D1Image pImage, IWICBitmapFrameEncode pFrameEncode, ref WICImageParameters pImageParameters);

        [PreserveSig]
        HRESULT WriteFrameThumbnail(ID2D1Image pImage, IWICBitmapFrameEncode pFrameEncode, ref WICImageParameters pImageParameters);

        [PreserveSig]
        HRESULT WriteThumbnail(ID2D1Image pImage, IWICBitmapEncoder pEncoder, ref WICImageParameters pImageParameters);
    }
}
