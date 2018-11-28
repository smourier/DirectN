using System;
using System.Runtime.InteropServices;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    [Guid("2cd9069e-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1SimplifiedGeometrySink
    {
        [PreserveSig]
        void SetFillMode(D2D1_FILL_MODE fillMode);

        [PreserveSig]
        void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags);

        [PreserveSig]
        void BeginFigure(D2D1_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);

        [PreserveSig]
        void AddLines(D2D1_POINT_2F[] points, int pointsCount);

        [PreserveSig]
        void AddBeziers(D2D1_BEZIER_SEGMENT[] beziers, int beziersCount);

        [PreserveSig]
        void EndFigure(D2D1_FIGURE_END figureEnd);

        [PreserveSig]
        HRESULT Close();
    }
}
