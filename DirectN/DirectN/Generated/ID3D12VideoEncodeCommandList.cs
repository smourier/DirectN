// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3066,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8455293a-0cbd-4831-9b39-fbdbab724723"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoEncodeCommandList : ID3D12CommandList
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12CommandList
        [PreserveSig]
        new D3D12_COMMAND_LIST_TYPE GetType();
        
        // ID3D12VideoEncodeCommandList
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT Reset(/* _In_ */ ID3D12CommandAllocator pAllocator);
        
        [PreserveSig]
        void ClearState();
        
        [PreserveSig]
        void ResourceBarrier(/* _In_ */ int NumBarriers, /* _In_reads_(NumBarriers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESOURCE_BARRIER[] pBarriers);
        
        [PreserveSig]
        void DiscardResource(/* _In_ */ ID3D12Resource pResource, /* optional(D3D12_DISCARD_REGION) */ IntPtr pRegion);
        
        [PreserveSig]
        void BeginQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void EndQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void ResolveQueryData(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint StartIndex, /* _In_ */ uint NumQueries, /* _In_ */ ID3D12Resource pDestinationBuffer, /* _In_ */ ulong AlignedDestinationBufferOffset);
        
        [PreserveSig]
        void SetPredication(/* _In_opt_ */ ID3D12Resource pBuffer, /* _In_ */ ulong AlignedBufferOffset, /* _In_ */ D3D12_PREDICATION_OP Operation);
        
        [PreserveSig]
        void SetMarker(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);
        
        [PreserveSig]
        void BeginEvent(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);
        
        [PreserveSig]
        void EndEvent();
        
        [PreserveSig]
        void EstimateMotion(/* _In_ */ ID3D12VideoMotionEstimator pMotionEstimator, /* _In_ */ ref D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT pOutputArguments, /* _In_ */ ref D3D12_VIDEO_MOTION_ESTIMATOR_INPUT pInputArguments);
        
        [PreserveSig]
        void ResolveMotionVectorHeap(ref D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT pOutputArguments, ref D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT pInputArguments);
        
        [PreserveSig]
        void WriteBufferImmediate(int Count, /* _In_reads_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER[] pParams, /* _In_reads_opt_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_MODE[] pModes);
        
        [PreserveSig]
        void SetProtectedResourceSession(/* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession);
    }
}
