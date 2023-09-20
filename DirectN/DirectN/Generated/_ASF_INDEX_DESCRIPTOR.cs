// generated from <Windows SDK Path>\um\wmcontainer.h
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
