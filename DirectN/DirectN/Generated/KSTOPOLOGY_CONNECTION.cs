// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSTOPOLOGY_CONNECTION
    {
        public uint FromNode;
        public uint FromNodePin;
        public uint ToNode;
        public uint ToNodePin;
    }
}
