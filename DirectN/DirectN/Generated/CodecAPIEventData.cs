// generated from <Windows SDK Path>\um\strmif.h
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
