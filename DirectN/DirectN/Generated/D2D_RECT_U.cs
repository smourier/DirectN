﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcommon.h(238,9)
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
