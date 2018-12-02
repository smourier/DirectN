// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\mmreg.h(3154,9)
using System;
using System.Runtime.InteropServices;
using WAVEFORMATEX = DirectN.tWAVEFORMATEX;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct heaacwaveinfo_tag
    {
        public WAVEFORMATEX wfx;
        public ushort wPayloadType;
        public ushort wAudioProfileLevelIndication;
        public ushort wStructType;
        public ushort wReserved1;
        public uint dwReserved2;
    }
}
