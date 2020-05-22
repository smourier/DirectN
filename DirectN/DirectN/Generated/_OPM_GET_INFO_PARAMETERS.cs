// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ksopmapi.h(79,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_GET_INFO_PARAMETERS
    {
        public _OPM_OMAC omac;
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public Guid guidInformation;
        public uint ulSequenceNumber;
        public uint cbParametersSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)] 
        public byte[] abParameters;
    }
}
