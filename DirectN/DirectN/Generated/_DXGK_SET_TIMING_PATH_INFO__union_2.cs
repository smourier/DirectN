// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8074,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SET_TIMING_PATH_INFO__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_SET_TIMING_PATH_INFO__union_2__struct_0 Output { get => InteropRuntime.Get<_DXGK_SET_TIMING_PATH_INFO__union_2__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_SET_TIMING_PATH_INFO__union_2__struct_0>(value, __bits, 0, 32); } }
        public uint OutputFlags { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
