// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2028,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DRIVERCAPS
    {
        public PHYSICAL_ADDRESS HighestAcceptableAddress;
        public uint MaxAllocationListSlotId;
        public IntPtr ApertureSegmentCommitLimit;
        public uint MaxPointerWidth;
        public uint MaxPointerHeight;
        public _DXGK_POINTERFLAGS PointerCaps;
        public uint InterruptMessageNumber;
        public uint NumberOfSwizzlingRanges;
        public uint MaxOverlays;
        public _DXGK_DRIVERCAPS__union_0 __union_9;
        public _DXGK_PRESENTATIONCAPS PresentationCaps;
        public uint MaxQueuedFlipOnVSync;
        public _DXGK_FLIPCAPS FlipCaps;
        public _DXGK_VIDSCHCAPS SchedulingCaps;
        public _DXGK_VIDMMCAPS MemoryManagementCaps;
        public _DXGK_GPUENGINETOPOLOGY GpuEngineTopology;
        public _DXGK_WDDMVERSION WDDMVersion;
        public _DXGK_VIRTUALADDRESSCAPS_DEPRECATED Reserved;
        public _DXGK_DMABUFFERCAPS_DEPRECATED Reserved1;
        public _D3DKMDT_PREEMPTION_CAPS PreemptionCaps;
        public byte SupportNonVGA;
        public byte SupportSmoothRotation;
        public byte SupportPerEngineTDR;
        public byte SupportDirectFlip;
        public byte SupportMultiPlaneOverlay;
        public byte SupportRuntimePowerManagement;
        public byte SupportSurpriseRemovalInHibernation;
        public byte HybridDiscrete;
        public uint MaxOverlayPlanes;
        public byte HybridIntegrated;
        public ulong InternalGpuVirtualAddressRangeStart;
        public ulong InternalGpuVirtualAddressRangeEnd;
        public byte SupportSurpriseRemoval;
        public byte SupportMultiPlaneOverlayImmediateFlip;
        public byte CursorScaledWithMultiPlaneOverlayPlane0;
        public byte HybridAcpiChainingRequired;
        public uint MaxQueuedMultiPlaneOverlayFlipVSync;
        public _DXGK_DRIVERCAPS__union_1 MiscCaps;
    }
}
