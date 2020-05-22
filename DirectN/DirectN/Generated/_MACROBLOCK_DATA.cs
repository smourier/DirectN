// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfapi.h(1378,9)
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
