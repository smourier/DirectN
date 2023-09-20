// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTERPINS2
    {
        public uint dwFlags;
        public uint cInstances;
        public uint nMediaTypes;
        public IntPtr lpMediaType;
        public uint nMediums;
        public IntPtr lpMedium;
        public IntPtr clsPinCategory;
    }
}
