// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(497,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ESCAPEFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint HardwareAccess { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint DeviceStatusQuery { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint ChangeFrameLatency { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint NoAdapterSynchronization { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint VirtualMachineData { get => InteropRuntime.GetUInt32(__bits, 5, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 1); } }
        public uint DriverKnownEscape { get => InteropRuntime.GetUInt32(__bits, 6, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 6, 1); } }
        public uint DriverCommonEscape { get => InteropRuntime.GetUInt32(__bits, 7, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 7, 1); } }
        public uint Reserved2 { get => InteropRuntime.GetUInt32(__bits, 8, 24); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 24); } }
    }
}
