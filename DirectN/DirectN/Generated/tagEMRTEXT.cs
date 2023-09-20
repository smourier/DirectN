// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRTEXT
    {
        public _POINTL ptlReference;
        public uint nChars;
        public uint offString;
        public uint fOptions;
        public _RECTL rcl;
        public uint offDx;
    }
}
