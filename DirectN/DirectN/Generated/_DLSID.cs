// generated from <Windows SDK Path>\shared\dls1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DLSID
    {
        public uint ulData1;
        public ushort usData2;
        public ushort usData3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] abData4;
    }
}
