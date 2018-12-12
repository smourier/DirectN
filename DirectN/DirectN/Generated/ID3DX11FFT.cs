// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dcsx.h(220,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b3f7a938-4c93-4310-a675-b30d6de50553"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        HRESULT AttachBuffersAndPrecompute(/* THIS_ _In_range_(0,D3DX11_FFT_MAX_TEMP_BUFFERS) */ uint NumTempBuffers, /* _In_reads_(NumTempBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11UnorderedAccessView[] ppTempBuffers, /* _In_range_(0,D3DX11_FFT_MAX_PRECOMPUTE_BUFFERS) */ uint NumPrecomputeBuffers, /* _In_reads_(NumPrecomputeBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11UnorderedAccessView[] ppPrecomputeBufferSizes);
        
        [PreserveSig]
        HRESULT ForwardTransform(/* THIS_ _In_ */ ref ID3D11UnorderedAccessView pInputBuffer, /* _Inout_ */ out ID3D11UnorderedAccessView ppOutputBuffer);
        
        [PreserveSig]
        HRESULT InverseTransform(/* THIS_ _In_ */ ref ID3D11UnorderedAccessView pInputBuffer, /* _Inout_ */ out ID3D11UnorderedAccessView ppOutputBuffer);
    }
}
