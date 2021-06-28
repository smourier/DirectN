// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(939,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A bitmap brush allows a bitmap to be used to fill a geometry. Interpolation mode is specified with D2D1_INTERPOLATION_MODE
    /// </summary>
    [ComImport, Guid("41343a53-e41a-49a2-91cd-21793bbb62e5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1BitmapBrush1 : ID2D1BitmapBrush
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
        
        // ID2D1BitmapBrush
        [PreserveSig]
        new void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
        
        [PreserveSig]
        new void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
        
        [PreserveSig]
        new void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        new void SetBitmap(/* _In_opt_ */ ID2D1Bitmap bitmap);
        
        [PreserveSig]
        new D2D1_EXTEND_MODE GetExtendModeX();
        
        [PreserveSig]
        new D2D1_EXTEND_MODE GetExtendModeY();
        
        [PreserveSig]
        new D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();
        
        [PreserveSig]
        new void GetBitmap(/* _Outptr_result_maybenull_ */ out ID2D1Bitmap bitmap);
        
        // ID2D1BitmapBrush1
        [PreserveSig]
        void SetInterpolationMode1(D2D1_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        D2D1_INTERPOLATION_MODE GetInterpolationMode1();
    }
}
