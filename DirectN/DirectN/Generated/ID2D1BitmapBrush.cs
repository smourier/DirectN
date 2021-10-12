// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(1228,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A bitmap brush allows a bitmap to be used to fill a geometry.
    /// </summary>
    [ComImport, Guid("2cd906aa-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1BitmapBrush : ID2D1Brush
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
        void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
        
        [PreserveSig]
        void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
        
        [PreserveSig]
        void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        void SetBitmap(/* _In_opt_ */ ID2D1Bitmap bitmap);
        
        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeX();
        
        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeY();
        
        [PreserveSig]
        D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();
        
        [PreserveSig]
        void GetBitmap(/* _Outptr_result_maybenull_ */ out ID2D1Bitmap bitmap);
    }
}
