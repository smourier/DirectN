// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(466,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_DESTROYALLOCATION2FLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint AssumeNotInUse => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint SynchronousDestroy => InteropRuntime.GetUInt32(__bits, 1, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 2, 29);
        public uint SystemUseOnly => InteropRuntime.GetUInt32(__bits, 31, 1);
    }
}
