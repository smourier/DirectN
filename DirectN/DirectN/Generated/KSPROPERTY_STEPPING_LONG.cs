// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(302,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_STEPPING_LONG
    {
        public uint SteppingDelta;
        public uint Reserved;
        public KSPROPERTY_BOUNDS_LONG Bounds;
    }
}
