// generated from <Windows SDK Path>\um\d2d1effectauthor.h
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
