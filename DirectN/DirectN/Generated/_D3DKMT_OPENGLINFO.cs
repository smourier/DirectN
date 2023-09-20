// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_OPENGLINFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string UmdOpenGlIcdFileName;
        public uint Version;
        public uint Flags;
    }
}
