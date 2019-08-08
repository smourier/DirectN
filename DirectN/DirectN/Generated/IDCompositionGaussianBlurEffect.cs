// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(1659,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("45d4d0b7-1bd4-454e-8894-2bfa68443033"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionGaussianBlurEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionGaussianBlurEffect
        [PreserveSig]
        HRESULT SetStandardDeviation(/* THIS_ _In_ */ float amount);
        
        [PreserveSig]
        HRESULT SetStandardDeviation(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBorderMode(/* THIS_ _In_ */ D2D1_BORDER_MODE mode);
    }
}
