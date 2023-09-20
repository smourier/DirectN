// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56ed71a0-af5f-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMBufferNegotiation
    {
        [PreserveSig]
        HRESULT SuggestAllocatorProperties(/* [in] */ ref _AllocatorProperties pprop);
        
        [PreserveSig]
        HRESULT GetAllocatorProperties(/* [annotation][out] _Out_ */ out _AllocatorProperties pprop);
    }
}
