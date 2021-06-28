// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_3.h(117,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Properties of a transformed image source.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES
    {
        /// <summary>
        /// The orientation at which the image source is drawn.
        /// </summary>
        public D2D1_ORIENTATION orientation;
        /// <summary>
        /// The horizontal scale factor at which the image source is drawn.
        /// </summary>
        public float scaleX;
        /// <summary>
        /// The vertical scale factor at which the image source is drawn.
        /// </summary>
        public float scaleY;
        /// <summary>
        /// The interpolation mode used when the image source is drawn. This is ignored if the image source is drawn using the DrawImage method, or using an image brush.
        /// </summary>
        public D2D1_INTERPOLATION_MODE interpolationMode;
        /// <summary>
        /// Option flags.
        /// </summary>
        public D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS options;
    }
}
