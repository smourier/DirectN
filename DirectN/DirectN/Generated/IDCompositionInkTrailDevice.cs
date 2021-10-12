// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(2398,1)
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
