// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("04c75bf8-3ce1-473b-acc5-3cc4f5e94999"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICImageEncoder
    {
        [PreserveSig]
        HRESULT WriteFrame(/* [in] */ ID2D1Image pImage, /* [in] */ IWICBitmapFrameEncode pFrameEncode, /* [unique][in] */ IntPtr pImageParameters);
        
        [PreserveSig]
        HRESULT WriteFrameThumbnail(/* [in] */ ID2D1Image pImage, /* [in] */ IWICBitmapFrameEncode pFrameEncode, /* [unique][in] */ IntPtr pImageParameters);
        
        [PreserveSig]
        HRESULT WriteThumbnail(/* [in] */ ID2D1Image pImage, /* [in] */ IWICBitmapEncoder pEncoder, /* [unique][in] */ IntPtr pImageParameters);
    }
}
