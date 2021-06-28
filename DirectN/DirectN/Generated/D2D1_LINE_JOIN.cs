// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(426,9)
namespace DirectN
{
    /// <summary>
    /// Enum which describes the drawing of the corners on the line.
    /// </summary>
    public enum D2D1_LINE_JOIN
    {
        /// <summary>
        /// Miter join.
        /// </summary>
        D2D1_LINE_JOIN_MITER = 0,
        
        /// <summary>
        /// Bevel join.
        /// </summary>
        D2D1_LINE_JOIN_BEVEL = 1,
        
        /// <summary>
        /// Round join.
        /// </summary>
        D2D1_LINE_JOIN_ROUND = 2,
        
        /// <summary>
        /// Miter/Bevel join.
        /// </summary>
        D2D1_LINE_JOIN_MITER_OR_BEVEL = 3,
        
        /// <summary>
        /// Miter/Bevel join.
        /// </summary>
        D2D1_LINE_JOIN_FORCE_DWORD = -1,
    }
}
