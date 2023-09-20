// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This is used to define a resource texture when that resource texture is created.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_RESOURCE_TEXTURE_PROPERTIES
    {
        public IntPtr extents;
        public uint dimensions;
        public D2D1_BUFFER_PRECISION bufferPrecision;
        public D2D1_CHANNEL_DEPTH channelDepth;
        public D2D1_FILTER filter;
        public IntPtr extendModes;
    }
}
