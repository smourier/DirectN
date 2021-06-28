// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1120,9)
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
