// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1048,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_7
    {
        public uint FaultedFenceId;
        public ulong FaultedPrimitiveAPISequenceNumber;
        public _DXGK_RENDER_PIPELINE_STAGE FaultedPipelineStage;
        public uint FaultedBindTableEntry;
        public _DXGK_PAGE_FAULT_FLAGS PageFaultFlags;
        public ulong FaultedVirtualAddress;
        public uint NodeOrdinal;
        public uint EngineOrdinal;
        public uint PageTableLevel;
        public _DXGK_FAULT_ERROR_CODE FaultErrorCode;
        public IntPtr FaultedProcessHandle;
    }
}
