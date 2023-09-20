// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_POLICY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public ulong[] PreferApertureForRead;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public ulong[] PreferAperture;
        public ulong MemResetOnPaging;
        public ulong RemovePagesFromWorkingSetOnPaging;
        public ulong MigrationEnabled;
    }
}
