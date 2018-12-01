// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1018,1)
using System;
using System.Runtime.InteropServices;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    /// <summary>
    /// This interface performs all the same functions as the existing ID2D1CommandSink1 interface. It also enables access to ink rendering and gradient mesh rendering.
    /// </summary>
    [Guid("3bab440e-417e-47df-a2e2-bc0be6a00916"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandSink2
    {
        [PreserveSig]
        HRESULT DrawInk(/* _In_ */ ID2D1Ink ink, /* _In_ */ ref ID2D1Brush brush, /* _In_opt_ */ ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        HRESULT DrawGradientMesh(/* _In_ */ ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        HRESULT DrawGdiMetafile(/* _In_ */ ref ID2D1GdiMetafile gdiMetafile, /* optional(D2D1_RECT_F) */ IntPtr destinationRectangle, /* optional(D2D1_RECT_F) */ IntPtr sourceRectangle);
    }
}
