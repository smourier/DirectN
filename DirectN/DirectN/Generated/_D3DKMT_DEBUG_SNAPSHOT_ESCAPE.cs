// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DEBUG_SNAPSHOT_ESCAPE
    {
        public uint Length;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Buffer;
    }
}
