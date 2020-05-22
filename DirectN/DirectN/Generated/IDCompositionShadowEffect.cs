// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1789,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4ad18ac0-cfd2-4c2f-bb62-96e54fdb6879"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionShadowEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionShadowEffect
        [PreserveSig]
        HRESULT SetStandardDeviation(/* THIS_ _In_ */ float amount);
        
        [PreserveSig]
        HRESULT SetStandardDeviation(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetColor(/* THIS_ _In_ */ ref D2D_VECTOR_4F color);
        
        [PreserveSig]
        HRESULT SetRed(/* THIS_ _In_ */ float amount);
        
        [PreserveSig]
        HRESULT SetRed(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetGreen(/* THIS_ _In_ */ float amount);
        
        [PreserveSig]
        HRESULT SetGreen(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBlue(/* THIS_ _In_ */ float amount);
        
        [PreserveSig]
        HRESULT SetBlue(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAlpha(/* THIS_ _In_ */ float amount);
        
        [PreserveSig]
        HRESULT SetAlpha(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
