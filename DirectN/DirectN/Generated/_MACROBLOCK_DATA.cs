// generated from <Windows SDK Path>\um\mfapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MACROBLOCK_DATA
    {
        public uint flags;
        public short motionVectorX;
        public short motionVectorY;
        public int QPDelta;
    }
}
