// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(1747,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c1170a22-3ce2-4966-90d4-55408bfc84c4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAlphaMode(/* THIS_ _In_ */ D2D1_COLORMATRIX_ALPHA_MODE mode);
        
        [PreserveSig]
        HRESULT SetClampOutput(/* THIS_ _In_ */ bool clamp);
    }
}
