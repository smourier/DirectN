using System;
using System.Runtime.InteropServices;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    [Guid("2cd9069f-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1GeometrySink : ID2D1SimplifiedGeometrySink
    {
        // ID2D1SimplifiedGeometrySink
        [PreserveSig]
        new void SetFillMode(D2D1_FILL_MODE fillMode);

        [PreserveSig]
        new void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags);

        [PreserveSig]
        new void BeginFigure(D2D1_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);

        [PreserveSig]
        new void AddLines(D2D1_POINT_2F[] points, int pointsCount);

        [PreserveSig]
        new void AddBeziers(D2D1_BEZIER_SEGMENT[] beziers, int beziersCount);

        [PreserveSig]
        new void EndFigure(D2D1_FIGURE_END figureEnd);

        [PreserveSig]
        new HRESULT Close();

        // ID2D1GeometrySink
        [PreserveSig]
        void AddLine(D2D1_POINT_2F point);

        [PreserveSig]
        void AddBezier(ref D2D1_BEZIER_SEGMENT bezier);

        [PreserveSig]
        void AddQuadraticBezier(ref D2D1_QUADRATIC_BEZIER_SEGMENT bezier);

        [PreserveSig]
        void AddQuadraticBeziers(D2D1_QUADRATIC_BEZIER_SEGMENT[] beziers, int beziersCount);

        [PreserveSig]
        void AddArc(ref D2D1_ARC_SEGMENT arc);
    }
}
