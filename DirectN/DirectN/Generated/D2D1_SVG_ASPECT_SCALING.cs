// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1svg.h(270,9)
namespace DirectN
{
    /// <summary>
    /// The meetOrSlice portion of the SVG preserveAspectRatio attribute.
    /// </summary>
    public enum D2D1_SVG_ASPECT_SCALING
    {
        /// <summary>
        /// Scale the viewBox up as much as possible such that the entire viewBox is visible within the viewport.
        /// </summary>
        D2D1_SVG_ASPECT_SCALING_MEET = 0,
        
        /// <summary>
        /// Scale the viewBox down as much as possible such that the entire viewport is covered by the viewBox.
        /// </summary>
        D2D1_SVG_ASPECT_SCALING_SLICE = 1,
        
        /// <summary>
        /// Scale the viewBox down as much as possible such that the entire viewport is covered by the viewBox.
        /// </summary>
        D2D1_SVG_ASPECT_SCALING_FORCE_DWORD = -1,
    }
}
