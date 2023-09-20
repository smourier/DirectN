// generated from <Windows SDK Path>\um\d2d1svg.h
namespace DirectN
{
    /// <summary>
    /// Specifies a value for the SVG stroke-linejoin property.
    /// </summary>
    public enum D2D1_SVG_LINE_JOIN
    {
        /// <summary>
        /// The property is set to SVG's 'bevel' value.
        /// </summary>
        D2D1_SVG_LINE_JOIN_BEVEL = 1,
        
        /// <summary>
        /// The property is set to SVG's 'miter' value. Note that this is equivalent to D2D1_LINE_JOIN_MITER_OR_BEVEL, not D2D1_LINE_JOIN_MITER.
        /// </summary>
        D2D1_SVG_LINE_JOIN_MITER = 3,
        
        /// <summary>
        /// \ The property is set to SVG's 'round' value.
        /// </summary>
        D2D1_SVG_LINE_JOIN_ROUND = 2,
        
        /// <summary>
        /// \ The property is set to SVG's 'round' value.
        /// </summary>
        D2D1_SVG_LINE_JOIN_FORCE_DWORD = -1,
    }
}
