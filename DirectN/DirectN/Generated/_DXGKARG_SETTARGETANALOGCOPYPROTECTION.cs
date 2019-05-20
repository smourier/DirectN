// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8377,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETTARGETANALOGCOPYPROTECTION
    {
        public uint TargetId;
        public _D3DKMDT_VIDPN_PRESENT_PATH_COPYPROTECTION_TYPE CopyProtectionType;
        public uint APSTriggerBits;
        public _D3DKMDT_VIDPN_PRESENT_PATH_COPYPROTECTION_SUPPORT CopyProtectionSupport;
    }
}
