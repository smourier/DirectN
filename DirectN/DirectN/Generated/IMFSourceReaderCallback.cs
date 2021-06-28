// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfreadwrite.h(889,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("deec8d99-fa1d-4d82-84c2-2c8969944867"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceReaderCallback
    {
        [PreserveSig]
        HRESULT OnReadSample(/* [annotation][in] _In_ */ HRESULT hrStatus, /* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwStreamFlags, /* [annotation][in] _In_ */ long llTimestamp, /* [annotation][in] _In_opt_ */ IMFSample pSample);
        
        [PreserveSig]
        HRESULT OnFlush(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        HRESULT OnEvent(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IMFMediaEvent pEvent);
    }
}
