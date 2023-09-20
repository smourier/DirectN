// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_BLOCKLIST_INFO
    {
        public uint Size;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string BlockList;
    }
}
