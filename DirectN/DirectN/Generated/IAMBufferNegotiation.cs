// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(10021,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56ed71a0-af5f-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMBufferNegotiation
    {
        [PreserveSig]
        HRESULT SuggestAllocatorProperties(/* [in] */ ref _AllocatorProperties pprop);
        
        [PreserveSig]
        HRESULT GetAllocatorProperties(/* [annotation][out] _Out_ */ out _AllocatorProperties pprop);
    }
}
