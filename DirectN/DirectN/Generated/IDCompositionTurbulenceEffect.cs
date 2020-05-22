// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1895,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a6a55bda-c09c-49f3-9193-a41922c89715"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTurbulenceEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionTurbulenceEffect
        [PreserveSig]
        HRESULT SetOffset(/* THIS_ _In_ */ ref D2D_VECTOR_2F offset);
        
        [PreserveSig]
        HRESULT SetBaseFrequency(/* THIS_ _In_ */ ref D2D_VECTOR_2F frequency);
        
        [PreserveSig]
        HRESULT SetSize(/* THIS_ _In_ */ ref D2D_VECTOR_2F size);
        
        [PreserveSig]
        HRESULT SetNumOctaves(/* THIS_ _In_ */ uint numOctaves);
        
        [PreserveSig]
        HRESULT SetSeed(/* THIS_ _In_ */ uint seed);
        
        [PreserveSig]
        HRESULT SetNoise(/* THIS_ _In_ */ D2D1_TURBULENCE_NOISE noise);
        
        [PreserveSig]
        HRESULT SetStitchable(/* THIS_ _In_ */ bool stitchable);
    }
}
