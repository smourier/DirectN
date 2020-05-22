// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\spatialaudiometadata.h(185,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bcd7c78f-3098-4f22-b547-a2f25a381269"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioMetadataItems
    {
        [PreserveSig]
        HRESULT GetFrameCount(/* [annotation][out] _Out_ */ out ushort frameCount);
        
        [PreserveSig]
        HRESULT GetItemCount(/* [annotation][out] _Out_ */ out ushort itemCount);
        
        [PreserveSig]
        HRESULT GetMaxItemCount(/* [annotation][out] _Out_ */ out ushort maxItemCount);
        
        [PreserveSig]
        HRESULT GetMaxValueBufferLength(/* [annotation][out] _Out_ */ out uint maxValueBufferLength);
        
        [PreserveSig]
        HRESULT GetInfo(/* [annotation][out] _Out_ */ out SpatialAudioMetadataItemsInfo info);
    }
}
