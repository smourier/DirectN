// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_0080_2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr pH264Config { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pHEVCConfig { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
