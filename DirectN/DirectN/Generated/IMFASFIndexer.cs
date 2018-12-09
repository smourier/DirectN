// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmcontainer.h(1532,5)
using System;
using System.Runtime.InteropServices;
using MFTIME = System.Int64;

namespace DirectN
{
    [Guid("53590f48-dc3b-4297-813f-787761ad7b3e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFASFIndexer
    {
        [PreserveSig]
        HRESULT SetFlags(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetFlags(/* [out] */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT Initialize(/* [in] */ IMFASFContentInfo pIContentInfo);
        
        [PreserveSig]
        HRESULT GetIndexPosition(/* [in] */ IMFASFContentInfo pIContentInfo, /* [out] */ out ulong pcbIndexOffset);
        
        [PreserveSig]
        HRESULT SetIndexByteStreams(/* [in] */ IMFByteStream ppIByteStreams, /* [in] */ uint cByteStreams);
        
        [PreserveSig]
        HRESULT GetIndexByteStreamCount(/* [out] */ out uint pcByteStreams);
        
        [PreserveSig]
        HRESULT GetIndexStatus(/* [in] */ ref _ASF_INDEX_IDENTIFIER pIndexIdentifier, /* [out] */ out bool pfIsIndexed, /* [out] */ out byte pbIndexDescriptor, /* [out][in] */ ref uint pcbIndexDescriptor);
        
        [PreserveSig]
        HRESULT SetIndexStatus(/* [in] */ ref byte pbIndexDescriptor, /* [in] */ uint cbIndexDescriptor, /* [in] */ bool fGenerateIndex);
        
        [PreserveSig]
        HRESULT GetSeekPositionForValue(/* [in] */ [In, Out] PropVariant pvarValue, /* [in] */ ref _ASF_INDEX_IDENTIFIER pIndexIdentifier, /* [out] */ out ulong pcbOffsetWithinData, /* [optional][out] */ out MFTIME phnsApproxTime, /* [optional][out] */ out uint pdwPayloadNumberOfStreamWithinPacket);
        
        [PreserveSig]
        HRESULT GenerateIndexEntries(/* [in] */ IMFSample pIASFPacketSample);
        
        [PreserveSig]
        HRESULT CommitIndex(/* [in] */ IMFASFContentInfo pIContentInfo);
        
        [PreserveSig]
        HRESULT GetIndexWriteSpace(/* [out] */ out ulong pcbIndexWriteSpace);
        
        [PreserveSig]
        HRESULT GetCompletedIndex(/* [in] */ IMFMediaBuffer pIIndexBuffer, /* [in] */ ulong cbOffsetWithinIndex);
    }
}
