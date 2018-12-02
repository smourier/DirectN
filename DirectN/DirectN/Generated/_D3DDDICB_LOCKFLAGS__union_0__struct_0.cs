// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(431,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_LOCKFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint ReadOnly => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint WriteOnly => InteropRuntime.GetUInt32(__bits, 1, 1);
        public uint DonotWait => InteropRuntime.GetUInt32(__bits, 2, 1);
        public uint IgnoreSync => InteropRuntime.GetUInt32(__bits, 3, 1);
        public uint LockEntire => InteropRuntime.GetUInt32(__bits, 4, 1);
        public uint DonotEvict => InteropRuntime.GetUInt32(__bits, 5, 1);
        public uint AcquireAperture => InteropRuntime.GetUInt32(__bits, 6, 1);
        public uint Discard => InteropRuntime.GetUInt32(__bits, 7, 1);
        public uint NoExistingReference => InteropRuntime.GetUInt32(__bits, 8, 1);
        public uint UseAlternateVA => InteropRuntime.GetUInt32(__bits, 9, 1);
        public uint IgnoreReadSync => InteropRuntime.GetUInt32(__bits, 10, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 11, 21);
    }
}
