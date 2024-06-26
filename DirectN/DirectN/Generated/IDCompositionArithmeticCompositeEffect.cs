﻿// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3b67dfa8-e3dd-4e61-b640-46c2f3d739dc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionArithmeticCompositeEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionArithmeticCompositeEffect
        [PreserveSig]
        HRESULT SetCoefficients(/* THIS_ _In_ */ ref D2D_VECTOR_4F coefficients);
        
        [PreserveSig]
        HRESULT SetClampOutput(/* THIS_ _In_ */ bool clampoutput);
        
        [PreserveSig]
        HRESULT SetCoefficient1(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCoefficient1(/* THIS_ _In_ */ float Coeffcient1);
        
        [PreserveSig]
        HRESULT SetCoefficient2(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCoefficient2(/* THIS_ _In_ */ float Coefficient2);
        
        [PreserveSig]
        HRESULT SetCoefficient3(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCoefficient3(/* THIS_ _In_ */ float Coefficient3);
        
        [PreserveSig]
        HRESULT SetCoefficient4(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCoefficient4(/* THIS_ _In_ */ float Coefficient4);
    }
}
