// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(3758,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("04c75bf8-3ce1-473b-acc5-3cc4f5e94999"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICImageEncoder
    {
        [PreserveSig]
        HRESULT WriteFrame(/* [in] */ ID2D1Image pImage, /* [in] */ IWICBitmapFrameEncode pFrameEncode, /* [unique][in] */ ref WICImageParameters pImageParameters);
        
        [PreserveSig]
        HRESULT WriteFrameThumbnail(/* [in] */ ID2D1Image pImage, /* [in] */ IWICBitmapFrameEncode pFrameEncode, /* [unique][in] */ ref WICImageParameters pImageParameters);
        
        [PreserveSig]
        HRESULT WriteThumbnail(/* [in] */ ID2D1Image pImage, /* [in] */ IWICBitmapEncoder pEncoder, /* [unique][in] */ ref WICImageParameters pImageParameters);
    }
}
