// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6027496e-cb3a-49ab-934f-d798da4f7da6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionBrightnessEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionBrightnessEffect
        [PreserveSig]
        HRESULT SetWhitePoint(/* THIS_ _In_ */ ref D2D_VECTOR_2F whitePoint);
        
        [PreserveSig]
        HRESULT SetBlackPoint(/* THIS_ _In_ */ ref D2D_VECTOR_2F blackPoint);
        
        [PreserveSig]
        HRESULT SetWhitePointX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetWhitePointX(/* THIS_ _In_ */ float whitePointX);
        
        [PreserveSig]
        HRESULT SetWhitePointY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetWhitePointY(/* THIS_ _In_ */ float whitePointY);
        
        [PreserveSig]
        HRESULT SetBlackPointX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBlackPointX(/* THIS_ _In_ */ float blackPointX);
        
        [PreserveSig]
        HRESULT SetBlackPointY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBlackPointY(/* THIS_ _In_ */ float blackPointY);
    }
}
