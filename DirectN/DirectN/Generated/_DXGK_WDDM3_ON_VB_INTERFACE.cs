// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
