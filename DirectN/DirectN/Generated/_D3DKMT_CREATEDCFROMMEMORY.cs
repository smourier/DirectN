// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4106,9)
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
