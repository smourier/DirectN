// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8cffcd2e-5a03-4a3a-aff7-edcd107c620e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
