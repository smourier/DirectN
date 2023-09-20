// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRSETPALETTEENTRIES
    {
        public tagEMR emr;
        public uint ihPal;
        public uint iStart;
        public uint cEntries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagPALETTEENTRY[] aPalEntries;
    }
}
