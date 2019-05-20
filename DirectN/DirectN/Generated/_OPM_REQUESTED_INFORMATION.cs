// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ksopmapi.h(90,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_REQUESTED_INFORMATION
    {
        public _OPM_OMAC omac;
        public uint cbRequestedInformationSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4076)] 
        public byte[] abRequestedInformation;
    }
}
