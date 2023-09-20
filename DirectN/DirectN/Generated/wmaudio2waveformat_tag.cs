// generated from <Windows SDK Path>\shared\mmreg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct wmaudio2waveformat_tag
    {
        public tWAVEFORMATEX wfx;
        public uint dwSamplesPerBlock;
        public ushort wEncodeOptions;
        public uint dwSuperBlockAlign;
    }
}
