// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\mmreg.h(3055,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct mpeglayer3waveformat_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort wID;
        public uint fdwFlags;
        public ushort nBlockSize;
        public ushort nFramesPerBlock;
        public ushort nCodecDelay;
    }
}
