﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION
    {
        public ulong CommitLimit;
        public ulong BytesCommitted;
        public ulong BytesResident;
        public _D3DKMT_QUERYSTATISTICS_MEMORY Memory;
        public uint Aperture;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public ulong[] TotalBytesEvictedByPriority;
        public ulong SystemMemoryEndAddress;
        public _D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION__struct_0 PowerFlags;
        public _D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION__struct_1 SegmentProperties;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public ulong[] Reserved;
    }
}
