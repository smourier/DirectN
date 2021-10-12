// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(563,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RESOURCE_ALLOCATION_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong AdditionalDataHeaderAlignment { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public D3D12DDI_RESOURCE_ALLOCATION_INFO__union_0__struct_0 __field_1 { get => InteropRuntime.Get<D3D12DDI_RESOURCE_ALLOCATION_INFO__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<D3D12DDI_RESOURCE_ALLOCATION_INFO__union_0__struct_0>(value, __bits, 0, 64); } }
    }
}
