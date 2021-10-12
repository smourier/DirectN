// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(7106,9)
using System;
using System.Runtime.InteropServices;
using PFND3D10DDI_RETRIEVESUBOBJECT = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_CREATEDEVICE
    {
        public D3D10DDI_HRTDEVICE hRTDevice;
        public uint Interface;
        public uint Version;
        public IntPtr pKTCallbacks;
        public D3D10DDIARG_CREATEDEVICE__union_0 __union_4;
        public D3D10DDI_HDEVICE hDrvDevice;
        public DXGI_DDI_BASE_ARGS DXGIBaseDDI;
        public D3D10DDI_HRTCORELAYER hRTCoreLayer;
        public D3D10DDIARG_CREATEDEVICE__union_1 __union_8;
        public uint Flags;
        public IntPtr ppfnRetrieveSubObject;
    }
}
