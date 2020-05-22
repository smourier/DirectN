// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(4178,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_TRIMPROCESSCOMMITMENT
    {
        public uint cbSize;
        public IntPtr hProcess;
        public _D3DKMT_TRIMPROCESSCOMMITMENT_FLAGS Flags;
        public ulong DecommitRequested;
        public ulong NumBytesDecommitted;
    }
}
