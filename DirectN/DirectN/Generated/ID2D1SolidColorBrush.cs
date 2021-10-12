// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(1279,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Paints an area with a solid color.
    /// </summary>
    [ComImport, Guid("2cd906a9-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SolidColorBrush : ID2D1Brush
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
        
        // ID2D1SolidColorBrush
        [PreserveSig]
        void SetColor(/* _In_ */ ref _D3DCOLORVALUE color);
        
        [PreserveSig]
        void GetColor(out _D3DCOLORVALUE size);
    }
}
