// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c1170a22-3ce2-4966-90d4-55408bfc84c4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionColorMatrixEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionColorMatrixEffect
        [PreserveSig]
        HRESULT SetMatrix(/* THIS_ _In_ */ ref D2D_MATRIX_5X4_F matrix);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetAlphaMode(/* THIS_ _In_ */ D2D1_COLORMATRIX_ALPHA_MODE mode);
        
        [PreserveSig]
        HRESULT SetClampOutput(/* THIS_ _In_ */ bool clamp);
    }
}
