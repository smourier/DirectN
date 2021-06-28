// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(368,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes options transforms may select to use on their input textures.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_INPUT_DESCRIPTION
    {
        public D2D1_FILTER filter;
        public uint levelOfDetailCount;
    }
}
