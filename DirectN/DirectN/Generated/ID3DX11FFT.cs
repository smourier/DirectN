﻿// generated from <Windows SDK Path>\um\d3dcsx.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b3f7a938-4c93-4310-a675-b30d6de50553"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DX11FFT
    {
        [PreserveSig]
        HRESULT SetForwardScale(float ForwardScale);
        
        [PreserveSig]
        float GetForwardScale();
        
        [PreserveSig]
        HRESULT SetInverseScale(float InverseScale);
        
        [PreserveSig]
        float GetInverseScale();
        
        [PreserveSig]
        HRESULT AttachBuffersAndPrecompute(/* THIS_ _In_range_(0,D3DX11_FFT_MAX_TEMP_BUFFERS) */ int NumTempBuffers, /* _In_reads_(NumTempBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11UnorderedAccessView[] ppTempBuffers, /* _In_range_(0,D3DX11_FFT_MAX_PRECOMPUTE_BUFFERS) */ int NumPrecomputeBuffers, /* _In_reads_(NumPrecomputeBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11UnorderedAccessView[] ppPrecomputeBufferSizes);
        
        [PreserveSig]
        HRESULT ForwardTransform(/* THIS_ _In_ */ ID3D11UnorderedAccessView pInputBuffer, /* _Inout_ */ out ID3D11UnorderedAccessView ppOutputBuffer);
        
        [PreserveSig]
        HRESULT InverseTransform(/* THIS_ _In_ */ ID3D11UnorderedAccessView pInputBuffer, /* _Inout_ */ out ID3D11UnorderedAccessView ppOutputBuffer);
    }
}
