// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_SWIZZLE_BIT_ENTRY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte Valid { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte ChannelIndex { get => InteropRuntime.GetByte(__bits, 1, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 2); } }
        public byte SourceBitIndex { get => InteropRuntime.GetByte(__bits, 3, 5); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 5); } }
    }
}
