// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(1945,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4305ee5b-c4a0-4c88-9385-67124e017683"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionLinearTransferEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionLinearTransferEffect
        [PreserveSig]
        HRESULT SetRedYIntercept(/* THIS_ _In_ */ float redYIntercept);
        
        [PreserveSig]
        HRESULT SetRedYIntercept(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetRedSlope(/* THIS_ _In_ */ float redSlope);
        
        [PreserveSig]
        HRESULT SetRedSlope(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetRedDisable(/* THIS_ _In_ */ bool redDisable);
        
        [PreserveSig]
        HRESULT SetGreenYIntercept(/* THIS_ _In_ */ float greenYIntercept);
        
        [PreserveSig]
        HRESULT SetGreenYIntercept(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetGreenSlope(/* THIS_ _In_ */ float greenSlope);
        
        [PreserveSig]
        HRESULT SetGreenSlope(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetGreenDisable(/* THIS_ _In_ */ bool greenDisable);
        
        [PreserveSig]
        HRESULT SetBlueYIntercept(/* THIS_ _In_ */ float blueYIntercept);
        
        [PreserveSig]
        HRESULT SetBlueYIntercept(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBlueSlope(/* THIS_ _In_ */ float blueSlope);
        
        [PreserveSig]
        HRESULT SetBlueSlope(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBlueDisable(/* THIS_ _In_ */ bool blueDisable);
        
        [PreserveSig]
        HRESULT SetAlphaYIntercept(/* THIS_ _In_ */ float alphaYIntercept);
        
        [PreserveSig]
        HRESULT SetAlphaYIntercept(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAlphaSlope(/* THIS_ _In_ */ float alphaSlope);
        
        [PreserveSig]
        HRESULT SetAlphaSlope(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAlphaDisable(/* THIS_ _In_ */ bool alphaDisable);
        
        [PreserveSig]
        HRESULT SetClampOutput(/* THIS_ _In_ */ bool clampOutput);
    }
}
