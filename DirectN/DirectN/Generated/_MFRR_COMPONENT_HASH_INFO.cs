// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _MFRR_COMPONENT_HASH_INFO
    {
        public uint ulReason;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 43)] 
        public string rgHeaderHash;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 43)] 
        public string rgPublicKeyHash;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string wszName;
    }
}
