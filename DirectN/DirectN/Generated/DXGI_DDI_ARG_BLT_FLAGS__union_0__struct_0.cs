// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(231,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_BLT_FLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint Resolve => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint Convert => InteropRuntime.GetUInt32(__bits, 1, 1);
        public uint Stretch => InteropRuntime.GetUInt32(__bits, 2, 1);
        public uint Present => InteropRuntime.GetUInt32(__bits, 3, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 4, 28);
    }
}
