// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _RGNDATAHEADER
    {
        public uint dwSize;
        public uint iType;
        public uint nCount;
        public uint nRgnSize;
        public tagRECT rcBound;
    }
}
