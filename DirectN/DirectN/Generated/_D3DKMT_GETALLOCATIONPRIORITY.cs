﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(5065,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETALLOCATIONPRIORITY
    {
        public uint hDevice;
        public uint hResource;
        public IntPtr phAllocationList;
        public uint AllocationCount;
        public IntPtr pPriorities;
    }
}
