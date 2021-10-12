// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(1010,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_PRESENT_PATH_SCALING_SUPPORT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Identity { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint Centered { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint Stretched { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint AspectRatioCenteredMax { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint Custom { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
    }
}
