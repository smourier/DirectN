// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_ADAPTERREGISTRYINFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string AdapterString;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string BiosString;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string DacType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string ChipType;
    }
}
