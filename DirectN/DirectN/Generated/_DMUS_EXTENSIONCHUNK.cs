// generated from <Windows SDK Path>\shared\dmdls.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_EXTENSIONCHUNK
    {
        public uint cbSize;
        public uint ulNextExtCkIdx;
        public uint ExtCkID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] byExtCk;
    }
}
