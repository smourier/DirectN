// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(4191,9)
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
