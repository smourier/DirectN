// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETFLIPQUEUELOGBUFFER
    {
        public uint VidPnSourceId;
        public uint LayerIndex;
        public uint NumberOfEntries;
        public IntPtr LogBufferAddress;
    }
}
