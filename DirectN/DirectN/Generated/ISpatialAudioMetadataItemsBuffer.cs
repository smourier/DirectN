// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\spatialaudiometadata.h(681,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("42640a16-e1bd-42d9-9ff6-031ab71a2dba"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioMetadataItemsBuffer
    {
        [PreserveSig]
        HRESULT AttachToBuffer(/* [annotation][size_is][in] _Out_writes_bytes_(bufferLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buffer, /* [annotation][in] _In_ */ int bufferLength);
        
        [PreserveSig]
        HRESULT AttachToPopulatedBuffer(/* [annotation][size_is][in] _Out_writes_bytes_(bufferLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buffer, /* [annotation][in] _In_ */ int bufferLength);
        
        [PreserveSig]
        HRESULT DetachBuffer();
    }
}
