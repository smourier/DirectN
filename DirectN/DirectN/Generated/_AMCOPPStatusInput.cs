// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AMCOPPStatusInput
    {
        public Guid rApp;
        public Guid guidStatusRequestID;
        public uint dwSequence;
        public uint cbSizeData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)] 
        public byte[] StatusData;
    }
}
