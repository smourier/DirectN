// generated from <Windows SDK Path>\um\ksopmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_STANDARD_INFORMATION
    {
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulInformation;
        public uint ulReserved;
        public uint ulReserved2;
    }
}
