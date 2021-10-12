// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2525,1)
namespace DirectN
{
    /// <summary>
    /// Attributes for a font axis.
    /// </summary>
    public enum DWRITE_FONT_AXIS_ATTRIBUTES
    {
        /// <summary>
        /// No attributes.
        /// </summary>
        DWRITE_FONT_AXIS_ATTRIBUTES_NONE = 0,
        
        /// <summary>
        /// This axis is implemented as a variation axis in a variable font, with a continuous range of values, such as a range of weights from 100..900. Otherwise it is either a static axis that holds a single point, or it has a range but doesn't vary, such as optical size in the Skia Heading font which covers a range of points but doesn't interpolate any new glyph outlines.
        /// </summary>
        DWRITE_FONT_AXIS_ATTRIBUTES_VARIABLE = 1,
        
        /// <summary>
        /// This axis is recommended to be remain hidden in user interfaces. The font developer may recommend this if an axis is intended to be accessed only programmatically, or is meant for font-internal or font-developer use only. The axis may be exposed in lower-level font inspection utilities, but should not be exposed in common or even advanced-mode user interfaces in content-authoring apps.
        /// </summary>
        DWRITE_FONT_AXIS_ATTRIBUTES_HIDDEN = 2,
    }
}
