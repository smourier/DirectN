// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_STANDARD_INFORMATION
    {
        public _DXGKMDT_OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulInformation;
        public uint ulReserved;
        public uint ulReserved2;
    }
}
