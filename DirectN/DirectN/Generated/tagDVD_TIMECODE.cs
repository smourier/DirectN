// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_TIMECODE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Hours1 { get => InteropRuntime.GetUInt32(__bits, 0, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 4); } }
        public uint Hours10 { get => InteropRuntime.GetUInt32(__bits, 4, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 4); } }
        public uint Minutes1 { get => InteropRuntime.GetUInt32(__bits, 8, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 4); } }
        public uint Minutes10 { get => InteropRuntime.GetUInt32(__bits, 12, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 4); } }
        public uint Seconds1 { get => InteropRuntime.GetUInt32(__bits, 16, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 4); } }
        public uint Seconds10 { get => InteropRuntime.GetUInt32(__bits, 20, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 4); } }
        public uint Frames1 { get => InteropRuntime.GetUInt32(__bits, 24, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 4); } }
        public uint Frames10 { get => InteropRuntime.GetUInt32(__bits, 28, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 28, 2); } }
        public uint FrameRateCode { get => InteropRuntime.GetUInt32(__bits, 30, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 30, 2); } }
    }
}
