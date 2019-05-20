// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(5541,9)
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
