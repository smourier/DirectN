// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains rendering options (hardware or software), pixel format, DPI information, remoting options, and Direct3D support requirements for a render target.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_RENDER_TARGET_PROPERTIES
    {
        public D2D1_RENDER_TARGET_TYPE type;
        public D2D1_PIXEL_FORMAT pixelFormat;
        public float dpiX;
        public float dpiY;
        public D2D1_RENDER_TARGET_USAGE usage;
        public D2D1_FEATURE_LEVEL minLevel;
    }
}
