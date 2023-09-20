// generated from <Windows SDK Path>\um\mfapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFFOLDDOWN_MATRIX
    {
        public uint cbSize;
        public uint cSrcChannels;
        public uint cDstChannels;
        public uint dwChannelMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public int[] Coeff;
    }
}
