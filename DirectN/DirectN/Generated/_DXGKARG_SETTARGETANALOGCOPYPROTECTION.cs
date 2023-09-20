// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
