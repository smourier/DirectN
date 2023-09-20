// generated from <Windows SDK Path>\um\spatialaudiometadata.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("42640a16-e1bd-42d9-9ff6-031ab71a2dba"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
