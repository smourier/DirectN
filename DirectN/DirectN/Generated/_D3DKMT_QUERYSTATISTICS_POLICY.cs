// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3659,9)
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
