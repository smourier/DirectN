// generated from <Windows SDK Path>\shared\mmreg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct heaacwaveinfo_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort wPayloadType;
        public ushort wAudioProfileLevelIndication;
        public ushort wStructType;
        public ushort wReserved1;
        public uint dwReserved2;
    }
}
