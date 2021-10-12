// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\opmapi.h(298,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS
    {
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public Guid guidInformation;
        public uint ulSequenceNumber;
        public uint cbParametersSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)] 
        public byte[] abParameters;
    }
}
