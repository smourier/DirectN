// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREXTCREATEPEN
    {
        public tagEMR emr;
        public uint ihPen;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
        public tagEXTLOGPEN32 elp;
    }
}
