// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\spatialaudiometadata.h(1066,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ddea49ff-3bc0-4377-8aad-9fbcfd808566"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectForMetadataItems : ISpatialAudioObjectBase
    {
        // ISpatialAudioObjectBase
        [PreserveSig]
        new HRESULT GetBuffer(/* [annotation][size_is][size_is][out] _Outptr_result_bytebuffer_(*bufferLength) */ out IntPtr buffer, /* [annotation][out] _Out_ */ out uint bufferLength);
        
        [PreserveSig]
        new HRESULT SetEndOfStream(/* [annotation][in] _In_ */ uint frameCount);
        
        [PreserveSig]
        new HRESULT IsActive(/* [annotation][out] _Out_ */ out bool isActive);
        
        [PreserveSig]
        new HRESULT GetAudioObjectType(/* [annotation][out] _Out_ */ out AudioObjectType audioObjectType);
        
        // ISpatialAudioObjectForMetadataItems
        [PreserveSig]
        HRESULT GetSpatialAudioMetadataItems(/* [annotation][out] _Outptr_result_nullonfailure_ */ out ISpatialAudioMetadataItems metadataItems);
    }
}
