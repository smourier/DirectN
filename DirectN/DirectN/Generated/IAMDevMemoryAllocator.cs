// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6545bf0-e76b-11d0-bd52-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDevMemoryAllocator
    {
        [PreserveSig]
        HRESULT GetInfo(/* [annotation][out] _Out_ */ out uint pdwcbTotalFree, /* [annotation][out] _Out_ */ out uint pdwcbLargestFree, /* [annotation][out] _Out_ */ out uint pdwcbTotalMemory, /* [annotation][out] _Out_ */ out uint pdwcbMinimumChunk);
        
        [PreserveSig]
        HRESULT CheckMemory(/* [in] */ ref byte pBuffer);
        
        [PreserveSig]
        HRESULT Alloc(/* [annotation][out] _Outptr_result_bytebuffer_(*pdwcbBuffer) */ out IntPtr ppBuffer, /* [annotation][out][in] _Inout_ */ ref uint pdwcbBuffer);
        
        [PreserveSig]
        HRESULT Free(/* [in] */ ref byte pBuffer);
        
        [PreserveSig]
        HRESULT GetDevMemoryObject(/* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkInnner, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter);
    }
}
