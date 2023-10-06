// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIDPNSOURCEADDRESS
    {
        public uint VidPnSourceId;
        public uint PrimarySegment;
        public long PrimaryAddress;
        public IntPtr hAllocation;
        public uint ContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)] 
        public IntPtr[] Context;
        public _DXGK_SETVIDPNSOURCEADDRESS_FLAGS Flags;
        public uint Duration;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public _DXGK_PRIMARYDATA[] PrimaryData;
        public uint DriverPrivateDataSize;
        public IntPtr pDriverPrivateData;
    }
}
