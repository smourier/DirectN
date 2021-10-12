// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5493,9)
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
