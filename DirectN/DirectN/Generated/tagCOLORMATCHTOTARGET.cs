// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(6114,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOLORMATCHTOTARGET
    {
        public tagEMR emr;
        public uint dwAction;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Data;
    }
}
