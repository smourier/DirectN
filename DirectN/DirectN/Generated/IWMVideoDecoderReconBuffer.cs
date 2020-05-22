// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(2159,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("45bda2ac-88e2-4923-98ba-3949080711a3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMVideoDecoderReconBuffer
    {
        [PreserveSig]
        HRESULT GetReconstructedVideoFrameSize(/* [out] */ out uint pdwSize);
        
        [PreserveSig]
        HRESULT GetReconstructedVideoFrame(/* [out] */ out IMediaBuffer pBuf);
        
        [PreserveSig]
        HRESULT SetReconstructedVideoFrame(/* [in] */ IMediaBuffer pBuf);
    }
}
