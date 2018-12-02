// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(1568,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("aeb2543a-167f-4682-acc8-d159ed4a6209"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoProcessCommandList
    {
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT Reset(/* _In_ */ ref ID3D12CommandAllocator pAllocator);
        
        [PreserveSig]
        void ClearState();
        
        [PreserveSig]
        void ResourceBarrier(/* _In_ */ uint NumBarriers, /* _In_reads_(NumBarriers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESOURCE_BARRIER[] pBarriers);
        
        [PreserveSig]
        void DiscardResource(/* _In_ */ ref ID3D12Resource pResource, /* optional(D3D12_DISCARD_REGION) */ IntPtr pRegion);
        
        [PreserveSig]
        void BeginQuery(/* _In_ */ ref ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void EndQuery(/* _In_ */ ref ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void ResolveQueryData(/* _In_ */ ref ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint StartIndex, /* _In_ */ uint NumQueries, /* _In_ */ ref ID3D12Resource pDestinationBuffer, /* _In_ */ ulong AlignedDestinationBufferOffset);
        
        [PreserveSig]
        void SetPredication(/* optional(ID3D12Resource) */ IntPtr pBuffer, /* _In_ */ ulong AlignedBufferOffset, /* _In_ */ D3D12_PREDICATION_OP Operation);
        
        [PreserveSig]
        void SetMarker(uint Metadata, /* _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Size);
        
        [PreserveSig]
        void BeginEvent(uint Metadata, /* _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Size);
        
        [PreserveSig]
        void EndEvent();
        
        [PreserveSig]
        void ProcessFrames(/* _In_ */ ID3D12VideoProcessor pVideoProcessor, /* _In_ */ ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS pOutputArguments, uint NumInputStreams, /* _In_reads_(NumInputStreams) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS[] pInputArguments);
        
        [PreserveSig]
        void WriteBufferImmediate(uint Count, /* _In_reads_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER[] pParams, /* _In_reads_opt_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_MODE[] pModes);
    }
}
