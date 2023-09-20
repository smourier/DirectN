// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC2__union_3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DDCOLORKEY ddckCKDestOverlay { get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); } }
        public uint dwEmptyFaceColor { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
