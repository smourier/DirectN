// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4638,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_WAITFORSYNCHRONIZATIONOBJECTFROMCPU
    {
        public uint hDevice;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
        public IntPtr hAsyncEvent;
        public _D3DDDI_WAITFORSYNCHRONIZATIONOBJECTFROMCPU_FLAGS Flags;
    }
}
