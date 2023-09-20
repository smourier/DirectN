// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_TRANSMISSION__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint PacketCount { get => InteropRuntime.GetUInt32(__bits, 0, 8); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 8); } }
        public uint FailedPacket { get => InteropRuntime.GetUInt32(__bits, 8, 8); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 8); } }
        public uint TransmissionMode { get => InteropRuntime.GetUInt32(__bits, 16, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 2); } }
        public uint ReportMipiErrors { get => InteropRuntime.GetUInt32(__bits, 18, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 1); } }
        public uint ClearMipiErrors { get => InteropRuntime.GetUInt32(__bits, 19, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 19, 1); } }
        public uint SecondaryPort { get => InteropRuntime.GetUInt32(__bits, 20, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 21, 11); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 21, 11); } }
    }
}
