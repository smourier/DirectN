// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_POINTERDATA
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint uCBOffset { get => InteropRuntime.GetUInt32(__bits, 0, 12); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 12); } }
        public uint uCBID { get => InteropRuntime.GetUInt32(__bits, 12, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 4); } }
        public uint uBaseSamp { get => InteropRuntime.GetUInt32(__bits, 16, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 4); } }
        public uint uBaseTex { get => InteropRuntime.GetUInt32(__bits, 20, 7); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 7); } }
        public uint uReserved { get => InteropRuntime.GetUInt32(__bits, 27, 5); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 27, 5); } }
    }
}
