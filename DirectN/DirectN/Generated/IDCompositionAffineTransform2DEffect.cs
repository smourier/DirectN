// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(2305,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0b74b9e8-cdd6-492f-bbbc-5ed32157026d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionAffineTransform2DEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionAffineTransform2DEffect
        [PreserveSig]
        HRESULT SetInterpolationMode(/* THIS_ _In_ */ D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        HRESULT SetBorderMode(/* THIS_ _In_ */ D2D1_BORDER_MODE borderMode);
        
        [PreserveSig]
        HRESULT SetTransformMatrix(/* THIS_ _In_ */ ref D2D_MATRIX_3X2_F transformMatrix);
        
        [PreserveSig]
        HRESULT SetTransformMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetTransformMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetSharpness(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetSharpness(/* THIS_ _In_ */ float sharpness);
    }
}
