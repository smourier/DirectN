// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcontainer.h(1638,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _ASF_INDEX_DESCRIPTOR
    {
        public _ASF_INDEX_IDENTIFIER Identifier;
        public ushort cPerEntryBytes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string szDescription;
        public uint dwInterval;
    }
}
