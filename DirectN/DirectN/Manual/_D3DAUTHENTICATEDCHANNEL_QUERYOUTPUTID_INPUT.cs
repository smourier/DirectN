﻿// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT_32
    {
        public _D3DAUTHENTICATEDCHANNEL_QUERY_INPUT_32 Input;
        public IntPtr DeviceHandle;
        public IntPtr CryptoSessionHandle;
        public uint OutputIDIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT_64
    {
        public _D3DAUTHENTICATEDCHANNEL_QUERY_INPUT_64 Input;
        public IntPtr DeviceHandle;
        public IntPtr CryptoSessionHandle;
        public uint OutputIDIndex;
    }
}
