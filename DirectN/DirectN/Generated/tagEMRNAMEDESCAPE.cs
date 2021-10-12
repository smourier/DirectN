// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(6124,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRNAMEDESCAPE
    {
        public tagEMR emr;
        public int iEscape;
        public int cbDriver;
        public int cbEscData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] EscData;
    }
}
