// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(1190,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root brush interface. All brushes can be used to fill or pen a geometry.
    /// </summary>
    [ComImport, Guid("2cd906a8-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Brush : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Brush
        [PreserveSig]
        void SetOpacity(float opacity);
        
        [PreserveSig]
        void SetTransform(/* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        float GetOpacity();
        
        [PreserveSig]
        void GetTransform(/* _Out_ */ out D2D_MATRIX_3X2_F transform);
    }
}
