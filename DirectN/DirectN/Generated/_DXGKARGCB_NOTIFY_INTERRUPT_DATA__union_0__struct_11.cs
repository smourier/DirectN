// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1092,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11
    {
        public ulong FaultedFenceId;
        public ulong FaultedVirtualAddress;
        public ulong FaultedPrimitiveAPISequenceNumber;
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11__union_0 __union_3;
        public uint NodeOrdinal;
        public uint EngineOrdinal;
        public _DXGK_RENDER_PIPELINE_STAGE FaultedPipelineStage;
        public uint FaultedBindTableEntry;
        public _DXGK_PAGE_FAULT_FLAGS PageFaultFlags;
        public uint PageTableLevel;
        public _DXGK_FAULT_ERROR_CODE FaultErrorCode;
    }
}
