// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9827,9)
using System;
using System.Runtime.InteropServices;
using PDXGKDDI_CREATECPUEVENT = System.IntPtr;
using PDXGKDDI_DESTROYCPUEVENT = System.IntPtr;
using PDXGKDDI_SETALLOCATIONBACKINGSTORE = System.IntPtr;
using PINTERFACE_DEREFERENCE = System.IntPtr;
using PINTERFACE_REFERENCE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_WDDM3_ON_VB_INTERFACE
    {
        public ushort Size;
        public ushort Version;
        public IntPtr Context;
        public IntPtr InterfaceReference;
        public IntPtr InterfaceDereference;
        public IntPtr DxgkDdiSetAllocationBackingStore;
        public IntPtr DxgkDdiCreateCpuEvent;
        public IntPtr DxgkDdiDestroyCpuEvent;
    }
}
