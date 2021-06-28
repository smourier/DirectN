// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(2213,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes a geometric path that can contain lines, arcs, cubic Bezier curves, and quadratic Bezier curves.
    /// </summary>
    [ComImport, Guid("2cd9069f-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GeometrySink : ID2D1SimplifiedGeometrySink
    {
        // ID2D1SimplifiedGeometrySink
        [PreserveSig]
        new void SetFillMode(D2D1_FILL_MODE fillMode);
        
        [PreserveSig]
        new void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags);
        
        [PreserveSig]
        new void BeginFigure(D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);
        
        [PreserveSig]
        new void AddLines(/* _In_reads_(pointsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_POINT_2F[] points, int pointsCount);
        
        [PreserveSig]
        new void AddBeziers(/* _In_reads_(beziersCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_BEZIER_SEGMENT[] beziers, int beziersCount);
        
        [PreserveSig]
        new void EndFigure(D2D1_FIGURE_END figureEnd);
        
        [PreserveSig]
        new HRESULT Close();
        
        // ID2D1GeometrySink
        [PreserveSig]
        void AddLine(D2D_POINT_2F point);
        
        [PreserveSig]
        void AddBezier(/* _In_ */ ref D2D1_BEZIER_SEGMENT bezier);
        
        [PreserveSig]
        void AddQuadraticBezier(/* _In_ */ ref D2D1_QUADRATIC_BEZIER_SEGMENT bezier);
        
        [PreserveSig]
        void AddQuadraticBeziers(/* _In_reads_(beziersCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_QUADRATIC_BEZIER_SEGMENT[] beziers, int beziersCount);
        
        [PreserveSig]
        void AddArc(/* _In_ */ ref D2D1_ARC_SEGMENT arc);
    }
}
