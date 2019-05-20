// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(3747,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a8689d-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMemInputPin
    {
        [PreserveSig]
        HRESULT GetAllocator(/* [annotation][out] _Out_ */ out IMemAllocator ppAllocator);
        
        [PreserveSig]
        HRESULT NotifyAllocator(/* [in] */ IMemAllocator pAllocator, /* [in] */ bool bReadOnly);
        
        [PreserveSig]
        HRESULT GetAllocatorRequirements(/* [annotation][out] _Out_ */ out _AllocatorProperties pProps);
        
        [PreserveSig]
        HRESULT Receive(/* [in] */ IMediaSample pSample);
        
        [PreserveSig]
        HRESULT ReceiveMultiple(/* [annotation][size_is][in] _In_reads_(nSamples) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IMediaSample[] pSamples, /* [in] */ int nSamples, /* [annotation][out] _Out_ */ out long nSamplesProcessed);
        
        [PreserveSig]
        HRESULT ReceiveCanBlock();
    }
}
