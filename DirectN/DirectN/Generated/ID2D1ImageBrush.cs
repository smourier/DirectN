// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(893,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Provides a brush that can take any effect, command list or bitmap and use it to fill a 2D shape.
    /// </summary>
    [ComImport, Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ImageBrush : ID2D1Brush
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Brush
        [PreserveSig]
        new void SetOpacity(float opacity);
        
        [PreserveSig]
        new void SetTransform(/* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        new float GetOpacity();
        
        [PreserveSig]
        new void GetTransform(/* _Out_ */ out D2D_MATRIX_3X2_F transform);
        
        // ID2D1ImageBrush
        [PreserveSig]
        void SetImage(/* _In_opt_ */ ID2D1Image image);
        
        [PreserveSig]
        void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
        
        [PreserveSig]
        void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
        
        [PreserveSig]
        void SetInterpolationMode(D2D1_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        void SetSourceRectangle(/* _In_ */ ref D2D_RECT_F sourceRectangle);
        
        [PreserveSig]
        void GetImage(/* _Outptr_result_maybenull_ */ out ID2D1Image image);
        
        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeX();
        
        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeY();
        
        [PreserveSig]
        D2D1_INTERPOLATION_MODE GetInterpolationMode();
        
        [PreserveSig]
        void GetSourceRectangle(/* _Out_ */ out D2D_RECT_F sourceRectangle);
    }
}
