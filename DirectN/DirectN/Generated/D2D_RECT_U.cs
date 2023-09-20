// generated from <Windows SDK Path>\um\dcommon.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a rectangle defined by the coordinates of the upper-left corner (left, top) and the coordinates of the lower-right corner (right, bottom).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_RECT_U
    {
        public uint left;
        public uint top;
        public uint right;
        public uint bottom;
    }
}
