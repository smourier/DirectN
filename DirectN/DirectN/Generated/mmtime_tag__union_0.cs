// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmsyscom.h(110,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct mmtime_tag__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint ms { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint sample { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint cb { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint ticks { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public mmtime_tag__union_0__struct_0 smpte { get => InteropRuntime.Get<mmtime_tag__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<mmtime_tag__union_0__struct_0>(value, __bits, 0, 64); } }
        public mmtime_tag__union_0__struct_1 midi { get => InteropRuntime.Get<mmtime_tag__union_0__struct_1>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<mmtime_tag__union_0__struct_1>(value, __bits, 0, 32); } }
    }
}
