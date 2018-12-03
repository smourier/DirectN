// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(13482,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _timecode
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public _timecode__struct_0 __field_0 => InteropRuntime.Get<_timecode__struct_0>(__bits, 0, 64);
        public ulong qw => InteropRuntime.GetUInt6s(__bits, 0, 64);
    }
}
