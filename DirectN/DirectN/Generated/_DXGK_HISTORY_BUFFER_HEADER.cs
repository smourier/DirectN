// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_HISTORY_BUFFER_HEADER
    {
        public uint RenderCbSequence;
        public uint NumTimestamps;
        public uint PrivateDataSize;
        public uint Reserved;
    }
}
