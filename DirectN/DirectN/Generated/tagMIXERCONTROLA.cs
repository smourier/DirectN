// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\mmeapi.h(2048,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagMIXERCONTROLA
    {
        public uint cbStruct;
        public uint dwControlID;
        public uint dwControlType;
        public uint fdwControl;
        public uint cMultipleItems;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string szShortName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string szName;
        public tagMIXERCONTROLA__union_0 Bounds;
        public tagMIXERCONTROLA__union_1 Metrics;
    }
}
