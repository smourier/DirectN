// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(66,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_PRESENT_FLAGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public DXGI_DDI_PRESENT_FLAGS__union_0__struct_0 __field_0 => InteropRuntime.GetBits<DXGI_DDI_PRESENT_FLAGS__union_0__struct_0>(__bits, 0, 32);
        public uint Value => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
