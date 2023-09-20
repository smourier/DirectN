// generated from <Windows SDK Path>\um\d3d11_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA
    {
        public uint HWProtectionFunctionID;
        public IntPtr pInputData;
        public IntPtr pOutputData;
        public HRESULT Status;
    }
}
