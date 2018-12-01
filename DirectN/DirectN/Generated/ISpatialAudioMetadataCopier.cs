// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\spatialaudiometadata.h(567,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d224b233-e251-4fd0-9ca2-d5ecf9a68404"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioMetadataCopier
    {
        [PreserveSig]
        HRESULT Open(/* [annotation][in] _In_ */ ISpatialAudioMetadataItems metadataItems);
        
        [PreserveSig]
        HRESULT CopyMetadataForFrames(/* [annotation][in] _In_ */ ushort copyFrameCount, /* [annotation][in] _In_ */ SpatialAudioMetadataCopyMode copyMode, /* [annotation][in] _In_ */ ISpatialAudioMetadataItems dstMetadataItems, /* [annotation][out] _Out_ */ out ushort itemsCopied);
        
        [PreserveSig]
        HRESULT Close();
    }
}
