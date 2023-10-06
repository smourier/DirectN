// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_CERTIFICATE_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_1DDI_AUTHENTICATED_CHANNEL_TYPE ChannelType {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11_1DDI_AUTHENTICATED_CHANNEL_TYPE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_1DDI_AUTHENTICATED_CHANNEL_TYPE>(value, __bits, 0, 32); } }
        public Guid CryptoSessionType {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<Guid>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<Guid>(value, __bits, 0, 128); } }
    }
}
