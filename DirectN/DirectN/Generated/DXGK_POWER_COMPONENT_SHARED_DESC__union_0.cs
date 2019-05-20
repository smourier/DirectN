// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2795,11)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGK_POWER_COMPONENT_SHARED_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public DXGK_POWER_COMPONENT_SHARED_DESC__union_0__struct_0 __field_0 { get => InteropRuntime.Get<DXGK_POWER_COMPONENT_SHARED_DESC__union_0__struct_0>(__bits, 0, 32); set => InteropRuntime.Set<DXGK_POWER_COMPONENT_SHARED_DESC__union_0__struct_0>(value, __bits, 0, 32); }
        public uint SharedType { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
    }
}
