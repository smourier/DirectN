// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4655,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SIGNALSYNCHRONIZATIONOBJECTFROMCPU
    {
        public uint hDevice;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
        public _D3DDDICB_SIGNALFLAGS Flags;
    }
}
