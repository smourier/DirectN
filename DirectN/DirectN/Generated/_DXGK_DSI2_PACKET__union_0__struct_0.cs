﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_PACKET__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint DataType { get => InteropRuntime.GetUInt32(__bits, 0, 6); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 0, 6); } }
        public uint VirtualChannel { get => InteropRuntime.GetUInt32(__bits, 6, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 6, 2); } }
    }
}
