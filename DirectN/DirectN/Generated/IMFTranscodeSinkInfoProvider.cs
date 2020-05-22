// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(16091,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8cffcd2e-5a03-4a3a-aff7-edcd107c620e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTranscodeSinkInfoProvider
    {
        [PreserveSig]
        HRESULT SetOutputFile(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFileName);
        
        [PreserveSig]
        HRESULT SetOutputByteStream(/* [annotation][in] _In_ */ IMFActivate pByteStreamActivate);
        
        [PreserveSig]
        HRESULT SetProfile(/* [annotation][in] _In_ */ IMFTranscodeProfile pProfile);
        
        [PreserveSig]
        HRESULT GetSinkInfo(/* [annotation][out] _Out_ */ out _MF_TRANSCODE_SINK_INFO pSinkInfo);
    }
}
