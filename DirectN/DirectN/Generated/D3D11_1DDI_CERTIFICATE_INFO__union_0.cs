// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(3515,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_CERTIFICATE_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_1DDI_AUTHENTICATED_CHANNEL_TYPE ChannelType { get => InteropRuntime.Get<D3D11_1DDI_AUTHENTICATED_CHANNEL_TYPE>(__bits, 0, 32); set => InteropRuntime.Set<D3D11_1DDI_AUTHENTICATED_CHANNEL_TYPE>(value, __bits, 0, 32); }
        public Guid CryptoSessionType { get => InteropRuntime.Get<Guid>(__bits, 0, 128); set => InteropRuntime.Set<Guid>(value, __bits, 0, 128); }
    }
}
