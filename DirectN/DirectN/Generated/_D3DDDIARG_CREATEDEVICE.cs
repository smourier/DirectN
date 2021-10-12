// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(4601,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CREATEDEVICE
    {
        public IntPtr hDevice;
        public uint Interface;
        public uint Version;
        public IntPtr pCallbacks;
        public IntPtr pCommandBuffer;
        public uint CommandBufferSize;
        public IntPtr pAllocationList;
        public uint AllocationListSize;
        public IntPtr pPatchLocationList;
        public uint PatchLocationListSize;
        public IntPtr pDeviceFuncs;
        public _D3DDDI_CREATEDEVICEFLAGS Flags;
        public ulong CommandBuffer;
    }
}
