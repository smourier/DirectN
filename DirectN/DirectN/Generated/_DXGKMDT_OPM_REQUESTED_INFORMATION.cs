// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_REQUESTED_INFORMATION
    {
        public _DXGKMDT_OPM_OMAC omac;
        public uint cbRequestedInformationSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4076)] 
        public byte[] abRequestedInformation;
    }
}
