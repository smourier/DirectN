// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(13482,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _timecode
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _timecode__struct_0 __field_0 { get => InteropRuntime.Get<_timecode__struct_0>(__bits, 0, 64); set => InteropRuntime.Set<_timecode__struct_0>(value, __bits, 0, 64); }
        public ulong qw { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
    }
}
