// generated from <Windows SDK Path>\um\amva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _tag_AMVACompBufferInfo
    {
        public uint dwNumCompBuffers;
        public uint dwWidthToCreate;
        public uint dwHeightToCreate;
        public uint dwBytesToAllocate;
        public int ddCompCaps;
        public int ddPixelFormat;
    }
}
