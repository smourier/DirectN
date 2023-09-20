// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The creation properties for a ID2D1PrintControl object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_PRINT_CONTROL_PROPERTIES
    {
        public D2D1_PRINT_FONT_SUBSET_MODE fontSubset;
        /// <summary>
        /// DPI for rasterization of all unsupported D2D commands or options, defaults to 150.0
        /// </summary>
        public float rasterDPI;
        /// <summary>
        /// Color space for vector graphics in XPS package
        /// </summary>
        public D2D1_COLOR_SPACE colorSpace;
    }
}
