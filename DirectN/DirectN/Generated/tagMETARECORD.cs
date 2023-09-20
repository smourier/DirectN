// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMETARECORD
    {
        public uint rdSize;
        public ushort rdFunction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public ushort[] rdParm;
    }
}
