// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEDOORBELL
    {
        public IntPtr hHwQueue;
        public IntPtr hDoorbell;
        public uint PrivateDriverDataSize;
        public IntPtr PrivateDriverData;
        public IntPtr hRingBuffer;
        public IntPtr hRingBufferControl;
        public _DXGKARG_CREATEDOORBELL_FLAGS Flags;
    }
}
