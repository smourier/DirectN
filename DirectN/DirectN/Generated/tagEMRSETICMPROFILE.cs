// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(6135,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRSETICMPROFILE
    {
        public tagEMR emr;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Data;
    }
}
