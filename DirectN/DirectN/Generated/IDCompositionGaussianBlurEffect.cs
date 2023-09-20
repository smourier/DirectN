// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("45d4d0b7-1bd4-454e-8894-2bfa68443033"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionGaussianBlurEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionGaussianBlurEffect
        [PreserveSig]
        HRESULT SetStandardDeviation(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetStandardDeviation(/* THIS_ _In_ */ float amount);
        
        [PreserveSig]
        HRESULT SetBorderMode(/* THIS_ _In_ */ D2D1_BORDER_MODE mode);
    }
}
