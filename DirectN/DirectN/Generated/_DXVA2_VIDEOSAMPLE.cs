// generated from <Windows SDK Path>\um\dxva2swdev.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_VIDEOSAMPLE
    {
        public int Start;
        public int End;
        public int SampleFormat;
        public uint SampleFlags;
        public IntPtr SrcResource;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public int[] Pal;
        public int PlanarAlpha;
    }
}
