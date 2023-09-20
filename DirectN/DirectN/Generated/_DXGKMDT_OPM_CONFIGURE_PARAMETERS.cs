// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_CONFIGURE_PARAMETERS
    {
        public _DXGKMDT_OPM_OMAC omac;
        public Guid guidSetting;
        public uint ulSequenceNumber;
        public uint cbParametersSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)] 
        public byte[] abParameters;
    }
}
