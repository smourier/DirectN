// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(66,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_PRESENT_FLAGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public DXGI_DDI_PRESENT_FLAGS__union_0__struct_0 __field_0 { get => InteropRuntime.Get<DXGI_DDI_PRESENT_FLAGS__union_0__struct_0>(__bits, 0, 32); set => InteropRuntime.Set<DXGI_DDI_PRESENT_FLAGS__union_0__struct_0>(value, __bits, 0, 32); }
        public uint Value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
    }
}
