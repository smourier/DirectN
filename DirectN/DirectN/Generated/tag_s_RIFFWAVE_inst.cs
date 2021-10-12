// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\mmreg.h(3495,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct tag_s_RIFFWAVE_inst
    {
        public byte bUnshiftedNote;
        public byte chFineTune;
        public byte chGain;
        public byte bLowNote;
        public byte bHighNote;
        public byte bLowVelocity;
        public byte bHighVelocity;
    }
}
