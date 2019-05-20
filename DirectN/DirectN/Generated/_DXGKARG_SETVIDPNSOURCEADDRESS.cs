// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5343,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIDPNSOURCEADDRESS
    {
        public uint VidPnSourceId;
        public uint PrimarySegment;
        public PHYSICAL_ADDRESS PrimaryAddress;
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
