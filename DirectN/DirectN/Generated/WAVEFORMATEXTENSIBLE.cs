// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\mmreg.h(2522,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct WAVEFORMATEXTENSIBLE
    {
        public tWAVEFORMATEX Format;
        public __struct_mmreg_23__union_0 Samples;
        public uint dwChannelMask;
        public Guid SubFormat;
    }
}
