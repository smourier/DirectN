// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("df0c7cec-cdeb-4d4a-b91c-721bf22f4e6c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionInkTrailDevice
    {
        [PreserveSig]
        HRESULT CreateDelegatedInkTrail(/* _Out_ */ out IDCompositionDelegatedInkTrail inkTrail);
        
        [PreserveSig]
        HRESULT CreateDelegatedInkTrailForSwapChain(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object swapChain, /* _Out_ */ out IDCompositionDelegatedInkTrail inkTrail);
    }
}
