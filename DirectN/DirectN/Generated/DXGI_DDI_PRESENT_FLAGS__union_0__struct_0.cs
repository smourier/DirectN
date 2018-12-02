// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(68,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_PRESENT_FLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint Blt => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint Flip => InteropRuntime.GetUInt32(__bits, 1, 1);
        public uint PreferRight => InteropRuntime.GetUInt32(__bits, 2, 1);
        public uint TemporaryMono => InteropRuntime.GetUInt32(__bits, 3, 1);
        public uint AllowTearing => InteropRuntime.GetUInt32(__bits, 4, 1);
        public uint AllowFlexibleRefresh => InteropRuntime.GetUInt32(__bits, 5, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 6, 26);
    }
}
