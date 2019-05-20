// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2538,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATEDEVICE_0003
    {
        public D3D10DDI_HRTDEVICE hRTDevice;
        public uint Interface;
        public uint Version;
        public IntPtr pKTCallbacks;
        public D3D10DDI_HDEVICE hDrvDevice;
        public D3D12DDIARG_CREATEDEVICE_0003__union_0 __union_5;
        public D3D12DDI_CREATE_DEVICE_FLAGS Flags;
    }
}
