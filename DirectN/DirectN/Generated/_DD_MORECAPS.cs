// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(820,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_MORECAPS
    {
        public uint dwSize;
        public uint dwAlphaCaps;
        public uint dwSVBAlphaCaps;
        public uint dwVSBAlphaCaps;
        public uint dwSSBAlphaCaps;
        public uint dwFilterCaps;
        public uint dwSVBFilterCaps;
        public uint dwVSBFilterCaps;
        public uint dwSSBFilterCaps;
    }
}
