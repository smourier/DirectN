// generated from <Windows SDK Path>\um\ksopmapi.h
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
