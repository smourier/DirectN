// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(6069,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREXTESCAPE
    {
        public tagEMR emr;
        public int iEscape;
        public int cbEscData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] EscData;
    }
}
