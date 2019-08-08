// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(2044,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b7e82e2-69c5-4eb4-a5f5-a7033f5132cd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTableTransferEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionTableTransferEffect
        [PreserveSig]
        HRESULT SetRedTable(/* THIS_ _In_count_(count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] tableValues, /* _In_ */ uint count);
        
        [PreserveSig]
        HRESULT SetGreenTable(/* THIS_ _In_count_(count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] tableValues, /* _In_ */ uint count);
        
        [PreserveSig]
        HRESULT SetBlueTable(/* THIS_ _In_count_(count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] tableValues, /* _In_ */ uint count);
        
        [PreserveSig]
        HRESULT SetAlphaTable(/* THIS_ _In_count_(count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] tableValues, /* _In_ */ uint count);
        
        [PreserveSig]
        HRESULT SetRedDisable(/* THIS_ _In_ */ bool redDisable);
        
        [PreserveSig]
        HRESULT SetGreenDisable(/* THIS_ _In_ */ bool greenDisable);
        
        [PreserveSig]
        HRESULT SetBlueDisable(/* THIS_ _In_ */ bool blueDisable);
        
        [PreserveSig]
        HRESULT SetAlphaDisable(/* THIS_ _In_ */ bool alphaDisable);
        
        [PreserveSig]
        HRESULT SetClampOutput(/* THIS_ _In_ */ bool clampOutput);
        
        [PreserveSig]
        HRESULT SetRedTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetRedTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetGreenTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetGreenTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetBlueTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetBlueTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAlphaTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetAlphaTableValue(/* THIS_ _In_ */ uint index, /* _In_ */ IDCompositionAnimation animation);
    }
}
