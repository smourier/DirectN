// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_2.h(70,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Enables creation and drawing of geometry realization objects.
    /// </summary>
    [Guid("d37f57e4-6908-459f-a199-e72f24f79987"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DeviceContext1
    {
        [PreserveSig]
        HRESULT CreateFilledGeometryRealization(/* _In_ */ ref ID2D1Geometry geometry, float flatteningTolerance, /* _COM_Outptr_ */ out ID2D1GeometryRealization geometryRealization);
        
        [PreserveSig]
        HRESULT CreateStrokedGeometryRealization(/* _In_ */ ref ID2D1Geometry geometry, float flatteningTolerance, float strokeWidth, /* optional(ID2D1StrokeStyle) */ IntPtr strokeStyle, /* _COM_Outptr_ */ out ID2D1GeometryRealization geometryRealization);
        
        [PreserveSig]
        void DrawGeometryRealization(/* _In_ */ ref ID2D1GeometryRealization geometryRealization, /* _In_ */ ref ID2D1Brush brush);
    }
}
