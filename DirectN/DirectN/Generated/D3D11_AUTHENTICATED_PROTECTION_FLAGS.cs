// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(10798,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_PROTECTION_FLAGS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __MIDL___MIDL_itf_d3d11_0000_0034_0001 Flags { get => InteropRuntime.Get<__MIDL___MIDL_itf_d3d11_0000_0034_0001>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<__MIDL___MIDL_itf_d3d11_0000_0034_0001>(value, __bits, 0, 32); } }
        public uint Value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
