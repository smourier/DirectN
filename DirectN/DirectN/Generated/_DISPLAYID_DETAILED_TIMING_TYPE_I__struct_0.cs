// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(677,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DISPLAYID_DETAILED_TIMING_TYPE_I__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint PixelClock { get => InteropRuntime.GetUInt32(__bits, 0, 24); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 24); } }
        public uint AspectRatio { get => InteropRuntime.GetUInt32(__bits, 24, 3); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 3); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 27, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 27, 1); } }
        public uint ScanningType { get => InteropRuntime.GetUInt32(__bits, 28, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 28, 1); } }
        public uint StereoMode { get => InteropRuntime.GetUInt32(__bits, 29, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 29, 2); } }
        public uint PreferredTiming { get => InteropRuntime.GetUInt32(__bits, 31, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 31, 1); } }
    }
}
