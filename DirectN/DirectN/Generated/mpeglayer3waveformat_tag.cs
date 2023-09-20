// generated from <Windows SDK Path>\shared\mmreg.h
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
