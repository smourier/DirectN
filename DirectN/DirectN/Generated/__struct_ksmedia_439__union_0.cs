// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(7020,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ksmedia_439__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Capabilities { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint SignalMode { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint LoadMedium { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public MEDIUM_INFO MediumInfo { get => InteropRuntime.Get<MEDIUM_INFO>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.Set<MEDIUM_INFO>(value, __bits, 0, 96); } }
        public TRANSPORT_STATE XPrtState { get => InteropRuntime.Get<TRANSPORT_STATE>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.Set<TRANSPORT_STATE>(value, __bits, 0, 64); } }
        public __struct_ksmedia_439__union_0__struct_0 Timecode { get => InteropRuntime.Get<__struct_ksmedia_439__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.Set<__struct_ksmedia_439__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint dwTimecode { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint dwAbsTrackNumber { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public __struct_ksmedia_439__union_0__struct_1 RawAVC { get => InteropRuntime.Get<__struct_ksmedia_439__union_0__struct_1>(__bits, 0, 8192); set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.Set<__struct_ksmedia_439__union_0__struct_1>(value, __bits, 0, 8192); } }
    }
}
