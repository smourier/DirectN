// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(18357,9)
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
