// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudiometadata.h(848,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("777d4a3b-f6ff-4a26-85dc-68d7cdeda1d4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioMetadataClient
    {
        [PreserveSig]
        HRESULT ActivateSpatialAudioMetadataItems(/* [annotation][in] _In_ */ ushort maxItemCount, /* [annotation][in] _In_ */ ushort frameCount, /* [annotation][out] _Outptr_opt_result_nullonfailure_ */ out ISpatialAudioMetadataItemsBuffer metadataItemsBuffer, /* [annotation][out] _Outptr_result_nullonfailure_ */ out ISpatialAudioMetadataItems metadataItems);
        
        [PreserveSig]
        HRESULT GetSpatialAudioMetadataItemsBufferLength(/* [annotation][in] _In_ */ ushort maxItemCount, /* [annotation][out] _Out_ */ out uint bufferLength);
        
        [PreserveSig]
        HRESULT ActivateSpatialAudioMetadataWriter(/* [annotation][in] _In_ */ SpatialAudioMetadataWriterOverflowMode overflowMode, /* [annotation][out] _Outptr_result_nullonfailure_ */ out ISpatialAudioMetadataWriter metadataWriter);
        
        [PreserveSig]
        HRESULT ActivateSpatialAudioMetadataCopier(/* [annotation][out] _Outptr_result_nullonfailure_ */ out ISpatialAudioMetadataCopier metadataCopier);
        
        [PreserveSig]
        HRESULT ActivateSpatialAudioMetadataReader(/* [annotation][out] _Outptr_result_nullonfailure_ */ out ISpatialAudioMetadataReader metadataReader);
    }
}
