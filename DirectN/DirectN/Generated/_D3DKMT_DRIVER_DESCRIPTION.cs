// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_DRIVER_DESCRIPTION
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4096)] 
        public string DriverDescription;
    }
}
