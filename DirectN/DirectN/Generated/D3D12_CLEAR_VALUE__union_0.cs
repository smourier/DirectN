// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_CLEAR_VALUE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float[] Color { get => InteropRuntime.GetArray<float>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<float>(value, __bits, 0, 128); } }
        public D3D12_DEPTH_STENCIL_VALUE DepthStencil { get => InteropRuntime.Get<D3D12_DEPTH_STENCIL_VALUE>(__bits, 0, 40); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_DEPTH_STENCIL_VALUE>(value, __bits, 0, 40); } }
    }
}
