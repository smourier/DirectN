// generated from <Windows SDK Path>\shared\dmdls.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_WAVEARTDL
    {
        public uint ulDownloadIdIdx;
        public uint ulBus;
        public uint ulBuffers;
        public uint ulMasterDLId;
        public ushort usOptions;
    }
}
