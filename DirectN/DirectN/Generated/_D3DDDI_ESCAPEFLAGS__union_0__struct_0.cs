// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(481,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ESCAPEFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint HardwareAccess => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint DeviceStatusQuery => InteropRuntime.GetUInt32(__bits, 1, 1);
        public uint ChangeFrameLatency => InteropRuntime.GetUInt32(__bits, 2, 1);
        public uint NoAdapterSynchronization => InteropRuntime.GetUInt32(__bits, 3, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 4, 1);
        public uint VirtualMachineData => InteropRuntime.GetUInt32(__bits, 5, 1);
        public uint DriverKnownEscape => InteropRuntime.GetUInt32(__bits, 6, 1);
        public uint DriverCommonEscape => InteropRuntime.GetUInt32(__bits, 7, 1);
        public uint Reserved2 => InteropRuntime.GetUInt32(__bits, 8, 24);
    }
}
