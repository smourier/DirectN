// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1svg.h(295,9)
namespace DirectN
{
    /// <summary>
    /// Represents a path commmand. Each command may reference floats from the segment data. Commands ending in _ABSOLUTE interpret data as absolute coordinate. Commands ending in _RELATIVE interpret data as being relative to the previous point.
    /// </summary>
    public enum D2D1_SVG_PATH_COMMAND
    {
        /// <summary>
        /// Closes the current subpath. Uses no segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_CLOSE_PATH = 0,
        
        /// <summary>
        /// Starts a new subpath at the coordinate (x y). Uses 2 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE = 1,
        
        /// <summary>
        /// Starts a new subpath at the coordinate (x y). Uses 2 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE = 2,
        
        /// <summary>
        /// Draws a line to the coordinate (x y). Uses 2 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE = 3,
        
        /// <summary>
        /// Draws a line to the coordinate (x y). Uses 2 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_LINE_RELATIVE = 4,
        
        /// <summary>
        /// Draws a cubic Bezier curve (x1 y1 x2 y2 x y). The curve ends at (x, y) and is defined by the two control points (x1, y1) and (x2, y2). Uses 6 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE = 5,
        
        /// <summary>
        /// Draws a cubic Bezier curve (x1 y1 x2 y2 x y). The curve ends at (x, y) and is defined by the two control points (x1, y1) and (x2, y2). Uses 6 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE = 6,
        
        /// <summary>
        /// Draws a quadratic Bezier curve (x1 y1 x y). The curve ends at (x, y) and is defined by the control point (x1 y1). Uses 4 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE = 7,
        
        /// <summary>
        /// Draws a quadratic Bezier curve (x1 y1 x y). The curve ends at (x, y) and is defined by the control point (x1 y1). Uses 4 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE = 8,
        
        /// <summary>
        /// Draws an elliptical arc (rx ry x-axis-rotation large-arc-flag sweep-flag x y). The curve ends at (x, y) and is defined by the arc parameters. The two flags are considered set if their values are non-zero. Uses 7 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE = 9,
        
        /// <summary>
        /// Draws an elliptical arc (rx ry x-axis-rotation large-arc-flag sweep-flag x y). The curve ends at (x, y) and is defined by the arc parameters. The two flags are considered set if their values are non-zero. Uses 7 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_ARC_RELATIVE = 10,
        
        /// <summary>
        /// Draws a horizontal line to the coordinate (x). Uses 1 float of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE = 11,
        
        /// <summary>
        /// Draws a horizontal line to the coordinate (x). Uses 1 float of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE = 12,
        
        /// <summary>
        /// Draws a vertical line to the coordinate (y). Uses 1 float of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE = 13,
        
        /// <summary>
        /// Draws a vertical line to the coordinate (y). Uses 1 float of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE = 14,
        
        /// <summary>
        /// Draws a smooth cubic Bezier curve (x2 y2 x y). The curve ends at (x, y) and is defined by the control point (x2, y2). Uses 4 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE = 15,
        
        /// <summary>
        /// Draws a smooth cubic Bezier curve (x2 y2 x y). The curve ends at (x, y) and is defined by the control point (x2, y2). Uses 4 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE = 16,
        
        /// <summary>
        /// Draws a smooth quadratic Bezier curve ending at (x, y). Uses 2 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE = 17,
        
        /// <summary>
        /// Draws a smooth quadratic Bezier curve ending at (x, y). Uses 2 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE = 18,
        
        /// <summary>
        /// Draws a smooth quadratic Bezier curve ending at (x, y). Uses 2 floats of segment data.
        /// </summary>
        D2D1_SVG_PATH_COMMAND_FORCE_DWORD = -1,
    }
}
