// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct KSPIN_PHYSICALCONNECTION
    {
        public uint Size;
        public uint Pin;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string SymbolicLinkName;
    }
}
