// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(1820,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Data for a single glyph from GetGlyphImageData.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_GLYPH_IMAGE_DATA
    {
        /// <summary>
        /// Pointer to the glyph data, be it SVG, PNG, JPEG, TIFF.
        /// </summary>
        public IntPtr imageData;
        /// <summary>
        /// Size of glyph data in bytes.
        /// </summary>
        public uint imageDataSize;
        /// <summary>
        /// Unique identifier for the glyph data. Clients may use this to cache a parsed/decompressed version and tell whether a repeated call to the same font returns the same data.
        /// </summary>
        public uint uniqueDataId;
        /// <summary>
        /// Pixels per em of the returned data. For non-scalable raster data (PNG/TIFF/JPG), this can be larger or smaller than requested from GetGlyphImageData when there isn't an exact match. For scaling intermediate sizes, use: desired pixels per em * font em size / actual pixels per em.
        /// </summary>
        public uint pixelsPerEm;
        /// <summary>
        /// Size of image when the format is pixel data.
        /// </summary>
        public D2D_SIZE_U pixelSize;
        /// <summary>
        /// Left origin along the horizontal Roman baseline.
        /// </summary>
        public tagPOINT horizontalLeftOrigin;
        /// <summary>
        /// Right origin along the horizontal Roman baseline.
        /// </summary>
        public tagPOINT horizontalRightOrigin;
        /// <summary>
        /// Top origin along the vertical central baseline.
        /// </summary>
        public tagPOINT verticalTopOrigin;
        /// <summary>
        /// Bottom origin along vertical central baseline.
        /// </summary>
        public tagPOINT verticalBottomOrigin;
    }
}
