// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_POLLDISPLAYCHILDREN
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint hAdapter { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint NonDestructiveOnly { get => InteropRuntime.GetUInt32(__bits, 32, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 32, 1); } }
        public uint SynchronousPolling { get => InteropRuntime.GetUInt32(__bits, 33, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 33, 1); } }
        public uint DisableModeReset { get => InteropRuntime.GetUInt32(__bits, 34, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 34, 1); } }
        public uint PollAllAdapters { get => InteropRuntime.GetUInt32(__bits, 35, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 35, 1); } }
        public uint PollInterruptible { get => InteropRuntime.GetUInt32(__bits, 36, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 36, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 37, 27); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 37, 27); } }
    }
}
