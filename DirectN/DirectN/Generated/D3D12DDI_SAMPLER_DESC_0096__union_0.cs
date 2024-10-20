// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SAMPLER_DESC_0096__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float[] FloatBorderColor {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<float>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<float>(value, __bits, 0, 128); } }
        public uint[] UintBorderColor {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<uint>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<uint>(value, __bits, 0, 128); } }
    }
}
