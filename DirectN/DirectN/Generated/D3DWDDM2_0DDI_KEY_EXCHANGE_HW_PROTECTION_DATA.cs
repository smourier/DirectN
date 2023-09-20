// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_KEY_EXCHANGE_HW_PROTECTION_DATA
    {
        public uint HWProtectionFunctionID;
        public IntPtr pInputData;
        public IntPtr pOutputData;
        public HRESULT Status;
    }
}
