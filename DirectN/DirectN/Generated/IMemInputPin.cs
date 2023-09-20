// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a8689d-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
