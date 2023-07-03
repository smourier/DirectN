// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(6148,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRCREATECOLORSPACEW
    {
        public tagEMR emr;
        public uint ihCS;
        public tagLOGCOLORSPACEW lcs;
        public uint dwFlags;
        public uint cbData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Data;
    }
}
