﻿// generated from <Windows SDK Path>\shared\mmreg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct wmaudio3waveformat_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort wValidBitsPerSample;
        public uint dwChannelMask;
        public uint dwReserved1;
        public uint dwReserved2;
        public ushort wEncodeOptions;
        public ushort wReserved3;
    }
}
