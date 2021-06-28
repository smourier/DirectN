// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(718,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the content bounds, mask information, opacity settings, and other options for a layer resource.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_LAYER_PARAMETERS
    {
        /// <summary>
        /// The rectangular clip that will be applied to the layer. The clip is affected by the world transform. Content outside of the content bounds will not render.
        /// </summary>
        public D2D_RECT_F contentBounds;
        /// <summary>
        /// A general mask that can be optionally applied to the content. Content not inside the fill of the mask will not be rendered.
        /// </summary>
        public IntPtr geometricMask;
        /// <summary>
        /// Specifies whether the mask should be aliased or antialiased.
        /// </summary>
        public D2D1_ANTIALIAS_MODE maskAntialiasMode;
        /// <summary>
        /// An additional transform that may be applied to the mask in addition to the current world transform.
        /// </summary>
        public D2D_MATRIX_3X2_F maskTransform;
        /// <summary>
        /// The opacity with which all of the content in the layer will be blended back to the target when the layer is popped.
        /// </summary>
        public float opacity;
        /// <summary>
        /// An additional brush that can be applied to the layer. Only the opacity channel is sampled from this brush and multiplied both with the layer content and the over-all layer opacity.
        /// </summary>
        public IntPtr opacityBrush;
        /// <summary>
        /// Specifies if ClearType will be rendered into the layer.
        /// </summary>
        public D2D1_LAYER_OPTIONS layerOptions;
    }
}
