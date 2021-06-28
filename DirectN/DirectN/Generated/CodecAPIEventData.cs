// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(4319,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct CodecAPIEventData
    {
        public Guid guid;
        public uint dataLength;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] reserved;
    }
}
