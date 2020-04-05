// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shadertracing.h(226,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TRACE_REGISTER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort Index1D { get => InteropRuntime.GetUInt16(__bits, 0, 16); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt16(value, __bits, 0, 16); } }
        public ushort[] Index2D { get => InteropRuntime.GetArray<ushort>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetArray<ushort>(value, __bits, 0, 32); } }
    }
}
