// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _KSGOP_USERDATA
    {
        public uint sc;
        public uint reserved1;
        public byte cFields;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)] 
        public string l21Data;
    }
}
