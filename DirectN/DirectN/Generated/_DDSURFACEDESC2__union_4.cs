// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC2__union_4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DDPIXELFORMAT ddpfPixelFormat { get => InteropRuntime.Get<_DDPIXELFORMAT>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_DDPIXELFORMAT>(value, __bits, 0, 256); } }
        public uint dwFVF { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[32]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
