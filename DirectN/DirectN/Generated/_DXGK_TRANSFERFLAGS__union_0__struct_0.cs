﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3738,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_TRANSFERFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Swizzle { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint Unswizzle { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint AllocationIsIdle { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint TransferStart { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint TransferEnd { get => InteropRuntime.GetUInt32(__bits, 4, 1); set => InteropRuntime.SetUInt32(value, __bits, 4, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 5, 27); set => InteropRuntime.SetUInt32(value, __bits, 5, 27); }
    }
}