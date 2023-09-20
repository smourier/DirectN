// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("33ecdc0a-578a-4a11-9c14-0cb90517f9c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionBlendEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionBlendEffect
        [PreserveSig]
        HRESULT SetMode(/* THIS_ _In_ */ D2D1_BLEND_MODE mode);
    }
}
