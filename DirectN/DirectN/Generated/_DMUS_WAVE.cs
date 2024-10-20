// generated from <Windows SDK Path>\shared\dmdls.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_WAVE
    {
        public uint ulFirstExtCkIdx;
        public uint ulCopyrightIdx;
        public uint ulWaveDataIdx;
        public tWAVEFORMATEX WaveformatEx;
    }
}
