// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\spatialaudiometadata.h(1183,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bbc9c907-48d5-4a2e-a0c7-f7f0d67c1fb1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectRenderStreamForMetadata : ISpatialAudioObjectRenderStreamBase
    {
        // ISpatialAudioObjectRenderStreamBase
        [PreserveSig]
        new HRESULT GetAvailableDynamicObjectCount(/* [annotation][out] _Out_ */ out uint value);
        
        [PreserveSig]
        new HRESULT GetService(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object service);
        
        [PreserveSig]
        new HRESULT Start();
        
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Reset();
        
        [PreserveSig]
        new HRESULT BeginUpdatingAudioObjects(/* [annotation][out] _Out_ */ out uint availableDynamicObjectCount, /* [annotation][out] _Out_ */ out uint frameCountPerBuffer);
        
        [PreserveSig]
        new HRESULT EndUpdatingAudioObjects();
        
        // ISpatialAudioObjectRenderStreamForMetadata
        [PreserveSig]
        HRESULT ActivateSpatialAudioObjectForMetadataCommands(/* [annotation][in] _In_ */ AudioObjectType type, /* [annotation][out] _COM_Outptr_ */ out ISpatialAudioObjectForMetadataCommands audioObject);
        
        [PreserveSig]
        HRESULT ActivateSpatialAudioObjectForMetadataItems(/* [annotation][in] _In_ */ AudioObjectType type, /* [annotation][out] _COM_Outptr_ */ out ISpatialAudioObjectForMetadataItems audioObject);
    }
}
