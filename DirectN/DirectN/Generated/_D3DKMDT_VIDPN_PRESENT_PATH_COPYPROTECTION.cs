// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_PRESENT_PATH_COPYPROTECTION
    {
        public _D3DKMDT_VIDPN_PRESENT_PATH_COPYPROTECTION_TYPE CopyProtectionType;
        public uint APSTriggerBits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public byte[] OEMCopyProtection;
        public _D3DKMDT_VIDPN_PRESENT_PATH_COPYPROTECTION_SUPPORT CopyProtectionSupport;
    }
}
