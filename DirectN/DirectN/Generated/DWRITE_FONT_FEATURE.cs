// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(1981,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_FONT_FEATURE structure specifies properties used to identify and execute typographic feature in the font.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_FEATURE
    {
        /// <summary>
        /// The feature OpenType name identifier.
        /// </summary>
        public DWRITE_FONT_FEATURE_TAG nameTag;
        /// <summary>
        /// Execution parameter of the feature.  <remarks> The parameter should be non-zero to enable the feature. Once enabled, a feature can't be disabled again within the same range. Features requiring a selector use this value to indicate the selector index. </remarks>
        /// </summary>
        public uint parameter;
    }
}
