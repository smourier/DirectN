// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ks.h(322,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_STEPPING_LONGLONG
    {
        public ulong SteppingDelta;
        public KSPROPERTY_BOUNDS_LONGLONG Bounds;
    }
}
