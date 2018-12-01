// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1586,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECT_FLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint Shared => InteropRuntime.GetUInt32Bits(__bits, 0, 1);
        public uint NtSecuritySharing => InteropRuntime.GetUInt32Bits(__bits, 1, 1);
        public uint CrossAdapter => InteropRuntime.GetUInt32Bits(__bits, 2, 1);
        public uint TopOfPipeline => InteropRuntime.GetUInt32Bits(__bits, 3, 1);
        public uint NoSignal => InteropRuntime.GetUInt32Bits(__bits, 4, 1);
        public uint NoWait => InteropRuntime.GetUInt32Bits(__bits, 5, 1);
        public uint NoSignalMaxValueOnTdr => InteropRuntime.GetUInt32Bits(__bits, 6, 1);
        public uint NoGPUAccess => InteropRuntime.GetUInt32Bits(__bits, 7, 1);
        public uint Reserved => InteropRuntime.GetUInt32Bits(__bits, 8, 23);
        public uint Reserved0 => InteropRuntime.GetUInt32Bits(__bits, 31, 1);
    }
}
