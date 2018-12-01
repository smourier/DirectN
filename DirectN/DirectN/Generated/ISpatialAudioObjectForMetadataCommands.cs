// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\spatialaudiometadata.h(941,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0df2c94b-f5f9-472d-af6b-c46e0ac9cd05"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectForMetadataCommands : ISpatialAudioObjectBase
    {
        // ISpatialAudioObjectBase
        [PreserveSig]
        new HRESULT GetBuffer(/* [annotation][size_is][size_is][out] _Outptr_result_bytebuffer_(*bufferLength) */ out byte[] buffer, /* [annotation][out] _Out_ */ out uint bufferLength);
        
        [PreserveSig]
        new HRESULT SetEndOfStream(/* [annotation][in] _In_ */ uint frameCount);
        
        [PreserveSig]
        new HRESULT IsActive(/* [annotation][out] _Out_ */ out bool isActive);
        
        [PreserveSig]
        new HRESULT GetAudioObjectType(/* [annotation][out] _Out_ */ out AudioObjectType audioObjectType);
        
        // ISpatialAudioObjectForMetadataCommands
        [PreserveSig]
        HRESULT WriteNextMetadataCommand(/* [annotation][in] _In_ */ byte commandID, /* [annotation][size_is][in] _In_reads_bytes_opt_(valueBufferLength) */ out IntPtr valueBuffer, /* [annotation][in] _In_ */ uint valueBufferLength);
    }
}
