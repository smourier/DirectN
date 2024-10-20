// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETNATIVEFENCELOGBUFFER
    {
        public IntPtr hHwQueue;
        public uint NumberOfEntries;
        public IntPtr LogBufferCpuVa;
        public ulong LogBufferGpuVa;
        public ulong LogBufferSystemProcessGpuVa;
        public _DXGKARG_SETNATIVEFENCELOGBUFFER_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] Reserved;
    }
}
