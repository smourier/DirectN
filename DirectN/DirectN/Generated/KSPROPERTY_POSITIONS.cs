// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ks.h(578,9)
using System;
using System.Runtime.InteropServices;
using KS_SEEKING_FLAGS = DirectN.KS_SEEKING;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_POSITIONS
    {
        public long Current;
        public long Stop;
        public KS_SEEKING_FLAGS CurrentFlags;
        public KS_SEEKING_FLAGS StopFlags;
    }
}
