// generated from <Windows SDK Path>\um\opmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_CONFIGURE_PARAMETERS
    {
        public _OPM_OMAC omac;
        public Guid guidSetting;
        public uint ulSequenceNumber;
        public uint cbParametersSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)] 
        public byte[] abParameters;
    }
}
