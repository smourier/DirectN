// generated from <Windows SDK Path>\um\wingdi.h
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
