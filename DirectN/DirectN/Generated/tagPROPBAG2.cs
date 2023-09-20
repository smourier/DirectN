// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagPROPBAG2
    {
        public uint dwType;
        public ushort vt;
        public ushort cfType;
        public uint dwHint;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pstrName;
        public Guid clsid;
    }
}
