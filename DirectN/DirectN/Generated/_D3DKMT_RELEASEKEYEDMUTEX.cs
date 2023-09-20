// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_RELEASEKEYEDMUTEX
    {
        public uint hKeyedMutex;
        public ulong Key;
        public ulong FenceValue;
    }
}
