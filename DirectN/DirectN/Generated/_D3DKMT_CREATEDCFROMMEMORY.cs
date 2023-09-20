// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEDCFROMMEMORY
    {
        public IntPtr pMemory;
        public _D3DDDIFORMAT Format;
        public uint Width;
        public uint Height;
        public uint Pitch;
        public IntPtr hDeviceDc;
        public IntPtr pColorTable;
        public IntPtr hDc;
        public IntPtr hBitmap;
    }
}
