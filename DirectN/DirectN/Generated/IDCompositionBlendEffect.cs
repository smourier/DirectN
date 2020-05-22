// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(2158,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("33ecdc0a-578a-4a11-9c14-0cb90517f9c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
