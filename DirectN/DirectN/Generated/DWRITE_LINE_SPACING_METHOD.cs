// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(1831,1)
namespace DirectN
{
    /// <summary>
    /// The method used for line spacing in layout.
    /// </summary>
    public enum DWRITE_LINE_SPACING_METHOD
    {
        /// <summary>
        /// Line spacing depends solely on the content, growing to accommodate the size of fonts and inline objects.
        /// </summary>
        DWRITE_LINE_SPACING_METHOD_DEFAULT = 0,
        
        /// <summary>
        /// Lines are explicitly set to uniform spacing, regardless of contained font sizes. This can be useful to avoid the uneven appearance that can occur from font fallback.
        /// </summary>
        DWRITE_LINE_SPACING_METHOD_UNIFORM = 1,
        
        /// <summary>
        /// Line spacing and baseline distances are proportional to the computed values based on the content, the size of the fonts and inline objects.
        /// </summary>
        DWRITE_LINE_SPACING_METHOD_PROPORTIONAL = 2,
    }
}
