// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(7589,9)
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
