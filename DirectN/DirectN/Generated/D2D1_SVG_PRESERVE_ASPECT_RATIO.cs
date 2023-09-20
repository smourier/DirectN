// generated from <Windows SDK Path>\um\d2d1svg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents all SVG preserveAspectRatio settings.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_SVG_PRESERVE_ASPECT_RATIO
    {
        /// <summary>
        /// Sets the 'defer' portion of the preserveAspectRatio settings. This field only has an effect on an 'image' element that references another SVG document. As this is not currently supported, the field has no impact on rendering.
        /// </summary>
        public bool defer;
        /// <summary>
        /// Sets the align portion of the preserveAspectRatio settings.
        /// </summary>
        public D2D1_SVG_ASPECT_ALIGN align;
        /// <summary>
        /// Sets the meetOrSlice portion of the preserveAspectRatio settings.
        /// </summary>
        public D2D1_SVG_ASPECT_SCALING meetOrSlice;
    }
}
