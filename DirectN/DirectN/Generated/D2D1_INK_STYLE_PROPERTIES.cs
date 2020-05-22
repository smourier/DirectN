// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_3.h(179,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Defines the general pen tip shape and the transform used in an ID2D1InkStyle object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_INK_STYLE_PROPERTIES
    {
        /// <summary>
        /// The general shape of the nib used to draw a given ink object.
        /// </summary>
        public D2D1_INK_NIB_SHAPE nibShape;
        /// <summary>
        /// The transform applied to shape of the nib. _31 and _32 are ignored.
        /// </summary>
        public D2D_MATRIX_3X2_F nibTransform;
    }
}
