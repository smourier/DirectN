// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(5767,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a724b056-1b2e-4642-a6f3-db9420c52908"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineSupportsSourceTransfer
    {
        [PreserveSig]
        HRESULT ShouldTransferSource(/* [annotation][out] _Out_ */ out bool pfShouldTransfer);
        
        [PreserveSig]
        HRESULT DetachMediaSource(/* [annotation][out] _COM_Outptr_ */ out IMFByteStream ppByteStream, /* [annotation][out] _COM_Outptr_ */ out IMFMediaSource ppMediaSource, /* [annotation][out] _COM_Outptr_ */ out IMFMediaSourceExtension ppMSE);
        
        [PreserveSig]
        HRESULT AttachMediaSource(/* [annotation][in] _In_opt_ */ IMFByteStream pByteStream, /* [annotation][in] _In_ */ IMFMediaSource pMediaSource, /* [annotation][in] _In_opt_ */ IMFMediaSourceExtension pMSE);
    }
}
