// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(2174,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes a geometric path that does not contain quadratic bezier curves or arcs.
    /// </summary>
    [ComImport, Guid("2cd9069e-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SimplifiedGeometrySink
    {
        [PreserveSig]
        void SetFillMode(D2D1_FILL_MODE fillMode);
        
        [PreserveSig]
        void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags);
        
        [PreserveSig]
        void BeginFigure(D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);
        
        [PreserveSig]
        void AddLines(/* _In_reads_(pointsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_POINT_2F[] points, int pointsCount);
        
        [PreserveSig]
        void AddBeziers(/* _In_reads_(beziersCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_BEZIER_SEGMENT[] beziers, int beziersCount);
        
        [PreserveSig]
        void EndFigure(D2D1_FIGURE_END figureEnd);
        
        [PreserveSig]
        HRESULT Close();
    }
}
